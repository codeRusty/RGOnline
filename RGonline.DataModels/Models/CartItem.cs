using System;
using System.Collections.Generic;

namespace RGOnline.DataModels.Models
{
    public partial class CartItem
    {
        public long Id { get; set; }
        public long CartId { get; set; }
        public long ProductId { get; set; }

        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }
}
