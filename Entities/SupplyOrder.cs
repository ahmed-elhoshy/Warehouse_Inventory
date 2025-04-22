using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities
{
  
        public class SupplyOrder
        {
            public int Id { get; set; }
            public int WarehouseId { get; set; }
            public Warehouse Warehouse { get; set; }
            public int ItemId { get; set; }
            public Item Item { get; set; }
            public int SupplierId { get; set; }
            public Supplier Supplier { get; set; }
            public int Quantity { get; set; }
            public DateTime ProductionDate { get; set; }
            public DateTime ExpiryDate { get; set; }
            public DateTime OrderDate { get; set; } // Add this property
        }


    }
