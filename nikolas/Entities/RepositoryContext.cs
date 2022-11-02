using Microsoft.EntityFrameworkCore;
using nikolas.Entities.Models;

namespace aplikacija_server.Entities
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Vehicle>? Vehicles { get; set; }
        public DbSet<Vehicle_Type>? Vehicle_Types { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Material>? Materials { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Order_Status>? Order_Status { get; set; }
        public DbSet<Order_Material>? Order_Materials { get; set; }
        public DbSet<Client>? Clients { get; set; }
        public DbSet<Offer>? Offers { get; set; }
        public DbSet<Material_Offer>? Material_Offers { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Offer_Status>? Offer_Statuses { get; set; }

        public DbSet<Service_Offer>? Service_Offers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Order_Material>()
       .HasKey(bc => new { bc.OrderId, bc.MaterialId });
            modelBuilder.Entity<Order_Material>()
                .HasOne(bc => bc.Order)
                .WithMany(b => b.Order_Materials)
                .HasForeignKey(bc => bc.OrderId);
            modelBuilder.Entity<Order_Material>()
                .HasOne(bc => bc.Material)
                .WithMany(c => c.Order_Materials)
                .HasForeignKey(bc => bc.MaterialId);



            modelBuilder.Entity<Material_Offer>()
       .HasKey(bc => new { bc.MaterialID, bc.OfferID });
            modelBuilder.Entity<Material_Offer>()
                .HasOne(bc => bc.Material)
                .WithMany(b => b.Material_Offers)
                .HasForeignKey(bc => bc.MaterialID);
            modelBuilder.Entity<Material_Offer>()
                .HasOne(bc => bc.Offer)
                .WithMany(c => c.Material_Offers)
                .HasForeignKey(bc => bc.OfferID);



            modelBuilder.Entity<Service_Offer>()
      .HasKey(bc => new { bc.ServiceId, bc.OfferID });
            modelBuilder.Entity<Service_Offer>()
                .HasOne(bc => bc.Service)
                .WithMany(b => b.Service_Offer)
                .HasForeignKey(bc => bc.ServiceId);
            modelBuilder.Entity<Service_Offer>()
                .HasOne(bc => bc.Offer)
                .WithMany(c => c.Service_Offers)
                .HasForeignKey(bc => bc.OfferID);




        }


    }
}
    

