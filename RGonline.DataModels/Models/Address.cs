using System;
using System.Collections.Generic;

namespace RGOnline.DataModels.Models
{
    public partial class Address
    {
        public Address()
        {
            Customer = new HashSet<Customer>();
            Order = new HashSet<Order>();
            School = new HashSet<School>();
        }

        public long Id { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public long Pincode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<Customer> Customer { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<School> School { get; set; }
    }
}
