﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RGOnline.DataModels
{
    public class M_ProductSubCategory
    {
        public M_ProductSubCategory() { }
        [Key]
        public long Id { get; set; }
        public string ProductSubCategory { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public M_ProductCategory M_ProductCategory { get; set; }
    }
}