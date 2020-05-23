using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace Shoe_Testing
{
    [TestClass]
    public class tstOrders
    {
        //good test data
        //create some test data to pass to the method
        string OrderNo = "1";
        string StaffNo = "1";
        string CustomerNo = "1";
        string DateAdded = DateTime.Now.Date.ToString();
        string Description = "Test Description";
        string PaymentMethod = "card";
        string Delivery = "True";
        string TotalPrice = "14.99";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffNo, TestData);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerNo, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            String TestData = "test";
            //assign the data to the property
            AnOrder.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Description, TestData);
        }

        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            String TestData = "test";
            //assign the data to the property
            AnOrder.PaymentMethod = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.PaymentMethod, TestData);
        }

        [TestMethod]
        public void DeliveryPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Delivery = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Delivery, TestData);
        }

        [TestMethod]
        public void TotalPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Double TestData = 49.99;
            //assign the data to the property
            AnOrder.TotalPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with this method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.OrderNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.StaffNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.CustomerNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.Description != "Test Description")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentMethodFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.PaymentMethod != "card")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.Delivery != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.TotalPrice != 14.99)
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
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders anOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = ""; //this should trigger an error
            //invoke the method
            Error = anOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMin()
        {
            //create an instance of the class we want to create
            clsOrders anOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "1"; //this should be ok
            //invoke the method
            Error = anOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "11"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "";
            OrderNo = OrderNo.PadRight(2147483647, '1') + 1;
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "";
            OrderNo = OrderNo.PadRight(2147483646, '1');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "2147483648"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "2147483648"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //set the dateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
    }
