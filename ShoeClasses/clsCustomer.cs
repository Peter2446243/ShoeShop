using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeClasses
{
    public class clsCustomer
    {
        //private data member for registration

        private Boolean mRegistration;

        //public property for registration

        public bool Registration
        {
            get
            {
                //return the private data
                return mRegistration;
            }
            set
            {
                //set the private data
                mRegistration = value;
            }
        }


        //private date of birth data member

        private DateTime mDateOfBirth;

        //public property for date of birth
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the private data
                mDateOfBirth = value;
            }
        }

        //private data member for the CustomerID property

        private Int32 mCustomerID;

        //public property for  the CustomerID
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }

        //private data member for the Email

        private string mEmail;

        //public property for  the Email
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the private data
                mEmail = value;
            }
        }

        //private data member for the Password

        private string mPassword;

        //public property for  the Password
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }
        }

        //private data member for the Phone number

        private string mPhoneNumber;

        //public property for  the Phone number
        public string PhoneNumber
        {
            get
            {
                //return the private data
                return mPhoneNumber;
            }
            set
            {
                //set the private data
                mPhoneNumber = value;
            }
        }

        //private data member for the first name

        private string mFirstName;

        //public property for  the first name
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the private data
                mFirstName = value;
            }
        }

        //private data member for the surname

        private string mSurName;

        //public property for  the surname
        public string SurName
        {
            get
            {
                //return the private data
                return mSurName;
            }
            set
            {
                //set the private data
                mSurName = value;
            }
        }

        //private data member for the address

        private string mAddress;

        //public property for  the address
        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
            }
            set
            {
                //set the private data
                mAddress = value;
            }
        }

        //private data member for the gender

        private string mGender;

        //public property for  the gender
        public string Gender
        {
            get
            {
                //return the private data
                return mGender;
            }
            set
            {
                //set the private data
                mGender = value;
            }
        }
        public bool Find(int customerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found there should be either one or zeron!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSurName = Convert.ToString(DB.DataTable.Rows[0]["SurName"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mRegistration = Convert.ToBoolean(DB.DataTable.Rows[0]["Registration"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }




        public string Valid(string email, string password, string firstName, string surName, string dateOfBirth, string phoneNumber, string address, string gender)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            //if the email is greater than 50 characters
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "The Email must be less than 50 characters : ";
            }
            try
            {
                //copy the DateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp < DateTime.Now.Date.AddYears(-13))
                {
                    //record the error
                    Error = Error + "You can not be less than 13 years old or more than 200 years old: ";
                }
                //check to see if the date is greater than 13 years in the past
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //if the Password is blank
            if (password.Length == 0)
            {
                //record the error
                Error = Error + "The password may not be blank : ";
            }
            //if the password is too long
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "The password must be less than 50 characters : ";
            }
            //if the first name is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank : ";
            }
            //if the first name is too long
            if (firstName.Length > 50)
            {
                //record the error
                Error = Error + "The first name must be less than 50 characters : ";
            }
            //if the surname is blank
            if (surName.Length == 0)
            {
                //record the error
                Error = Error + "The surname may not be blank : ";
            }
            //if the first name is too long
            if (surName.Length > 50)
            {
                //record the error
                Error = Error + "The surname must be less than 50 characters : ";
            }
            //if the phone number is blank
            if (phoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The phone number may not be blank : ";
            }
            //if the first name is too long
            if (phoneNumber.Length > 50)
            {
                //record the error
                Error = Error + "The phone number must be less than 50 characters : ";
            }
            //if the address is blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }
            //if the address is too long
            if (address.Length > 100)
            {
                //record the error
                Error = Error + "The address must be less than 100 characters : ";
            }
            //if the  gender is blank
            if (gender.Length == 0)
            {
                //record the error
                Error = Error + "The  gender may not be blank : ";
            }
            //if the  gender is too long
            if (gender.Length > 15)
            {
                //record the error
                Error = Error + "The  gender must be less than 15 characters : ";
            }
            //return any error messages
            return Error;
        }

        
    }
}
            
            
            

           
