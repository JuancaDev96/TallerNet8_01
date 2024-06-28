using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace TallerNet8.Contexto
{
    public class TallerNet8DBContext(DbContextOptions<TallerNet8DBContext> options) : DbContext(options) 
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
