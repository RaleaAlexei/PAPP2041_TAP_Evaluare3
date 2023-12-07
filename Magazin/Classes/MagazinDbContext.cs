using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Magazin.Classes
{
    public class MagazinDbContext : DbContext
    {
        public DbSet<Produs> Produse { get; set; } = null!;
        public MagazinDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=LocalMagazinDatabase.db");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produs>().HasKey(p => p.Id);
            base.OnModelCreating(modelBuilder);
        }
        public void CreateProdusTable()
        {
            Database.ExecuteSqlRaw(@"
            CREATE TABLE IF NOT EXISTS Produse (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Denumire TEXT NOT NULL,
                DataProducției TEXT NOT NULL,
                TermenValabilitate TEXT NOT NULL,
                Pret DECIMAL NOT NULL
            )
        ");
        }
    }
}
