using System;
using System.Collections.Generic;

namespace RGOnline.DataModels.Models
{
    public partial class Product
    {
        public Product()
        {
            CartItem = new HashSet<CartItem>();
            OrderItem = new HashSet<OrderItem>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Sku { get; set; }
        public decimal SalesFee { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
        public long SchoolId { get; set; }
        public long SizeId { get; set; }
        public long SeasonId { get; set; }

        public School School { get; set; }
        public Season Season { get; set; }
        public Size Size { get; set; }
        public ICollection<CartItem> CartItem { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
