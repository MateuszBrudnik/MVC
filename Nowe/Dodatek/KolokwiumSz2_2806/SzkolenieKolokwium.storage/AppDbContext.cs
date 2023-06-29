using Microsoft.EntityFrameworkCore;
using storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieKolokwium.storage
{
    public class AppDbContext: DbContext
    {
        public DbSet<User> Users {get; set;}
        public DbSet<Konkurs> Konkurs { get; set;}
        public AppDbContext(DbContextOptions options): base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("KolokwiumSzk2");
            }
        }
    }
}
