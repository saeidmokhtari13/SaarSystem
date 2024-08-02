using Microsoft.EntityFrameworkCore;
using SaarSystem.Finance.Models;
using SaarSystem.Procurement.Models;
using SaarSystem.Warehouse.Models;
using SaarSystem.Production.Models;
using SaarSystem.Maintenance.Models;
using SaarSystem.Sales.Models;
using SaarSystem.General.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SaarSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSets for each module with specific schemas
        public DbSet<User> Users { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<ProductionOrder> ProductionOrders { get; set; }
        public DbSet<MaintenanceTask> MaintenanceTasks { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure schemas
            modelBuilder.Entity<User>().ToTable("Users", "GNR");
            modelBuilder.Entity<Invoice>().ToTable("Invoices", "FIN");
            modelBuilder.Entity<PurchaseOrder>().ToTable("PurchaseOrders", "PRC");
            modelBuilder.Entity<InventoryItem>().ToTable("InventoryItems", "LGS");
            modelBuilder.Entity<ProductionOrder>().ToTable("ProductionOrders", "PRD");
            modelBuilder.Entity<MaintenanceTask>().ToTable("MaintenanceTasks", "CMS");
            modelBuilder.Entity<SalesOrder>().ToTable("SalesOrders", "SLS");
        }
    }
}