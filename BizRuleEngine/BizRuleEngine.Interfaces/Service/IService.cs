using System;
using System.Collections.Generic;
using System.Text;

namespace BizRuleEngine.Interfaces
{
    public interface IService
    {
        BaseModel data { get; set; }
        void Process();
    }
}
