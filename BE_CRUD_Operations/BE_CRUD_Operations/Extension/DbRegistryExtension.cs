using BE_CRUD_Operations.Data.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace BE_CRUD_Operations.Extension
{
    public static class DbRegistryExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CRUD_DbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("conn"));
            });
        }
    }
}
