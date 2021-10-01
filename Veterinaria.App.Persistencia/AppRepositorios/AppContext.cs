using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class AppContext : DbContext{

        public DbSet<Persona> Personas{get; set;}
        public DbSet<Veterinario> Veterinarios{get; set;}
        public DbSet<Administrador> Administradores{get;set;}
        public DbSet<DueñoMascota> Dueños{get;set;}
        public DbSet<Mascota> Mascotas{get;set;} 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = VeterinariaEquipo_6");
            }
        }
        
    }
}