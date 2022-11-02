using aplikacija_server.LoggerService;
using nikolas.Contracts;
using nikolas.Repository;
using Server.Contracts;

namespace Server.Extensions
{
    public static class ServiceExtensions
    {
        
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
