using System;
using System.Collections.Generic;
using System.Text;

namespace BizRuleEngine.Interfaces
{
    public class VideoPackagingData : BaseModel
    {
        public double Price { get; set; }
        public Guid SlipNumber
        {
            get; set;
        }

        public string FreeVideoURL { get; set; }
    }
}
