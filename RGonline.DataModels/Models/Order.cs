using System;
using System.Collections.Generic;

namespace RGOnline.DataModels.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public long Id { get; set; }
        public long? Reference { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public decimal Amount { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalAmount { get; set; }
        public long ShippingAddress { get; set; }
        public long CustomerId { get; set; }

        public Customer Customer { get; set; }
        public Address ShippingAddressNavigation { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
