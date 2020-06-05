using System;
using System.Collections.Generic;
using System.Text;

namespace BizRuleEngine.Interfaces
{
    public class ShippingPackagingSlipData :  BaseModel
    {
        public double Price { get; set; }
        public Guid SlipNumber
        {
            get; set;
        }

    }
}
