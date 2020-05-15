using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;
using System.Collections.Generic;

namespace Shoe_Testing
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Available = true;
            TestItem.EnrolmentDate = DateTime.Now.Date;
            TestItem.StaffID = 1;
            TestItem.Department = "Some Department";
            TestItem.JobTitle = "Some Job";
            TestItem.Name = "Some Person";
            TestItem.Extension = "+123";
            TestItem.PhoneNo = "07123456789";
            TestItem.HomeAddress = "123a Some Street";
            TestItem.Postcode = "LE1 2AB";
            TestItem.City = "Some City";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Available = true;
            TestStaff.StaffID = 1;
            TestStaff.Department = "Some Department";
            TestStaff.EnrolmentDate = DateTime.Now.Date;
            TestStaff.JobTitle = "Some Job";
            TestStaff.Postcode = "LE1 2AB";
            TestStaff.City = "Some City";
            TestStaff.Name = "Some Person";
            TestStaff.Extension = "+123";
            TestStaff.PhoneNo = "07123456789";
            TestStaff.HomeAddress = "123a Some Street";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Available = true;
            TestItem.EnrolmentDate = DateTime.Now.Date;
            TestItem.StaffID = 1;
            TestItem.Department = "Some Department";
            TestItem.JobTitle = "Some Job";
            TestItem.Name = "Some Person";
            TestItem.Extension = "+123";
            TestItem.PhoneNo = "07123456789";
            TestItem.HomeAddress = "123a Some Street";
            TestItem.Postcode = "LE1 2AB";
            TestItem.City = "Some City";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.EnrolmentDate = DateTime.Now.Date;
            TestItem.StaffID = 1;
            TestItem.Department = "Some Department";
            TestItem.JobTitle = "Some Job";
            TestItem.Name = "Some Person";
            TestItem.Extension = "+123";
            TestItem.PhoneNo = "07123456789";
            TestItem.HomeAddress = "123a Some Street";
            TestItem.Postcode = "LE1 2AB";
            TestItem.City = "Some City";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.EnrolmentDate = DateTime.Now.Date;
            TestItem.StaffID = 1;
            TestItem.Department = "Some Department";
            TestItem.JobTitle = "Some Job";
            TestItem.Name = "Some Person";
            TestItem.Extension = "+123";
            TestItem.PhoneNo = "07123456789";
            TestItem.HomeAddress = "123a Some Street";
            TestItem.Postcode = "LE1 2AB";
            TestItem.City = "Some City";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.EnrolmentDate = DateTime.Now.Date;
            TestItem.StaffID = 1;
            TestItem.Department = "Some Department";
            TestItem.JobTitle = "Some Job";
            TestItem.Name = "Some Person";
            TestItem.Extension = "+123";
            TestItem.PhoneNo = "07123456789";
            TestItem.HomeAddress = "123a Some Street";
            TestItem.Postcode = "LE1 2AB";
            TestItem.City = "Some City";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test data
            TestItem.Available = false;
            TestItem.EnrolmentDate = DateTime.Now.Date;
            TestItem.StaffID = 4;
            TestItem.Department = "Another Department";
            TestItem.JobTitle = "Another Job";
            TestItem.Name = "Another Person";
            TestItem.Extension = "+654";
            TestItem.PhoneNo = "07987654321";
            TestItem.HomeAddress = "123b Another Street";
            TestItem.Postcode = "LE2 1BA";
            TestItem.City = "Another City";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see thisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportByPostcodeMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records);
            FilteredStaff.ReportByPostcode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a postcode that doesn't exist
            FilteredStaff.ReportByPostcode("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredStaff.ReportByPostcode("yyy yyy");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredStaff.StaffList[0].StaffID != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 2
                if (FilteredStaff.StaffList[1].StaffID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = true;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
