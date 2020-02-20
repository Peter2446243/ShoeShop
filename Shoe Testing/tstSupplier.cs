using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace Shoe_Testing
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            Assert.IsNotNull(aSupplier);
        }
    }
}
