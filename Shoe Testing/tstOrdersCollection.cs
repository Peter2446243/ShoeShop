using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;
using System.Collections.Generic;

namespace Shoe_Testing
{
    [TestClass]
    public class tstOrdersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrdersListOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.StaffNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.Description = "Test Description";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PaymentMethod = "cash";
            TestItem.Delivery = true;
            TestItem.TotalPrice = 15.99;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }


        [TestMethod]
        public void ThisOrdersPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            clsOrders TestOrder = new clsOrders();
            //set the properties of the test object
            TestOrder.Active = true;
            TestOrder.OrderNo = 1;
            TestOrder.StaffNo = 1;
            TestOrder.CustomerNo = 1;
            TestOrder.Description = "Test Description";
            TestOrder.DateAdded = DateTime.Now.Date;
            TestOrder.PaymentMethod = "cash";
            TestOrder.Delivery = true;
            TestOrder.TotalPrice = 14.98;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.StaffNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.Description = "Test Description";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PaymentMethod = "cash";
            TestItem.Delivery = true;
            TestItem.TotalPrice = 15.99;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.StaffNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.Description = "Test Description";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PaymentMethod = "cash";
            TestItem.Delivery = true;
            TestItem.TotalPrice = 15.99;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.StaffNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.Description = "Test Description";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PaymentMethod = "cash";
            TestItem.Delivery = true;
            TestItem.TotalPrice = 15.99;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }
}
