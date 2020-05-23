using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class OrdersList : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is hte first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the orders in the collection
        ShoeClasses.clsOrdersCollection Orders = new ShoeClasses.clsOrdersCollection();
        //set the data source to the list of orders in the collection
        lstOrdersList.DataSource = Orders.OrdersList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderNo";
        //set the data field to display
        lstOrdersList.DataTextField = "OrderNo";
        //bind the data to the list
        lstOrdersList.DataBind();
    }
    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderNo;
        //if a record has been selected from the list
        if (lstOrdersList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderNo = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect ot the delete page
            Response.Redirect("DeleteOrder.aspx");
        }
        else //if no record has been deleted
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}