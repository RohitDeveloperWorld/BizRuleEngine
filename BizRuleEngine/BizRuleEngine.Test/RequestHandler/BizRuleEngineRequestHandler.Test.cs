using BizRuleEngine.RequestHandler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BizRuleEngine.Test
{
    [TestClass]
    public class BizRuleEngineRequestHandlerTest
    { 
        [TestMethod]
        public void CheckBizRuleEngineRequestHandler()
        {
            BizRuleEngineRequestHandler.Handle();
        }

        [TestMethod]
        public void PhysicalProductPayment()
        {
            BizRuleEngineRequestHandler.Handle();
        }
    }
}
