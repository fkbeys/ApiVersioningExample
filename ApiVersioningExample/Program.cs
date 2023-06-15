
namespace ApiVersioningExample
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
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "api v1", Version = "1.0" });
                c.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "api v2", Version = "2.0" });
            });
            builder.Services.ApiVersioningExtention();



            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json","v1");
                    c.SwaggerEndpoint("/swagger/v2/swagger.json","v2");
                });

            }

            app.UseAuthorization();
            app.UseApiVersioning();



            app.MapControllers();

            app.Run();
        }
    }
}