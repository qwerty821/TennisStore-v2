
using OnlineStore.Abstractions;
using OnlineStore.Models.DbModels;
using OnlineStore.Repositories;
using OnlineStore.Services;
using TennisStoreApi.Abstractions;
using TennisStoreApi.Models.DbModels;

namespace TennisStoreApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });

            builder.Services.AddControllers();

            builder.Services.AddDbContext<OnlineStoreContext>();

            builder.Services.AddScoped<IRacketRepository, RacketRepository>();
            builder.Services.AddScoped<RacketService>();


            if (!builder.Environment.IsDevelopment())
            {

                builder.Services.AddControllers().ConfigureApiBehaviorOptions(
                    options =>
                    {
                        options.SuppressMapClientErrors = true;
                    });
            }

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors("AllowAllOrigins");

            app.MapControllers();

            app.Run();
        }
    }
}
