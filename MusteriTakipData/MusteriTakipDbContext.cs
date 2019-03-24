using Microsoft.EntityFrameworkCore;
using Pandap.Logic.Model.MusteriTakip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandap.Logic.MusteriTakipData
{
    public class MusteriTakipDbContext:DbContext
    {
        public DbSet<Gorusme> Gorusmeler { get; set; }
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var yol = "server=localhost,1501;database=pandap;user id=sa; password=0000";
          
            optionsBuilder.UseSqlServer(yol);
            optionsBuilder.EnableDetailedErrors(true);

            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MusteriTakip");

            modelBuilder.Entity<Gorusme>().ToTable(nameof(Gorusme));


            base.OnModelCreating(modelBuilder);
        }

    }
}
