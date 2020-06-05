using System;
using System.Collections.Generic;
using System.Text;

namespace BizRuleEngine.Interfaces
{
    public class MembershipServiceData : BaseModel
    {
        public double Price { get; set; }
        public Guid SlipNumber
        {
            get; set;
        }
        public bool isNewUser { get; set; }
    }
}
