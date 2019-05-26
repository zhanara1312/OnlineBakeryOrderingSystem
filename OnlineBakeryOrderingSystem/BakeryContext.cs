using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBakeryOrderingSystem
{
    public class BakeryContext : DbContext
    {
        public DbSet<Bakery> Bakeries { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:bakeryuijendbserver.database.windows.net,1433;Initial Catalog=BakeryUIJen_db;Persist Security Info=False;User ID=Jen;Password=Password!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating
            (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bakery>(entity =>
            {
                entity
                    .HasKey(e => e.CustomerNumber)
                    .HasName("PK_Bakeries");

                entity.Property(e => e.CustomerNumber)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerEmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BakeryProduct)
                    .IsRequired();
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_Transactions");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NumberOfOrder)
                    .IsRequired();

                entity.HasOne(e => e.Bakery)
                    .WithMany()
                    .HasForeignKey(e => e.CustomerNumber);

            });
        }

    }
}
