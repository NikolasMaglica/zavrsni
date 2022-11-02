using aplikacija_server.Entities;

using Microsoft.EntityFrameworkCore;
using nikolas.Contracts;
using nikolas.Inferfaces;
using nikolas.Repository;
using NLog;
using Server.Extensions;
using WebApi.Helpers;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
var myAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.ConfigureLoggerService();

builder.Services.AddControllers();
builder.Services.AddScoped<IVehicle_TypeRepository, Vehicle_TypeRepository>();
builder.Services.AddScoped<IOfferRepository, OfferRepository>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddScoped<IOffer_Status, Offer__StatusRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IService_OfferRepository, Service_OfferRepository>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrder_StatusRepository, Order_StatusRepository>();
builder.Services.AddScoped<IMaterialRepository, MaterialRepository>();
builder.Services.AddScoped<IOfferRepository, OfferRepository>();
builder.Services.AddScoped<IMaterial_OfferRepository, Material_OfferRepository>();
builder.Services.AddScoped<IUser, UserRepository>();
builder.Services.AddScoped<IOrder_MaterialRepository, Order_MaterialRepository>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<RepositoryContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("konekcija"))
);
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
.AllowAnyHeader();
        });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(myAllowSpecificOrigins);
app.UseAuthorization();
app.UseMiddleware<ErrorHandlerMiddleware>();
app.MapControllers();
app.UseStaticFiles();
app.Run();
