using RSM.Entidades;
using System.Data.Entity;

namespace RSM
{
    public class DataContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DataContext():base("name=miConexion")
        {
        }
    }
}
