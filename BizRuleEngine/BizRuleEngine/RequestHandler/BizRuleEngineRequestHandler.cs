using BizRuleEngine.Factory;
using BizRuleEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BizRuleEngine.RequestHandler
{
    public class BizRuleEngineRequestHandler
    {
        private ProductFactory _projectFactory { get; set; }
        public BizRuleEngineRequestHandler
            (ProductFactory productFactory)
        {
            _projectFactory = productFactory;
        }

       

        public void Handle(Products key,
            Dictionary<ServiceKey,IService> services)
        {
            IProductLine ProductLine =
               _projectFactory.GetProductObject(key);
            ProductLine.InitiateCheckOut(services);
        }
    }
}
