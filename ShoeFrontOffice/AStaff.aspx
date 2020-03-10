<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <p>
          <label>Staff ID</label>
          <input type = "text"
                 id = "txtStaffID"
                 value = "" />
        </p>
        <p>
          <label>Department</label>
          <input type = "text"
                 id = "txtDepartment"
                 value = "" />
        </p>
            <p>
            <label>Job Title</label>
          <input type = "text"
                 id = "txtJobTitle"
                 value = "" />
         </p>
            <p>
            <label>Name</label>
          <input type = "text"
                 id = "txtName"
                 value = "" />
         </p>
            <p>
            <label>Extension</label>
          <input type = "text"
                 id = "txtExtension"
                 value = "" />
         </p>
            <p>
            <label>Phone No</label>
          <input type = "text"
                 id = "txtPhoneNo"
                 value = "" />
         </p>
            <p>
            <label>Home Address</label>
          <input type = "text"
                 id = "txtHomeAddress"
                 value = "" />
         </p>
            <p>
            <label>PostCode</label>
          <input type = "text"
                 id = "txtPostCode"
                 value = "" />
         </p>
            <p>
            <label>City</label>
          <input type = "text"
                 id = "txtCity"
                 value = "" />
         </p>
            <p>
            <label>Enrolment Date</label>
          <input type = "text"
                 id = "txtEnrolmentDate"
                 value = "" />
         </p>
            <p>
            <label>Available</label>
          <input type = "checkbox"
                 id = "chkAvailable"
                 value = "" />
         </p>
            <p>
                <button type = "Submit" onclick="OK" value= "OK"> OK </button>
               <button type = "reset" value = "Cancel"> Cancel </button>
         </p>
        </div>
    </form>
</body>
</html>
