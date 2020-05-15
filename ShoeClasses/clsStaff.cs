using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeClasses
{
    public class clsStaff
    {
        //StaffID private member variable
        private Int32 mStaffID;
        //private data member for available
        private Boolean mAvailable;
        //private data member for enrolment date
        private DateTime mEnrolmentDate;
        //private data member for post code
        private string mPostcode;
        //private data member for department
        private string mDepartment;
        //private data member for job title
        private string mJobTitle;
        //private data member for name
        private string mName;
        //private data member for extension
        private string mExtension;
        //private data member for phone no
        private string mPhoneNo;
        //private data member for home address
        private string mHomeAddress;
        //private data member for city
        private string mCity;

        //StaffID public property
        public Int32 StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this.line of code allows data into the property
                mStaffID = value;
            }
        }

        //public property for available
        public bool Available
        {
            get
            {
                //return the private data
                return mAvailable;
            }
            set
            {
                //set the private data
                mAvailable = value;
            }
        }

        //public property for enrolment date
        public DateTime EnrolmentDate
        {
            get
            {
                //return the private data
                return mEnrolmentDate;
            }
            set
            {
                //set the private data
                mEnrolmentDate = value;
            }
        }

        //public property for post code
        public string Postcode
        {
            get
            {
                //return the private data
                return mPostcode;
            }
            set
            {
                //set the private data
                mPostcode = value;
            }
        }

        //public property for department
        public string Department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data
                mDepartment = value;
            }
        }

        //public property for job title
        public string JobTitle
        {
            get
            {
                //return the private data
                return mJobTitle;
            }
            set
            {
                //set the private data
                mJobTitle = value;
            }
        }

        //public property for name
        public string Name
        {
            get
            {
                //return the private data
                return mName;
            }
            set
            {
                //set the private data
                mName = value;
            }
        }

        //public property for extension
        public string Extension
        {
            get
            {
                //return the private data
                return mExtension;
            }
            set
            {
                //set the private data
                mExtension = value;
            }
        }

        //public property for phone no
        public string PhoneNo
        {
            get
            {
                //return the private data
                return mPhoneNo;
            }
            set
            {
                //set the private data
                mPhoneNo = value;
            }
        }

        //public property for home address
        public string HomeAddress
        {
            get
            {
                //return the private data
                return mHomeAddress;
            }
            set
            {
                //set the private data
                mHomeAddress = value;
            }
        }

        //public property for city
        public string City
        {
            get
            {
                //return the private data
                return mCity;
            }
            set
            {
                //set the private data
                mCity = value;
            }
        }

        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mEnrolmentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["EnrolmentDate"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mJobTitle = Convert.ToString(DB.DataTable.Rows[0]["JobTitle"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mExtension = Convert.ToString(DB.DataTable.Rows[0]["Extension"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mHomeAddress = Convert.ToString(DB.DataTable.Rows[0]["HomeAddress"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
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

        public string Valid(string enrolmentDate, string department, string jobTitle, string name, string extension, string phoneNo, string homeAddress, string postcode, string city)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            try
            {
                //copy the enrolmentDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(enrolmentDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
            }

            //is the post code blank
            if (postcode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (postcode.Length > 9)
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
            }

            //is the city blank
            if (city.Length == 0)
            {
                //record the error
                Error = Error + "The city may not be blank : ";
            }
            //if the city is too long
            if (city.Length > 50)
            {
                //record the error
                Error = Error + "The city must be less than 50 characters : ";
            }

            //is the department blank
            if (department.Length == 0)
            {
                //record the error
                Error = Error + "The department may not be blank : ";
            }
            //if the department is too long
            if (department.Length > 50)
            {
                //record the error
                Error = Error + "The department must be less than 50 characters : ";
            }

            //is the jobTitle blank
            if (jobTitle.Length == 0)
            {
                //record the error
                Error = Error + "The job title may not be blank : ";
            }
            //if the jobTitle is too long
            if (jobTitle.Length > 50)
            {
                //record the error
                Error = Error + "The job title must be less than 50 characters : ";
            }

            //is the name blank
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The name may not be blank : ";
            }
            //if the name is too long
            if (name.Length > 50)
            {
                //record the error
                Error = Error + "The department must be less than 50 characters : ";
            }

            //is the phoneNo blank
            if (phoneNo.Length == 0)
            {
                //record the error
                Error = Error + "The phone no. may not be blank : ";
            }
            //if the phoneNo is too long
            if (phoneNo.Length > 50)
            {
                //record the error
                Error = Error + "The phone no. must be less than 50 characters : ";
            }

            //is the homeAddress blank
            if (homeAddress.Length == 0)
            {
                //record the error
                Error = Error + "The home address may not be blank : ";
            }
            //if the homeAddress is too long
            if (homeAddress.Length > 50)
            {
                //record the error
                Error = Error + "The home address must be less than 50 characters : ";
            }

            //is the extension blank
            if (extension.Length == 0)
            {
                //record the error
                Error = Error + "The extension may not be blank : ";
            }
            //if the extension is too long
            if (extension.Length > 9)
            {
                //record the error
                Error = Error + "The extension must be less than 9 characters : ";
            }

            //return any error messages
            return Error;
        }
    }
}
