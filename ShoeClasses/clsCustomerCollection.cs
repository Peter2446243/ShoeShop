using System;
using System.Collections.Generic;

namespace ShoeClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the paraleter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to procss
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.Registration = Convert.ToBoolean(DB.DataTable.Rows[Index]["Registration"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.SurName = Convert.ToString(DB.DataTable.Rows[Index]["SurName"]);
                ACustomer.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ACustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }





        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@SurName", mThisCustomer.SurName);
            DB.AddParameter("@Gender", mThisCustomer.Gender);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Registration", mThisCustomer.Registration);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_Delete");
        }
        public void Update()
        {
            //Update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@SurName", mThisCustomer.SurName);
            DB.AddParameter("@Gender", mThisCustomer.Gender);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Registration", mThisCustomer.Registration);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_Update");
        }

        public void ReportBySurName(string SurName)
        {
            //filters the records based on a full or partial surname
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the SurName parameter to the database
            DB.AddParameter("@SurName", SurName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterBySurName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        
    }

}