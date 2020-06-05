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
        public void CheckBizRuleEngineRequestHandler()
        {
            

            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            PackagingSlip packagingSlip = 
                new PackagingSlip();
            packagingSlip.Price = 100;
            packagingSlip.SlipNumber = Guid.NewGuid();
            services.Add(ServiceKey.packingslip, packagingSlip);

            bizRuleEngineRequestHandler.Handle(Products.physical, services);
        }


    }
}
