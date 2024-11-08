using Entity;
using Entity.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Configuration;
namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["GestionTareasConn"].ConnectionString);
            }
        }
    }
}
