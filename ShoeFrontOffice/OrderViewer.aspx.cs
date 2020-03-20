using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //display the order number for this entry
        Response.Write(AnOrder.OrderNo);
    }
}