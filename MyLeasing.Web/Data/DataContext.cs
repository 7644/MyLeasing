
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Data.Entities;
using System.Threading.Tasks;


namespace MyLeasing.Web.Data
{
    //Hereda de la clase Dbcontext
    public class DataContext : IdentityDbContext<User>
    {
        // se crea el contructor de la clase y la conexion a la base de datos
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

     
       
        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Lessee> Lessees { get; set; }

        public DbSet<Manager> Managers { get; set; }

       

        //tomara el modelo owner y lo va a convertir en una tabla con nombre Owners
        public DbSet<Owner> Owners { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<PropertyImage> PropertyImages { get; set; }

        public DbSet<PropertyType> PropertyTypes { get; set; }


    }
}
