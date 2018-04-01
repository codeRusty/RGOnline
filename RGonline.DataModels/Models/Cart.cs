using System;
using System.Collections.Generic;

namespace RGOnline.DataModels.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartItem = new HashSet<CartItem>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public long CustomerId { get; set; }

        public Customer Customer { get; set; }
        public ICollection<CartItem> CartItem { get; set; }
    }
}
