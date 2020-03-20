using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace Shoe_Testing
{
    [TestClass]
    public class tstOrderline
    {
        //good test data
        //create some test data to pass to the method
        string ShoeNo = "1";
        string Quantity = "1";

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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with this method
            Int32 OrderlineNo = 1;
            //invoke the method
            Found = AnOrderline.Find(OrderlineNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderlineNoFound()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderlineNo = 1;
            //invoke the method
            Found = AnOrderline.Find(OrderlineNo);
            //check the order no
            if (AnOrderline.OrderlineNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeNoFound()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderlineNo = 1;
            //invoke the method
            Found = AnOrderline.Find(OrderlineNo);
            //check the order no
            if (AnOrderline.ShoeNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderlineNo = 1;
            //invoke the method
            Found = AnOrderline.Find(OrderlineNo);
            //check the order no
            if (AnOrderline.Quantity != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrderline.Valid(ShoeNo, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
