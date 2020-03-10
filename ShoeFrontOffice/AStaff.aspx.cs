using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class AStaff : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff id to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            DisplayStaff();
            //if this is not a new record
            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    private void DisplayStaff()
    {
        //create an instance of the address book
        clsStaffCollection StaffSystem = new clsStaffCollection();
        //find the record to update
        StaffSystem.ThisStaff.Find(StaffID);
        //display the data for this record
        txtStaffID.Text = StaffSystem.ThisStaff.StaffID.ToString();
        txtDepartment.Text = StaffSystem.ThisStaff.Department;
        txtJobTitle.Text = StaffSystem.ThisStaff.JobTitle;
        txtName.Text = StaffSystem.ThisStaff.Name;
        chkAvailable.Checked = StaffSystem.ThisStaff.Available;
        txtExtension.Text = StaffSystem.ThisStaff.Extension;
        txtPhoneNo.Text = StaffSystem.ThisStaff.PhoneNo;
        txtHomeAddress.Text = StaffSystem.ThisStaff.HomeAddress;
        txtPostcode.Text = StaffSystem.ThisStaff.Postcode;
        txtCity.Text = StaffSystem.ThisStaff.City;
        txtEnrolmentDate.Text = StaffSystem.ThisStaff.EnrolmentDate.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (StaffID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }

    void Add()
    {
        //create an instance of the address book
        clsStaffCollection StaffSystem = new clsStaffCollection();
        //validate the data on the web form
        String Error = StaffSystem.ThisStaff.Valid(txtEnrolmentDate.Text, txtDepartment.Text, txtJobTitle.Text, txtName.Text, txtExtension.Text, txtPhoneNo.Text, txtHomeAddress.Text, txtPostcode.Text, txtCity.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            StaffSystem.ThisStaff.EnrolmentDate = Convert.ToDateTime(txtEnrolmentDate.Text);
            StaffSystem.ThisStaff.Department = txtDepartment.Text;
            StaffSystem.ThisStaff.JobTitle = txtJobTitle.Text;
            StaffSystem.ThisStaff.Name = txtName.Text;
            StaffSystem.ThisStaff.Extension = txtExtension.Text;
            StaffSystem.ThisStaff.PhoneNo = txtPhoneNo.Text;
            StaffSystem.ThisStaff.HomeAddress = txtHomeAddress.Text;
            StaffSystem.ThisStaff.Postcode = txtPostcode.Text;
            StaffSystem.ThisStaff.City = txtCity.Text;
            StaffSystem.ThisStaff.Available = chkAvailable.Checked;
            //add the record
            StaffSystem.Add();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void Update()
    {
        //create an instance of the address book
        ShoeClasses.clsStaffCollection StaffSystem = new ShoeClasses.clsStaffCollection();
        //validate the data on the web form
        String Error = StaffSystem.ThisStaff.Valid(txtEnrolmentDate.Text, txtDepartment.Text, txtJobTitle.Text, txtName.Text, txtExtension.Text, txtPhoneNo.Text, txtHomeAddress.Text, txtPostcode.Text, txtCity.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            StaffSystem.ThisStaff.Find(StaffID);
            //get the data entered by the user
            StaffSystem.ThisStaff.EnrolmentDate = Convert.ToDateTime(txtEnrolmentDate.Text);
            StaffSystem.ThisStaff.Department = txtDepartment.Text;
            StaffSystem.ThisStaff.JobTitle = txtJobTitle.Text;
            StaffSystem.ThisStaff.Name = txtName.Text;
            StaffSystem.ThisStaff.Extension = txtExtension.Text;
            StaffSystem.ThisStaff.PhoneNo = txtPhoneNo.Text;
            StaffSystem.ThisStaff.HomeAddress = txtHomeAddress.Text;
            StaffSystem.ThisStaff.Postcode = txtPostcode.Text;
            StaffSystem.ThisStaff.City = txtCity.Text;
            StaffSystem.ThisStaff.Available = chkAvailable.Checked;
            //update the record
            StaffSystem.Update();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("Default.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtDepartment.Text = AStaff.Department;
            txtJobTitle.Text = AStaff.JobTitle;
            txtName.Text = AStaff.Name;
            txtExtension.Text = AStaff.Extension;
            txtPhoneNo.Text = AStaff.PhoneNo;
            txtHomeAddress.Text = AStaff.HomeAddress;
            txtPostcode.Text = AStaff.Postcode;
            txtCity.Text = AStaff.City;
            txtEnrolmentDate.Text = AStaff.EnrolmentDate.ToString();
        }

    }

}
