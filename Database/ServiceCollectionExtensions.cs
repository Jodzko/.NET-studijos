using _web_api_project.Database.Persistence;
using _web_api_project.Database.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.Database
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddDbContext<AppDbContext>(options => 
            options.UseSqlServer(connectionString,
                sqlOptions => sqlOptions.MigrationsAssembly("_web_api_project.Database")
                ));
            return services;
        }
    }
}
