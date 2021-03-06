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

            ShippingPackagingSlipData shippingPackagingSlipData =
                new ShippingPackagingSlipData();
            shippingPackagingSlipData.Price = 100;
            shippingPackagingSlipData.SlipNumber = Guid.NewGuid();

            packagingSlip.data = shippingPackagingSlipData;

            services.Add(ServiceKey.shippingpackingslip, packagingSlip);

            bizRuleEngineRequestHandler.Handle(services);
        }
        [TestMethod]
        public void CheckBizRuleEngineForBook()
        {
            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            RoyaltyPackagingSlip packagingSlip =
                new RoyaltyPackagingSlip();

            RoyaltyPackagingSlipData royaltyPackagingSlipData =
              new RoyaltyPackagingSlipData();
            royaltyPackagingSlipData.Price = 100;
            royaltyPackagingSlipData.SlipNumber = Guid.NewGuid();

            packagingSlip.data = royaltyPackagingSlipData;
            services.Add(ServiceKey.royaltypackagingslip, packagingSlip);

            bizRuleEngineRequestHandler.Handle(services);
        }

        [TestMethod]
        public void CheckBizRuleEngineForMembership()
        {
            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            MembershipService membershipService =
                new MembershipService();

            MembershipServiceData membershipServiceData
                = new MembershipServiceData();
            membershipServiceData.Price = 100;
            membershipServiceData.SlipNumber = Guid.NewGuid();
            membershipServiceData.isNewUser = true;
            membershipService.data = membershipServiceData;

            services.Add(ServiceKey.membership, membershipService);

            bizRuleEngineRequestHandler.Handle(services);
        }

        [TestMethod]
        public void CheckBizRuleEngineForUpgradeMemberShip()
        {
            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            MembershipService membershipService =
                new MembershipService();

            MembershipServiceData membershipServiceData
                = new MembershipServiceData();
            membershipServiceData.Price = 100;
            membershipServiceData.SlipNumber = Guid.NewGuid();
            membershipServiceData.isNewUser = false;
            membershipService.data = membershipServiceData;

            services.Add(ServiceKey.membership, membershipService);

            bizRuleEngineRequestHandler.Handle(services);
        }

        private EmailData EmailData(string message)
        {
            EmailData emailData
                = new EmailData();
            emailData.sender = "";
            emailData.Receiver = "";
            emailData.message = message;
            return emailData;
        }

        [TestMethod]
        public void CheckBizRuleEngineForUpgradeMemberShipWithEmail()
        {
            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            MembershipService membershipService =
                new MembershipService();

            MembershipServiceData membershipServiceData
                = new MembershipServiceData();
            membershipServiceData.Price = 100;
            membershipServiceData.SlipNumber = Guid.NewGuid();
            membershipServiceData.isNewUser = false;
            membershipService.data = membershipServiceData;

            EmailService emailService = new EmailService();
            emailService.data = EmailData("Renew Membership");
            services.Add(ServiceKey.membership, membershipService);
            services.Add(ServiceKey.email, emailService);
            bizRuleEngineRequestHandler.Handle(services);
        }


        [TestMethod]
        public void CheckBizRuleEngineForUpgradeNewMemberShipWithEmail()
        {
            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            MembershipService membershipService =
                new MembershipService();

            MembershipServiceData membershipServiceData
                = new MembershipServiceData();
            membershipServiceData.Price = 100;
            membershipServiceData.SlipNumber = Guid.NewGuid();
            membershipServiceData.isNewUser = true;
            membershipService.data = membershipServiceData;

            EmailService emailService = new EmailService();
            emailService.data = EmailData("New Membership");
            services.Add(ServiceKey.membership, membershipService);
            services.Add(ServiceKey.email, emailService);

            bizRuleEngineRequestHandler.Handle(services);
        }

        [TestMethod]
        public void CheckBizRuleEngineForVideoService()
        {
            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            VideoService videoService =
                new VideoService();

            VideoPackagingData videoPackagingData
                = new VideoPackagingData();
            videoPackagingData.Price = 100;
            videoPackagingData.SlipNumber = Guid.NewGuid();
            videoPackagingData.FreeVideoURL = "";

            videoService.data = videoPackagingData;
            services.Add(ServiceKey.video, videoService);

            bizRuleEngineRequestHandler.Handle(services);
        }

        [TestMethod]
        public void CheckBizRuleEngineForCommissionService()
        {
            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            CommissionService commissionService =
                new CommissionService();

            CommissionData commissionData
                = new CommissionData();
            commissionData.Commission = 100;
            commissionData.SlipNumber = Guid.NewGuid();


            commissionService.data = commissionData;
            services.Add(ServiceKey.commission, commissionService);

            bizRuleEngineRequestHandler.Handle(services);
        }

        public void CheckBizRuleEngineForPhysicalProductWithCommission()
        {
            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            ShippingPackagingSlip packagingSlip =
                new ShippingPackagingSlip();

            ShippingPackagingSlipData shippingPackagingSlipData =
                new ShippingPackagingSlipData();
            shippingPackagingSlipData.Price = 100;
            shippingPackagingSlipData.SlipNumber = Guid.NewGuid();

            packagingSlip.data = shippingPackagingSlipData;


            CommissionService commissionService =
              new CommissionService();

            CommissionData commissionData
                = new CommissionData();
            commissionData.Commission = 100;
            commissionData.SlipNumber = Guid.NewGuid();


            commissionService.data = commissionData;

            services.Add(ServiceKey.commission, commissionService);

            services.Add(ServiceKey.shippingpackingslip, packagingSlip);

            bizRuleEngineRequestHandler.Handle(services);
        }

        [TestMethod]
        public void CheckBizRuleEngineForBookwithCommission()
        {
            Dictionary<ServiceKey, IService> services =
                new Dictionary<ServiceKey, IService>();
            RoyaltyPackagingSlip packagingSlip =
                new RoyaltyPackagingSlip();

            RoyaltyPackagingSlipData royaltyPackagingSlipData =
              new RoyaltyPackagingSlipData();
            royaltyPackagingSlipData.Price = 100;
            royaltyPackagingSlipData.SlipNumber = Guid.NewGuid();

            packagingSlip.data = royaltyPackagingSlipData;

            CommissionService commissionService =
             new CommissionService();

            CommissionData commissionData
                = new CommissionData();
            commissionData.Commission = 100;
            commissionData.SlipNumber = Guid.NewGuid();


            commissionService.data = commissionData;

            services.Add(ServiceKey.commission, commissionService);

            services.Add(ServiceKey.royaltypackagingslip, packagingSlip);

            bizRuleEngineRequestHandler.Handle(services);
        }
    }
}
