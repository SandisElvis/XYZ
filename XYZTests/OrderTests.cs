using Microsoft.VisualStudio.TestTools.UnitTesting;
using XYZ.Controllers;

namespace XYZTests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void GetOrderByOrderNumberTest()
        {
            // Create an instance to test:
            OrderController oc = new OrderController();
            string OrderNumber = "ON1";
            oc.GetOrderByOrderNumber(OrderNumber);
        }

        [TestMethod]
        public void GetAndBuyOrderTest()
        {
            // Create an instance to test:
            OrderController oc = new OrderController();
            string OrderNumber = "ASD";
            double PayableAmount = 213;
            oc.GetAndBuyOrder(OrderNumber, PayableAmount);
        }
    }
}
