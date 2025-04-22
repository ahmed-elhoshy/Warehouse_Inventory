using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities
{
    public class WarehouseTransfer
    {
        public int Id { get; set; }
        public int FromWarehouseId { get; set; }
        public int ToWarehouseId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int SupplierId { get; set; }
        public DateTime TransferDate { get; set; }
    }

}
