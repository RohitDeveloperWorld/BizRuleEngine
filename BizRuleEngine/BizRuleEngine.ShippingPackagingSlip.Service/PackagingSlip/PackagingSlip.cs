using BizRuleEngine.Interfaces;
using System;

namespace BizRuleEngine.Services
{
    public class PackagingSlip : IService
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
