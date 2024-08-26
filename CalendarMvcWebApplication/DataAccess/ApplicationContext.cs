using CalendarMvcWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CalendarMvcWebApplication.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=eventsdb;Username=postgres;Password=kwfy3cx8W");
        }
    }
}
