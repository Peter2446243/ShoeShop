using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;
using System.Collections.Generic;

namespace Shoe_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item on the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Registration = true;
            TestItem.CustomerID = 1;
            TestItem.Email = "some email";
            TestItem.Password = "somepassword";
            TestItem.FirstName = "some name";
            TestItem.SurName = "some surname";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNumber = "07953641257";
            TestItem.Address = "some address";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void ThisCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Registration = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.Email = "some email";
            TestCustomer.Password = "somepassword";
            TestCustomer.FirstName = "some name";
            TestCustomer.SurName = "some surname";
            TestCustomer.Gender = "Male";
            TestCustomer.DateOfBirth = DateTime.Now.Date;
            TestCustomer.PhoneNumber = "07953641257";
            TestCustomer.Address = "some address";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item on the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Registration = true;
            TestItem.CustomerID = 1;
            TestItem.Email = "some email";
            TestItem.Password = "somepassword";
            TestItem.FirstName = "some name";
            TestItem.SurName = "some surname";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNumber = "07953641257";
            TestItem.Address = "some address";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Registration = true;
            TestItem.CustomerID = 1;
            TestItem.Email = "some email";
            TestItem.Password = "somepassword";
            TestItem.FirstName = "some name";
            TestItem.SurName = "some surname";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNumber = "07953641257";
            TestItem.Address = "some address";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Registration = true;
            TestItem.CustomerID = 1;
            TestItem.Email = "some email";
            TestItem.Password = "somepassword";
            TestItem.FirstName = "some name";
            TestItem.SurName = "some surname";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNumber = "07953641257";
            TestItem.Address = "some address";
            //set  ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Registration = true;
            TestItem.CustomerID = 1;
            TestItem.Email = "some email";
            TestItem.Password = "somepassword";
            TestItem.FirstName = "some name";
            TestItem.SurName = "some surname";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNumber = "07953641257";
            TestItem.Address = "some address";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key to the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.Registration = false;
            TestItem.CustomerID = 3;
            TestItem.Email = "another email";
            TestItem.Password = "anotherpassword";
            TestItem.FirstName = "another name";
            TestItem.SurName = "another surname";
            TestItem.Gender = "Female";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNumber = "07154284567";
            TestItem.Address = "another address";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void ReportBySurNameOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportBySurName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportBySurNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a surname that doesn't exist
            FilteredCustomers.ReportBySurName("xxxxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportBySurNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a surname that doesn't exist
            FilteredCustomers.ReportBySurName("xxxxx");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredCustomers.CustomerList[0].CustomerID != 36)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredCustomers.CustomerList[1].CustomerID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
