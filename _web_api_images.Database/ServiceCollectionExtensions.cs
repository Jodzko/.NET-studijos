using _web_api_images.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_images.BusinessLogic
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<IThumbnailRepository, ThumbnailRepository>();
            services.AddDbContext<ImageDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
