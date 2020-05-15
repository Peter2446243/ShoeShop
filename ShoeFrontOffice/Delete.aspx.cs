using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the ID of the Staff to be deleted from the session object
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteStaff();
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }

    void DeleteStaff()
    {
        //function to delete the selected record

        //create a new instance of the address book
        clsStaffCollection StaffSystem = new clsStaffCollection();
        //find the record to delete
        StaffSystem.ThisStaff.Find(StaffID);
        //delete the record
        StaffSystem.Delete();
    }
}