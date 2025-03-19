
using _2_paskaita_web_API.Services;

namespace _2_paskaita_web_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Registruojame su interface - teisinga
            var isDev = builder.Environment.IsDevelopment();
            if (isDev)
            {
                builder.Services.AddScoped<IConsoleLogger, DevConsoleLogger>();
            }
            else
            {
                builder.Services.AddScoped<IConsoleLogger, ProdConsoleLogger>();
            }
            // Registruojama be interface - neteisinga, bus negalima testuot
            builder.Services.AddScoped<IEmailNotificationService, EmailNotificationService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<ISqlRepository, SqlRepository>();


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
