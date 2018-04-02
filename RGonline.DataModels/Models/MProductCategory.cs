using System;
using System.Collections.Generic;

namespace RGOnline.DataModels.Models
{
    public partial class MProductCategory
    {
        public MProductCategory()
        {
            MProductSubCategory = new HashSet<MProductSubCategory>();
        }

        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string ProductCategory { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public ICollection<MProductSubCategory> MProductSubCategory { get; set; }
    }
}
