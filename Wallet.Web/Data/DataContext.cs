using Microsoft.EntityFrameworkCore;
using Wallet.Common.Entities;

namespace Wallet.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<DocumentType> DocumentType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>()
             .HasIndex(t => t.Name)
             .IsUnique();

            modelBuilder.Entity<Country>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Department>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<DocumentType>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<AccountType>()
                .HasIndex(t => t.Name)
                .IsUnique();


        }
    }
}
