﻿using CollectionAdmin_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAdmin_Data.Controllers
{
    public class ProductController : IProduct
    {
        private readonly CollectionAdminContext db = new CollectionAdminContext();
        public bool Create(ProductDTO company)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ProductDTO company)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> Read(int? id = null)
        {
            List<ProductDTO> products = db.Products.ToList();
            return products;
        }

        public bool Update(ProductDTO company)
        {
            throw new NotImplementedException();
        }
    }
}
