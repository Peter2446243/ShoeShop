using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    { //create an instance of the SurName
        ShoeClasses.clsCustomerCollection Customers = new ShoeClasses.clsCustomerCollection();
        //set the data source to the list of surnames in the collection
        lstCustomers.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomers.DateValueField = "CustomerID";
        //set the data field to display
        lstCustomers.DateTextField = "SurName";
        //bind the data to the list
        lstCustomers.DataBind();
    }
    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ACustomer.aspx");

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("DeleteCustomer.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("ACustomer.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportBySurName(txtFilter.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "SurName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportBySurName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "SurName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }
}