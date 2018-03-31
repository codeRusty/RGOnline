﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RGOnline.DataModels
{
    public class M_SupplierCategory
    {
        [System.ComponentModel.DataAnnotations.Key]
        public long Id { get; set; }
        public string SupplierCategory { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}