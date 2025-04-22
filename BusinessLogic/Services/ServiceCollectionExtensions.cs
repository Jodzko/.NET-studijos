using _web_api_project.BusinessLogic.Services.Interfaces;
using _web_api_project.Database.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.BusinessLogic.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<INotesService, NotesService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
