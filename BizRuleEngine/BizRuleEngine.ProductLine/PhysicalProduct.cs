using BizRuleEngine.Factory;
using BizRuleEngine.Interfaces;
using System;
using System.Collections.Generic;

namespace BizRuleEngine.ProductLine
{
    public class Product : IProductLine
    {    
        public void InitiateCheckOut
            (Dictionary<ServiceKey, IService> services)
        {
            foreach(var _service in services)
            {
                IService service =
                    ServiceFactory.GetServiceObject(_service.Key);
                service.Process();

            }
           
        }
    }
}
