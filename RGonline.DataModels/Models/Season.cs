using System;
using System.Collections.Generic;

namespace RGOnline.DataModels.Models
{
    public partial class Season
    {
        public Season()
        {
            Product = new HashSet<Product>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
