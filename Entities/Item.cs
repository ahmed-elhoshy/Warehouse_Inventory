using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; } // e.g., kg, pieces
        public ICollection<SupplyOrder> SupplyOrders { get; set; }
    }

}
