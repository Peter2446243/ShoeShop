using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeClasses
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisAddress
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AStaff.EnrolmentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["EnrolmentDate"]);
                AStaff.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                AStaff.JobTitle = Convert.ToString(DB.DataTable.Rows[Index]["JobTitle"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.Extension = Convert.ToString(DB.DataTable.Rows[Index]["Extension"]);
                AStaff.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                AStaff.HomeAddress = Convert.ToString(DB.DataTable.Rows[Index]["HomeAddress"]);
                AStaff.Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                AStaff.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                //add the record to the private data mamber
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }
        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {

            }
        }

        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Department", mThisStaff.Department);
            DB.AddParameter("@JobTitle", mThisStaff.JobTitle);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Available", mThisStaff.Available);
            DB.AddParameter("@Extension", mThisStaff.Extension);
            DB.AddParameter("@PhoneNo", mThisStaff.PhoneNo);
            DB.AddParameter("@HomeAddress", mThisStaff.HomeAddress);
            DB.AddParameter("@Postcode", mThisStaff.Postcode);
            DB.AddParameter("@City", mThisStaff.City);
            DB.AddParameter("@Enrolment", mThisStaff.EnrolmentDate);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //update the existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@Department", mThisStaff.Department);
            DB.AddParameter("@JobTitle", mThisStaff.JobTitle);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Available", mThisStaff.Available);
            DB.AddParameter("@Extension", mThisStaff.Extension);
            DB.AddParameter("@PhoneNo", mThisStaff.PhoneNo);
            DB.AddParameter("@HomeAddress", mThisStaff.HomeAddress);
            DB.AddParameter("@Postcode", mThisStaff.Postcode);
            DB.AddParameter("@City", mThisStaff.City);
            DB.AddParameter("@Enrolment", mThisStaff.EnrolmentDate);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByPostcode(string Postcode)
        {
            //filters the records based on a full or partial postcode
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Postcode parameter to the database
            DB.AddParameter("@Postcode", Postcode);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByPostcode");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}
