using System;
using System.Collections.Generic;

namespace RGOnline.DataModels.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Cart = new HashSet<Cart>();
            Order = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public long AddressId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        public Address Address { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
