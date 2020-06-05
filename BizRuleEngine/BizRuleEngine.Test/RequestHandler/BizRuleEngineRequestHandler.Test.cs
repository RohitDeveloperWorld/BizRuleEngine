using BizRuleEngine.Factory;
using BizRuleEngine.Interfaces;
using BizRuleEngine.RequestHandler;
using BizRuleEngine.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BizRuleEngine.Test
{
    [TestClass]
    public class BizRuleEngineRequestHandlerTest
    {
        private BizRuleEngineRequestHandler bizRuleEngineRequestHandler
    = new BizRuleEngineRequestHandler(new ProductFactory());

        [TestMethod]
        public void CheckBizRuleEngineForPhysicalProduct()
        { 
            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            ShippingPackagingSlip packagingSlip = 
                new ShippingPackagingSlip();
            packagingSlip.Price = 100;
            packagingSlip.SlipNumber = Guid.NewGuid();
            services.Add(ServiceKey.shippingpackingslip, packagingSlip);

            bizRuleEngineRequestHandler.Handle( services);
        }
        [TestMethod]
        public void CheckBizRuleEngineForBook()
        {
            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            RoyaltyPackagingSlip packagingSlip =
                new RoyaltyPackagingSlip();
            packagingSlip.Price = 100;
            packagingSlip.SlipNumber = Guid.NewGuid();
            services.Add(ServiceKey.royaltypackagingslip, packagingSlip);

            bizRuleEngineRequestHandler.Handle( services);
        }

    }
}
