﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BizRuleEngine.Interfaces
{
    public interface IProductLine
    {
         void InitiateCheckOut(Dictionary<ServiceKey, IService> services);
    }
}
