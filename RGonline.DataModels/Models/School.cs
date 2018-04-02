using System;
using System.Collections.Generic;

namespace RGOnline.DataModels.Models
{
    public partial class School
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? AddressId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public Address Address { get; set; }
    }
}
