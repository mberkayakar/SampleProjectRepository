using AkarEntities.Entities;
using Microsoft.EntityFrameworkCore;

namespace AkarDataAccess.Concrete.DataAccess
{
    public class MyDbContext  : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        #region DbSet
        DbSet<User> Users { get; set; }
        
        #endregion

    }
}
