using BizRuleEngine.Interfaces;
using BizRuleEngine.ProductLine;
using System;
using System.Collections.Generic;

namespace BizRuleEngine.Factory
{

    public class ProductFactory
    {
        private  Dictionary<Products, IProductLine> products =
      new Dictionary<Products, IProductLine>();

        public ProductFactory()
        {
            if (products.Count == 0)
                products.Add(Products.physical, new PhysicalProduct());
        }

        public IProductLine GetProductObject(Products Key)
        {
                return products[Key];           
        }

    }
}
