using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using RGonline.DataModels;

namespace RGonline.DataAccess
{
    public class RGOnlineContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=IGNP-LPWDEV0004\SQLEXPRESS;Database=WebApiDb;User Id=sa;Password=$ourabh@1;Trusted_Connection=True;");
        }
    }
}
