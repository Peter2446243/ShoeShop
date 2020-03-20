using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class OrderlineViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrderline
        clsOrderline AnOrderline = new clsOrderline();
        //get the data from the session object
        AnOrderline = (clsOrderline)Session["AnOrderline"];
        //display the order number for this entry
        Response.Write(AnOrderline.OrderlineNo);
    }
}