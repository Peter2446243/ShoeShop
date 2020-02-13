using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shoe_Testing
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrders AnOrder = new clsOrders();
            Assert.IsNotNull(AnOrder);
        }
    }
}
