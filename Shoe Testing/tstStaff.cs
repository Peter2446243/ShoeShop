using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace Shoe_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Sales";
            //assign the data to the property
            AStaff.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Department, TestData);
        }

        [TestMethod]
        public void JobTitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Sales Manager";
            //assign the data to the property
            AStaff.JobTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.JobTitle, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Joe Bloggs";
            //assign the data to the property
            AStaff.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Name, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Available, TestData);
        }

        [TestMethod]
        public void ExtensionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "123";
            //assign the data to the property
            AStaff.Extension = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Extension, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "07123456789";
            //assign the data to the property
            AStaff.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.PhoneNo, TestData);
        }

        [TestMethod]
        public void HomeAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b Some Street";
            //assign the data to the property
            AStaff.HomeAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.HomeAddress, TestData);
        }

        [TestMethod]
        public void PostcodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LE1 2AB";
            //assign the data to the property
            AStaff.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Postcode, TestData);
        }

        [TestMethod]
        public void CityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AStaff.City = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.City, TestData);
        }

        [TestMethod]
        public void EnrolmentDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.EnrolmentDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EnrolmentDate, TestData);
        }

    }
}
