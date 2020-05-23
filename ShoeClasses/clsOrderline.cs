using System;

namespace ShoeClasses
{
    public class clsOrderline
    {

        //Active private member variable
        private bool mActive;
        //Active public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }
        //OrderlineNo private member variable
        private Int32 mOrderlineNo;
        //OrderlineNo public property
        public Int32 OrderlineNo
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderlineNo;
            }
            set
            {
                //this line of code allows data into the property
                mOrderlineNo = value;
            }
        }
        //ShoeNo private member variable
        private Int32 mShoeNo;
        //ShoeNo public property
        public Int32 ShoeNo
        {
            get
            {
                //this line of code sends data out of the property
                return mShoeNo;
            }
            set
            {
                //this line of code allows data into the property
                mShoeNo = value;
            }
        }
        //Quantity private member variable
        private Int32 mQuantity;
        //Quantity public property
        public Int32 Quantity
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mQuantity = value;
            }
        }
        
        public bool Find(int OrderlineNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order no to search for
            DB.AddParameter("@OrderlineNo", OrderlineNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderline_FilterByOrderlineNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderlineNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderlineNo"]);
                mShoeNo = Convert.ToInt32(DB.DataTable.Rows[0]["ShoeNo"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
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
        //function for the public validation method
        public string Valid(string shoeNo,
                            string quantity)
        ///this function accepts 2 parameteres for validation
        ///the function returns a string containing any error message
        ///if no errors found then a blank string is returned
        {
            return "";
        }
    }
}
