using BizRuleEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BizRuleEngine.Services
{
   public class MembershipService : IService
    {
        public double Price { get; set; }
        public Guid SlipNumber
        {
            get; set;
        }
        public bool isNewUser { get; set; }
        public void Process()
        {
            // TODO: Implementation.
        }
    }

}
