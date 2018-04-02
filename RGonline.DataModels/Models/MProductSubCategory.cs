using System;
using System.Collections.Generic;

namespace RGOnline.DataModels.Models
{
    public partial class MProductSubCategory
    {
        public MProductSubCategory()
        {
            Product = new HashSet<Product>();
        }

        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string ProductSubCategory { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long ProductCategoryId { get; set; }

        public MProductCategory ProductCategory { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
