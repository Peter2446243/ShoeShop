using System;

namespace ShoeClasses
{
    public class clsOrders
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
        //DateTime private member variable
        private DateTime mDateAdded;
        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        //OrderNo private member variable
        private Int32 mOrderNo;
        //OrderNo public property
        public Int32 OrderNo
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderNo;
            }
            set
            {
                //this line of code allows data into the property
                mOrderNo = value;
            }
        }
        //StaffNo private member variable
        private Int32 mStaffNo;
        //StaffNo public property
        public Int32 StaffNo
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffNo;
            }
            set
            {
                //this line of code allows data into the property
                mStaffNo = value;
            }
        }
        //CustomerNo private member variable
        private Int32 mCustomerNo;
        //CustomerNo public property
        public Int32 CustomerNo
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerNo = value;
            }
        }
        //Description private member variable
        private string mDescription;
        //Decription public property
        public string Description
        {
            get
            {
                //this line of code sends data out of the property
                return mDescription;
            }
            set
            {
                //this line of code allows data into the property
                mDescription = value;
            }
        }
        //PaymentMethod private member variable
        private string mPaymentMethod;
        //PaymentMethod public property
        public string PaymentMethod
        {
            get
            {
                //this line of code sends data out of the property
                return mPaymentMethod;
            }
            set
            {
                //this line of code allows data into the property
                mPaymentMethod = value;
            }
        }
        //Delivery private member variable
        private bool mDelivery;
        //Delivery public property
        public bool Delivery
        {
            get
            {
                //this line of code sends data out of the property
                return mDelivery;
            }
            set
            {
                //this line of code allows data into the property
                mDelivery = value;
            }
        }
        //totalPrice private member variable
        private double mTotalPrice;
        //Delivery public property
        public double TotalPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mTotalPrice;
            }
            set
            {
                //this line of code allows data into the property
                mTotalPrice = value;
            }
        }


        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count ==1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mDelivery = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivery"]);
                mTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["TotalPrice"]);
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
        public string Valid(string orderNo,
                            string staffNo,
                            string customerNo,
                            string dataAdded,
                            string description,
                            string paymentMethod,
                            string delivery,
                            string totalPrice)
        ///this function accepts 8 parameteres for validation
        ///the function returns a string containing any error message
        ///if no errors found then a blank string is returned
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the OrderNo is blank
            if (orderNo.Length ==0)
            {
                //record the error
                Error = Error + "The Order no may not be blank : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
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
                Error = Error + "The date was not a valid date : ";
            }
            //return any error messages
            return Error;
        }
    }
}