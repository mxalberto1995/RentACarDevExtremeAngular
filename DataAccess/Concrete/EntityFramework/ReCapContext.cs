﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Scaffold - DbContext "server=DESKTOP-51P73VP; database=OG.RecapProjectDb; integrated security=true;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models
            optionsBuilder.UseSqlServer(@"server=DESKTOP-C5R88RR; database=OG.RecapProjectDb; integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}