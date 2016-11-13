using Microsoft.AspNetCore.Mvc;
using QuickUp.HomeTaks.Day2.Models;
using QuickUp.HomeTaks.Day4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day4
{
    [Route("api/products")]
    public class ProductController:Controller
    {
        private readonly UniverContext _context;
 

        public ProductController(UniverContext context)
        {
            _context = context;
        }

        [HttpGet("/products")]
        public IEnumerable<ProductModel> ListProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }

        [HttpPost("/products")]
        public ProductModel Create(ProductModel product)
        {
            _context.Products.Add(product);
            return product;
        }
    }
}
