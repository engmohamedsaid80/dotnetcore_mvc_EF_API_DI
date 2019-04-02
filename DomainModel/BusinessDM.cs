using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class BusinessDM : DbContext
    {
        public BusinessDM(DbContextOptions<BusinessDM> options)
            : base(options)
        {
            
        }

        public virtual DbSet<BusService> BusServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusService>()
                .Property(b => b.ServiceName)
                .IsRequired();
        }
    }
}
