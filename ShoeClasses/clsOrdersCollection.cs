using System;
using System.Collections.Generic;

namespace ShoeClasses
{
    public class clsOrdersCollection
    {
        //active private member for the list
        List<clsOrders> mOrdersList = new List<clsOrders>();
        //public data member thisOrder
        clsOrders mThisOrder = new clsOrders();
        //public property for the orders list
        public List<clsOrders> OrdersList
        {
            get
            {
                //return the private data
                return mOrdersList;
            }
            set
            {
                //set the private data
                mOrdersList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrdersList.Count;
            }
            set
            {
                //
            }

        }
        public clsOrders ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        //constructor for the class
        public clsOrdersCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Order
                clsOrders AnOrder = new clsOrders();
                //read in the fields from the current record
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AnOrder.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnOrder.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnOrder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                AnOrder.Delivery = Convert.ToBoolean(DB.DataTable.Rows[Index]["Delivery"]);
                AnOrder.TotalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalPrice"]);
                //add the record to the private data member
                mOrdersList.Add(AnOrder);
                //point at the next record
                Index++;
            }



            //create the items of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.StaffNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.Description = "Test Description";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PaymentMethod = "cash";
            TestItem.Delivery = true;
            TestItem.TotalPrice = 15.99;
            //add the item to the test list
            mOrdersList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsOrders();
            //set its properties
            TestItem.Active = true;
            TestItem.OrderNo = 2;
            TestItem.StaffNo = 2;
            TestItem.CustomerNo = 2;
            TestItem.Description = "Test Description2";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PaymentMethod = "card";
            TestItem.Delivery = false;
            TestItem.TotalPrice = 24.99;
            //add the item to the test list
            mOrdersList.Add(TestItem);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisOrder.StaffNo);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@Description", mThisOrder.Description);
            DB.AddParameter("@DataAdded", mThisOrder.DateAdded);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@Delivery", mThisOrder.Delivery);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@Active", mThisOrder.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }
    }


}