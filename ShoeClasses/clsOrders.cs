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

        /*
        public bool Find(int orderNo)
        {
            //set the private data members to the test data value
            mOrderNo = 21;
            mStaffNo = 21;
            mCustomerNo = 21;
            mDateAdded = Convert.ToDateTime("16/09/2015");
            mDescription = "Test Description";
            mPaymentMethod = "card";
            mDelivery = true;
            mTotalPrice = 14.99;
            //always return true
            return true;
        }
        */

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
    }
}