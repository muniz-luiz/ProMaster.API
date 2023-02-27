using Microsoft.EntityFrameworkCore;
using ProMaster.API.Models;

namespace ProMaster.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }

        

    }
}
