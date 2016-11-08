using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace QuickUp.HomeTaks.Day2.Models
{
    public class UniverContext : DbContext
    {
        public UniverContext(DbContextOptions<UniverContext> options) : base(options)
        {
        }
        public DbSet<Group> Groups { get; set; }
       
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().ToTable("Group");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}