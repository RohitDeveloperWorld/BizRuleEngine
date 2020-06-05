using BizRuleEngine.Interfaces;
using System;

namespace BizRuleEngine.Services
{
    public class ShippingPackagingSlip : IService
    {
        public double Price { get; set; }
        public Guid SlipNumber
        {
            get; set;
        }
        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
