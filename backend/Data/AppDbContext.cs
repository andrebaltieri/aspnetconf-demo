using Microsoft.Data.Entity;
using aspnetcast.Models;

namespace aspnetcast.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Agenda> Agendas{ get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryStore();
        }
    }
}