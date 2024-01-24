using MediConnect.Data.MediConnectDbContext;
using Microsoft.EntityFrameworkCore;

namespace MediConnect.Api.Extension
{
    public static class DbRegistryExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            //Register your DbContext with the DI container
            services.AddDbContext<MediConnectDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("conn"));
            });
        }
    }
}
