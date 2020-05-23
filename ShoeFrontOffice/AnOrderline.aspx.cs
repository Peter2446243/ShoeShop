using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class AnOrderline : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrderline
        clsOrderline AnOrderline = new clsOrderline();
        //capture the orderline no
        string OrderlineNo = txtOrderlineNo.Text;
        //capture the shoe no
        string ShoeNo = txtShoeNo.Text;
        //capture the quantity
        string Quantity = txtQuantity.Text;
        //store the order in the session object
        Session["AnOrderline"] = AnOrderline;
        //redirect to the viewer page
        Response.Redirect("OrderlineViewer.aspx");
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrderline AnOrderline = new clsOrderline();
        //variable to store the primary key
        Int32 OrderlineNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderlineNo = Convert.ToInt32(txtOrderlineNo.Text);
        //find the record
        //Found = AnOrderline.Find(OrderlineNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderlineNo.Text = AnOrderline.OrderlineNo.ToString();
            txtShoeNo.Text = AnOrderline.ShoeNo.ToString();
            txtQuantity.Text = AnOrderline.Quantity.ToString();
        }
        
    }
}