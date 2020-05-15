using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace Shoe_Testing
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        //create some test data to pass to the method
        string EnrolmentDate = DateTime.Now.Date.ToString();
        string Department = "Warehouse";
        string JobTitle = "Warehouse Operative";
        string Name = "Frank Lampard";
        string Extension = "+456";
        string PhoneNo = "07443274958";
        string HomeAddress = "92 High Street";
        string Postcode = "SW3 7CH";
        string City = "London";

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
            Int32 TestData = 3;
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
            string TestData = "Warehouse";
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
            string TestData = "Warehouse Operative";
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
            string TestData = "Frank Lampard";
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
            string TestData = "+456";
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
            string TestData = "07443274958";
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
            string TestData = "92 High Street";
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
            string TestData = "SW3 7CH";
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
            string TestData = "London";
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.StaffID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEnrolmentDateFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.EnrolmentDate != Convert.ToDateTime("10/12/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartmentFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.Department != "Warehouse")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestJobTitleFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.JobTitle != "Warehouse Operative")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.Name != "Frank Lampard")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestExtensionFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.Extension != "+456")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.PhoneNo != "07443274958")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHomeAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.HomeAddress != "92 High Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.Postcode != "SW3 7CH")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCityFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.City != "London")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 3;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.Available != true)
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
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EnrolmentDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string EnrolmentDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EnrolmentDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string EnrolmentDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EnrolmentDateMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string EnrolmentDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EnrolmentDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string EnrolmentDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EnrolmentDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string EnrolmentDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EnrolmentDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the EnrolmentDate to a non date value
            string EnrolmentDate = "this is not a date!";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Postcode = "";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Postcode = "a";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Postcode = "aa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Postcode = "aaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Postcode = "aaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Postcode = "aaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Postcode = "aaaa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string City = "";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string City = "a";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string City = "aa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string City = "";
            City = City.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string City = "";
            City = City.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string City = "";
            City = City.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string City = "";
            City = City.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Department = "";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Department = "a";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeptartmentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Department = "aa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Department = "";
            Department = Department.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Department = "";
            Department = Department.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Department = "";
            Department = Department.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Department = "";
            Department = Department.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string JobTitle = "";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobTitleMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string JobTitle = "a";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string JobTitle = "aa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void JobTitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTitleMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobTitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobTitleMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Name = "";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Name = "a";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Name = "aa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Name = "";
            Name = Name.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Name = "";
            Name = Name.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Name = "";
            Name = Name.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneNo = "";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNo = "a";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNo = "aa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string HomeAddress = "";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HomeAddress = "a";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HomeAddress = "aa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void HomeAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HomeAddress = "";
            HomeAddress = HomeAddress.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HomeAddress = "";
            HomeAddress = HomeAddress.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string HomeAddress = "";
            HomeAddress = HomeAddress.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HomeAddress = "";
            HomeAddress = HomeAddress.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExtensionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Extension = "";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExtensionMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Extension = "a";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExtensionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Extension = "aa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExtensionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Extension = "aaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExtensionMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Extension = "aaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExtensionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Extension = "aaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExtensionMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Extension = "aaaa";
            //invoke the method
            Error = AStaff.Valid(EnrolmentDate, Department, JobTitle, Name, Extension, PhoneNo, HomeAddress, Postcode, City);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
