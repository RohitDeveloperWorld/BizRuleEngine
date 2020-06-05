using BizRuleEngine.Interfaces;
using BizRuleEngine.Services;
using System;
using System.Collections.Generic;

namespace BizRuleEngine.ServiceFactory
{
    public class ServiceFactory
    {
        private static Dictionary<ServiceKey, IService> Services =
     new Dictionary<ServiceKey, IService>();

        public ServiceFactory()
        {
            if (Services.Count == 0)
                Services.Add(ServiceKey.packingslip, new PackagingSlip());
        }

        public static IService GetProductObject(ServiceKey Key)
        {
            return Services[Key];
        }
    }
}
