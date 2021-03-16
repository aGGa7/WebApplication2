using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication2.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options) { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ObjectOfProject> Objects { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ObjectOfProject>().HasOne(e => e.Project).WithMany(e => e.Objects).OnDelete(DeleteBehavior.ClientSetNull);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                var ConnectionString = @"Server = (localdb)\\MSSQLLocalDB; Database=TestApp; Trusted_Connection = True; MultipleActiveResultSets=true"; //если строка подключении при конфигурации не была определена, можно переопределить здесь
                optionsBuilder.UseSqlServer(ConnectionString, options => options.EnableRetryOnFailure());
            }
                   
        }
    }
}
