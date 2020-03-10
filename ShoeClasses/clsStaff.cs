using System;

namespace ShoeClasses
{
    public class clsStaff
    {

        public bool Find(int StaffID)
        {
            //set the private data members to the test data value
            mStaffID = 21;
            //always return true
            return true;
        }

        public int StaffID { get; set; }

        //addressNo private member variable
        private Int32 mStaffID;
        //AddressNo public property
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


    }
}