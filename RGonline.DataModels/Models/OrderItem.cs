using System;
using System.Collections.Generic;

namespace RGOnline.DataModels.Models
{
    public partial class OrderItem
    {
        public long Id { get; set; }
        public decimal SalesFee { get; set; }
        public int Quantity { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long? ProductId { get; set; }
        public long? OrderId { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
