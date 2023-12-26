using Trabajo_Santiago_Marcos.Repository;
using Trabajo_Santiago_Marcos.Service;
using Trabajo_Santiago_Marcos.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace Trabajo_Santiago_Marcos
{
    public class program
    {

        public static void Main(string[] args)
        {


            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ReservaRestaurantContext>(
            options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IReservaService, ReservaService>();  

            var app = builder.Build();



            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapControllers();

            app.Run();
        }
    }
}