using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WinFormsApp1.Entities;

namespace WinFormsApp1.DataContext
{

    public class WarehouseDbContext : DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SupplyOrder> SupplyOrders { get; set; }
        public DbSet<DisbursementOrder> DisbursementOrders { get; set; }
        public DbSet<WarehouseTransfer> WarehouseTransfers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-9IE8V4JF;Initial Catalog=WarehouseDB;Integrated Security=True;TrustServerCertificate=True;");
        }
    }

}
