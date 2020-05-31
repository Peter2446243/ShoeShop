<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;
            
            
            <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
        </div>
        <p>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;
            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;
            <asp:Label ID="lblSurName" runat="server" Text="Surname"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSurName" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;
            <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;<asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
&nbsp;<asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="lblRegistration" runat="server" Text="Registration" />
            
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
