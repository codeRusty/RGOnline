using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using RGOnline.DataModels;

namespace RGOnline.DataAccess
{
    public class RGOnlineContext : DbContext
    {
        public RGOnlineContext() { }
        public RGOnlineContext(DbContextOptions<RGOnlineContext> options)
            : base(options)
        { }

        public DbSet<Products> Products { get; set; }
        public DbSet<M_ProductCategory> M_ProductCategory { get; set; }
        public DbSet<M_ProductSubCategory> M_ProductSubCategory { get; set; }
        public DbSet<M_SupplierCategory> M_SupplierCategory { get; set; }
        public DbSet<M_CurrencyDominance> M_CurrencyDominance { get; set; }
        public DbSet<M_PriceDecisonFactor> M_PriceDecisonFactor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-FIUUHBV\SQLEXPRESS;Database=WebApiDb;User Id=sa;Password=$ourabh@1;Trusted_Connection=True;");
        }
    }
}
