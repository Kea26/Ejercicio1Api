using Microsoft.EntityFrameworkCore;

namespace Pruebas.Contexts
{
    public class ConexionSQL : DbContext
    {
        public ConexionSQL(DbContextOptions<ConexionSQL> options) : base(options)
        {
        }

        //public DbSet<TUser> TUser { get; set; }
    }
}