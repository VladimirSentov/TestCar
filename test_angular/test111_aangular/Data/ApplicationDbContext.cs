using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test111_aangular.Models;

namespace test111_aangular.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }


        public DbSet<Car> cars { get; set; }

        public DbSet<Car> bikes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Car>(x =>
           {
               x.Property(y => y.Name).HasColumnType("nvarchar");
               x.Property(y => y.Name).IsRequired().HasMaxLength(100);
           });

            builder.Entity<Bike>(x =>
            {
                x.Property(y => y.Name).HasColumnType("nvarchar");
                x.Property(y => y.Name).IsRequired().HasMaxLength(100);
                x.Property(y => y.Color).HasColumnType("nvarchar");
                x.Property(y => y.Model).HasColumnType("nvarchar");
            });
            base.OnModelCreating(builder);
        }



    }
}
