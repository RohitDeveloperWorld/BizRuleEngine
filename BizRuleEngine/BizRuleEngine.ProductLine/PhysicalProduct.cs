using BizRuleEngine.Interfaces;
using System;

namespace BizRuleEngine.ProductLine
{
    public class PhysicalProduct : IProductLine
    {    
        private double _price { get; set; }
        public void InitiateCheckOut()
        {
            throw new NotImplementedException();
        }
    }
}
