﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Proje.Domain.Abstractions;
using Proje.Domain.AppEntities;
using Proje.Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistance.Context
{
    public sealed class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Company>().HasQueryFilter(b => !b.DeletedDate.HasValue);
            builder.Entity<UserAndCompanyRelationship>().HasQueryFilter(b => !b.DeletedDate.HasValue);
            base.OnModelCreating(builder);
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<UserAndCompanyRelationship> UserAndCompanyRelationships { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<Entity>();
            foreach (var entry in entries) {

                switch (entry.State)
                {
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        entry.Property(p => p.DeletedDate)
                            .CurrentValue = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Property(p => p.UpdatedDate)
                            .CurrentValue = DateTime.Now;
                        break;
                    case EntityState.Added:                      
                        entry.Property(p => p.CreatedDate)
                            .CurrentValue = DateTime.Now;
                        break;
                    default:
                        break;
                } 
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
        {
            public AppDbContext CreateDbContext(string[] args)
            {
                
                var builder = new ConfigurationBuilder();
                builder.AddJsonFile("appsettings.json");
                var configuration = builder.Build();

                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                var connectionString = configuration.GetConnectionString("SqlServer");
                optionsBuilder.UseSqlServer(connectionString);
 
                return new AppDbContext(optionsBuilder.Options);
                
               /* var optionsBuilder = new DbContextOptionsBuilder();
                var connecetionStrings = "Data Source=.;Initial Catalog=ProjeMasterDB;User ID=sa;Password=159357Et!1;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                optionsBuilder.UseSqlServer(connecetionStrings);
                return new AppDbContext(optionsBuilder.Options);*/
            }
        }
    }
}
