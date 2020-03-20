using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace Shoe_Testing
{
    [TestClass]
    public class tstOrderline
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //test to see that it exists
            Assert.IsNotNull(AnOrderline);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrderline.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderline.Active, TestData);
        }

        [TestMethod]
        public void OrderlineNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderline.OrderlineNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderline.OrderlineNo, TestData);
        }

        [TestMethod]
        public void ShoeNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderline.ShoeNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderline.ShoeNo, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderline.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderline.Quantity, TestData);
        }
    }
}
