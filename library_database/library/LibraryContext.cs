using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class LibraryContext : DbContext
    {
       /* public DbSet<Reader> Readers { get; set; }
        public DbSet<Book> Books { get; set; }

        public LibraryContext() : base("library.Properties.Settings.LibraryDatabaseConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reader>()
                .HasKey(x => x.IDC);
            modelBuilder.Entity<Reader>()
                .Property(x => x.IDC)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Reader>()
                .HasMany(x => x.Ksiazki).WithOptional(x => x.Wypozyczajacy).HasForeignKey(x => x.IDC_Wypozyczajacego);
            modelBuilder.Entity<Book>()
                .HasKey(x => x.IDK);
            modelBuilder.Entity<Book>()
                .Property(x => x.IDK)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Book>()
                .ToTable("Book");
            modelBuilder.Entity<Reader>()
                .ToTable("Reader");

        }*/
    }
}
