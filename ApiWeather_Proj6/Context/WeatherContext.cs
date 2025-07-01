using ApiWeather_Project6.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiWeather_Project6.Context
{
    public class WeatherContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YourServerName;initial Catalog=Db6Project20; integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<City> Cities { get; set; }
    }
}
