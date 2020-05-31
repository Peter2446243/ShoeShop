using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace Shoe_Testing
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string Email = "joebloggs@hotmail.com";
        string Password = "thisisme";
        string FirstName = "Joe";
        string SurName = "Bloggs";
        string PhoneNumber = "07935258941";
        string Address = "10 London Street";
        string Gender = "Male";
        string DateOfBirth = DateTime.Now.Date.ToString();



        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the tww values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);

        }
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //test to see that the tww values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);


        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "joebloggs@hotmail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "thisisme";
            //assign the data to the property
            ACustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07935258941";
            //assign the data to the property
            ACustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "10 London Street";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Joe";
            //assign the data to the property
            ACustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }
        [TestMethod]
        public void SurNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Bloggs";
            //assign the data to the property
            ACustomer.SurName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.SurName, TestData);
        }
        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Male";
            //assign the data to the property
            ACustomer.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Gender, TestData);
        }

        [TestMethod]
        public void RegistrationPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Registration = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Registration, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

       
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Email != "joebloggs@hotmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Password != "thisisme")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.PhoneNumber != "07935258941")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Address != "10 London Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.FirstName != "Joe")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSurNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.SurName != "Bloggs")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestGenderFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Gender != "Male")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.DateOfBirth != Convert.ToDateTime("07/01/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestRegistrationFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Registration != true)
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
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "b"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "bb"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(49, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(50, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(25, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should fail
            Email = Email.PadRight(51, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should fail
            Email = Email.PadRight(200, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 200 years
            TestDate = TestDate.AddYears(-200);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 13 years
            TestDate = TestDate.AddYears(-13).AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date.AddYears(-13);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
 
        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date + 200 years
            TestDate = TestDate.AddYears(200);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateOfBirth to a non date value
            string DateOfBirth = "this is not a date!";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Password = ""; 
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "b"; 
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "bb"; 
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = ""; 
            Password = Password.PadRight(49, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = ""; 
            Password = Password.PadRight(50, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Password = "";
            Password = Password.PadRight(51, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = ""; 
            Password = Password.PadRight(25, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "b";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "bb";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = ""; //
            FirstName = FirstName.PadRight(50, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SurName = "";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SurNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string SurName = "b";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string SurName = "bb";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string SurName = "";
            SurName = SurName.PadRight(49, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string SurName = ""; //
            SurName = SurName.PadRight(50, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SurName = "";
            SurName = SurName.PadRight(51, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SurNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string SurName = "";
            SurName = SurName.PadRight(25, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneNumber = "";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "b";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "bb";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(49, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = ""; //
            PhoneNumber = PhoneNumber.PadRight(50, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(51, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(25, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "b";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "bb";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(99, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = ""; //
            Address = Address.PadRight(100, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            Address = Address.PadRight(101, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(50, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Gender = "";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Gender = "b";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Gender = "bb";
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Gender = "";
            Gender = Gender.PadRight(14, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Gender = ""; //
            Gender = Gender.PadRight(15, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Gender = "";
            Gender = Gender.PadRight(16, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Gender = "";
            Gender = Gender.PadRight(8, 'm');
            //invoke the method
            Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }











    }
}
 