using BizRuleEngine.Interfaces;
using BizRuleEngine.ProductLine;
using System;
using System.Collections.Generic;

namespace BizRuleEngine.Factory
{

    public class ProductFactory
    {
        public IProductLine GetProductObject()
        {
            return new Product();
        }

    }
}
