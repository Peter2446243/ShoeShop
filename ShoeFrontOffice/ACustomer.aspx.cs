using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class ACustomer : System.Web.UI.Page
{
    //var to store the primary key with page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of clients to be processed
        CustomerID = Convert.ToInt32(Sesssion["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }


        void DisplayCustomer()
        {
            //create an instance of the shoestore
            clsCustomerCollection ShoeStore = new clsCustomerCollection();
            //find the record to update
            ShoeStore.ThisCustomer.Find(CustomerID);
            //display the data for this record
        
            txtCustomerID.Text = ShoeStore.ThisCustomer.CustomerID.ToString();
            
            txtFirstName.Text = ShoeStore.ThisCustomer.FirstName;
            txtSurName.Text = ShoeStore.ThisCustomer.SurName;
            txtPassword.Text = ShoeStore.ThisCustomer.Password;
            txtEmail.Text = ShoeStore.ThisCustomer.Email;
            txtPhoneNumber.Text = ShoeStore.ThisCustomer.PhoneNumber;
            txtDateOfBirth.Text = ShoeStore.ThisCustomer.DateOfBirth.ToString();
            txtAddress.Text = ShoeStore.ThisCustomer.Address;
            txtGender.Text = ShoeStore.ThisCustomer.Gender;
            chkRegistration.Checked = ShoeStore.ThisCustomer.Registration;

            ;
        }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        // capture the first name
        string FirstName = txtFirstName.Text;
        //capture the surname
        string SurName = txtSurName.Text;
        //capture the Password
        string Password = txtPassword.Text;
        //capture the Email
        string Email = txtEmail.Text;
        //capture the Date of Birth
        string DateOfBirth = txtDateOfBirth.Text;
        //capture the phone number
        string PhoneNumber = txtPhoneNumber.Text;
        //capture the Address
        string Address = txtAddress.Text;
        //capture the gender
        string Gender = txtGender.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(Email, Password, FirstName, SurName, DateOfBirth, PhoneNumber, Address, Gender);
        if (Error == "")
        {
            //capture the CustomerID
            ACustomer.CustomerID = CustomerID; //don't miss this bit!!!!!!!!!
            // capture the first name
            ACustomer.FirstName = FirstName;
            //capture the surname
            ACustomer.SurName = SurName;
            //capture the Password
            ACustomer.Password = Password;
            //capture the Email
            ACustomer.Email =Email;
            //capture the Date of Birth
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //capture the phone number
            ACustomer.PhoneNumber = PhoneNumber;
            //capture the Address
            ACustomer.Address = Address;
            //capture the gender
            ACustomer.Gender =Gender;
            //capture registration
            ACustomer.Registration = chkRegistration.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
           
            //if this is a new record i.e. CustomerID = -1 then ad the data
            if (CustomerID == -1)
                {
                    //set the ThisCustomer propery
                    CustomerList.ThisCustomer = ACustomer;
                    //add the new record
                    CustomerList.Add();
                }
                //otherwise it must be an update
                else
                {
                    //find the record to update
                    CustomerList.ThisCustomer.Find(CustomerID);
                    //set the Thiscustomer property
                    CustomerList.ThisCustomer = ACustomer;
                    //update the record
                    CustomerList.Update();
                }
                //redirect back to the listpage
                Response.Redirect("CustomerList.aspx");


            }
            else
            {
            //display the error message
            lblError.Text = Error;
            }
    }
        
        
        

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entred by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtEmail.Text = ACustomer.Email;
            txtPassword.Text = ACustomer.Password;
            txtFirstName.Text = ACustomer.FirstName;
            txtSurName.Text = ACustomer.SurName;
            txtGender.Text = ACustomer.Gender;
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();
            txtPhoneNumber.Text = ACustomer.PhoneNumber;
            txtAddress.Text = ACustomer.Address;

        }
    }
}