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
        //capture the order no
        AnOrder.OrderNo = txtOrderNo.Text;
        //capture the staff no
        AnOrder.StaffNo = txtStaffNo.Text;
        //capture the customer no
        AnOrder.CustomerNo = txtCustomerNo.Text;
        //capture the description
        AnOrder.Description = txtDescription.Text;
        //capture the date added
        AnOrder.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //capture the payment method
        AnOrder.PaymentMethod = txtPaymentMethod.Text;
        //capture the delivery
        AnOrder.Delivery = txtDelivery.Text;
        //capture the total price
        AnOrder.TotalPrice = txtTotalPrice.Text;
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}