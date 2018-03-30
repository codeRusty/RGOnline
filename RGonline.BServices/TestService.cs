using System;
using System.Linq;
using System.Collections.Generic;
using RGonline.DataAccess;
using RGonline.DataModels;
using RGonline.DTOs;

namespace RGonline.BServices
{
    public class TestService
    {

        public List<ProductDTO> TestMethod()
        {
            List<ProductDTO> allProducts = new List<ProductDTO>();
            //using (var db = new RGOnlineContext())
            //{

            //    var products = db.Products.ToList();

            //    foreach (var p in products)
            //    {
            //        ProductDTO productDTO = new ProductDTO();
            //        productDTO.ProductId = p.ProductId;
            //        productDTO.ProductName = p.ProductName;
            //        allProducts.Add(productDTO);
            //    }
            //    return allProducts;
            //}

            allProducts.Add(new ProductDTO { ProductId = 1, ProductName = "123" });
            return allProducts;
        }

    }
}
