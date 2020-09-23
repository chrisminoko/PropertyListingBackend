using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Property48.Core.Entities;
using Property48.Core.Entities.Auth;
using Property48.Data.Configurations;
using System;


namespace Property48.Data.DbConnection
{
    public class Property48DB : IdentityDbContext<User,Role, Guid>
    {
        public DbSet<Core.Entities.Property> Properties { get; set; }
        public DbSet<Area>Areas { get; set; }
        public DbSet<City> Cities { get; set; }

        public Property48DB(DbContextOptions<Property48DB> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new PropertyConfiguration ());
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new AreaConfiguration());
        }

    }
}
