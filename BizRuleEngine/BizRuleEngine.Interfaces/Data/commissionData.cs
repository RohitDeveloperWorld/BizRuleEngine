using System;
using System.Collections.Generic;
using System.Text;

namespace BizRuleEngine.Interfaces
{
    public class CommissionData : BaseModel
    {
        public double Commission { get; set; }
        public Guid SlipNumber
        {
            get; set;
        }

    
    }
}
