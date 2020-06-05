using BizRuleEngine.Interfaces;
using BizRuleEngine.Services;
using System;
using System.Collections.Generic;

namespace BizRuleEngine.Factory
{
    public class ServiceFactory
    {
        private static Dictionary<ServiceKey, IService> Services =
     new Dictionary<ServiceKey, IService>();

        static ServiceFactory()
        {
            if (Services.Count == 0)
            {
                Services.Add(ServiceKey.shippingpackingslip, new ShippingPackagingSlip());
                Services.Add(ServiceKey.royaltypackagingslip, new RoyaltyPackagingSlip());
                Services.Add(ServiceKey.membership, new MembershipService());
                Services.Add(ServiceKey.email, new EmailService());
                Services.Add(ServiceKey.video, new VideoService());
                Services.Add(ServiceKey.commission, new CommissionService());
            }
        }

        public static IService GetServiceObject(ServiceKey Key)
        {
            return Services[Key];
        }
    }
}
