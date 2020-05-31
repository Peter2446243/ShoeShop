<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSystem.master" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click"/>
            <br />
            <asp:Label ID="lblDepartment" runat="server" Text="Department" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblJobTitle" runat="server" Text="Job Title" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtJobTitle" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblExtension" runat="server" Text="Extension" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtExtension" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPhoneNo" runat="server" Text="Phone No" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
            <br />
            &nbsp;
            <asp:TextBox ID="txtHomeAddress" runat="server" style="margin-right: 0px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPostcode" runat="server" Text="Postcode" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCity" runat="server" Text="City" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEnrolmentDate" runat="server" Text="Enrolment Date" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtEnrolmentDate" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Available"/>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click"/>
            <br />

    </asp:Content>
