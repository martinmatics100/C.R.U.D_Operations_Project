using BE_CRUD_Operations.Core.Implementation;
using BE_CRUD_Operations.Core.Interfaces.IRepository;
using BE_CRUD_Operations.Core.Interfaces.IServices;
using BE_CRUD_Operations.Data.AppDbContext;
using BE_CRUD_Operations.Data.Models;
using BE_CRUD_Operations.Data.Repository;
using BE_CRUD_Operations.MappinFolder;
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

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddScoped<IBaseRepository<Student>, StudentRepository>();
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
