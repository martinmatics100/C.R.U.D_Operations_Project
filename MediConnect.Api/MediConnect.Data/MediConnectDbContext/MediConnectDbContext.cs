using MediConnect.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediConnect.Data.MediConnectDbContext
{
    public class MediConnectDbContext : DbContext
    {
        public MediConnectDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Medicines> Medicines { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Specify data types for decimal properties
            modelBuilder.Entity<Cart>().Property(c => c.Discount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Cart>().Property(c => c.TotalPrice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Cart>().Property(c => c.UnitPrice).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Medicines>().Property(m => m.Discount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Medicines>().Property(m => m.UnitPrice).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<OrderItems>().Property(o => o.Discount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<OrderItems>().Property(o => o.TotalPrice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<OrderItems>().Property(o => o.UnitPrice).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Orders>().Property(o => o.OrderTotal).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<User>().Property(u => u.Amount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<User>().Property(u => u.Fund).HasColumnType("decimal(18,2)");

            // Add other configurations or constraints as needed

            base.OnModelCreating(modelBuilder);
        }
    }
}
