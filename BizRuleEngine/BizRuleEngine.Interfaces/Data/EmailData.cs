using System;
using System.Collections.Generic;
using System.Text;

namespace BizRuleEngine.Interfaces
{
    public class EmailData : BaseModel
    {
        public string sender { get; set; }
        public string message { get; set; }
        public string Receiver { get; set; }      
    }

}
