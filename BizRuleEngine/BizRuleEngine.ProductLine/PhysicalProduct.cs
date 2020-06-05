using BizRuleEngine.Interfaces;
using System;
using System.Collections.Generic;

namespace BizRuleEngine.ProductLine
{
    public class PhysicalProduct : IProductLine
    {    
        public double _price { get; set; }
        public void InitiateCheckOut(Dictionary<ServiceKey, IService> services)
        {
            throw new NotImplementedException();
        }
    }
}
