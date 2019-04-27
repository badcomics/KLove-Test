using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KLoveTest.Models;

namespace KLoveTest.Models
{
    public class KLoveTestContext : DbContext
    {
        public KLoveTestContext (DbContextOptions<KLoveTestContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set up relationship
            modelBuilder.Entity<Employees>()
                .HasOne<Departments>(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentID);
        }

        public DbSet<KLoveTest.Models.Departments> Departments { get; set; }

        public DbSet<KLoveTest.Models.Employees> Employees { get; set; }
    }
}
