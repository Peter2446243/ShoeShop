using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shoe_Testing
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK2()
        {
            clsSupplier aSupplier = new clsSupplier();
            Assert.IsNotNull(aSupplier);
        }
    }
}
