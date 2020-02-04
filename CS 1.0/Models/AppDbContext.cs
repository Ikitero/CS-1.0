using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_1._0.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<RecordType> RecordTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecordType>().HasData(new RecordType { RecordTypeId = 1, RecordTypeName = "Slider" });
            modelBuilder.Entity<RecordType>().HasData(new RecordType { RecordTypeId = 2, RecordTypeName = "Header and text" });
            modelBuilder.Entity<RecordType>().HasData(new RecordType { RecordTypeId = 3, RecordTypeName = "Text and image on the left" });
            modelBuilder.Entity<RecordType>().HasData(new RecordType { RecordTypeId = 4, RecordTypeName = "Text and image on the right" });
        }
    }
}
