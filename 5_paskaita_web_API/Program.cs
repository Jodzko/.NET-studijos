
using _5_paskaita_web_API.Persistence;
using _5_paskaita_web_API.Services;
using _5_paskaita_web_API.Services.Interfaces;
using _5_paskaita_web_API.Settings;
using Microsoft.EntityFrameworkCore;

namespace _5_paskaita_web_API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://api.weatherstack.com/currentaccess_key=d4ed4e17e3fc693257d083de31333d27&query=New York")
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.Configure<WeatherSettings>(builder.Configuration.GetSection("WeatherSettings"));
            builder.Services.AddScoped<IWeatherService, WeatherService>();
            builder.Services.AddDbContext<WeatherDbContext>(options => options.UseSqlServer(connectionString));
            //builder.Services.AddTransient<IWeatherDatabase, WeatherDatabase>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
