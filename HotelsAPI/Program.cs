using HotelsAPI.Interfaces;
using HotelsAPI.Models;
using HotelsAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace HotelsAPI
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
            builder.Services.AddDbContext<HotelContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Conn"));
            });
            builder.Services.AddScoped<IBasic<Hotel,int>, HotelRepo >();
            builder.Services.AddScoped<IBasic<Room, int>, RoomRepo>();
            builder.Services.AddScoped<IHotel, HotelServices>();
           

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}