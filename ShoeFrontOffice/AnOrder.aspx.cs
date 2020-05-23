using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class AnOrder : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //capture the staff no
        string StaffNo = txtStaffNo.Text;
        //capture the customer no
        string CustomerNo = txtCustomerNo.Text;
        //capture the description
        string Description = txtDescription.Text;
        //capture the date added
        string DateAdded = txtDateAdded.Text;
        //capture the payment method
        string PaymentMethod = txtPaymentMethod.Text;
        //capture the delivery
        string Delivery = txtDelivery.Text;
        //capture the total price
        string TotalPrice = txtTotalPrice.Text;
        //variable to store any error mesages
        string Error = "";
        //validate the date
        Error = AnOrder.Valid(StaffNo, CustomerNo, DateAdded, Description, PaymentMethod, Delivery, TotalPrice);
        if (Error == "")
        {
            //capture the staff no
            AnOrder.StaffNo = StaffNo;
            //capture the customer no
            AnOrder.CustomerNo = CustomerNo;
            //capture the description
            AnOrder.Description = Description;
            //capture the date added
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the payment method
            AnOrder.PaymentMethod = PaymentMethod;
            //capture the delivery
            AnOrder.Delivery = Delivery;
            //capture the total price
            AnOrder.TotalPrice = TotalPrice;
            //capture active
            AnOrder.Active = chkActive.Checked;
            //create a ne instance of the orders collection
            clsOrdersCollection OrdersList = new clsOrdersCollection();
            //set the ThisOrder property
            OrdersList.ThisOrder = AnOrder;
            //add the new record
            OrdersList.Add();
            //redirect back to the listpage
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //variable to store the primary key
        Int32 OrderNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //find the record
        Found = AnOrder.Find(OrderNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderNo.Text = AnOrder.OrderNo;
            txtStaffNo.Text = AnOrder.StaffNo;
            txtCustomerNo.Text = AnOrder.CustomerNo;
            txtDescription.Text = AnOrder.Description;
            txtDateAdded.Text = AnOrder.DateAdded.ToString();
            txtPaymentMethod.Text = AnOrder.PaymentMethod;
            txtDelivery.Text = AnOrder.Delivery;
            txtTotalPrice.Text = AnOrder.TotalPrice;
        }
    }
}