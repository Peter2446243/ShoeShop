<%@ Page Language="C#" MasterPageFile="~/StaffSystem.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <asp:ListBox ID="lstStaff" runat="server" Height="283px" Width="404px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <br />
            <br />
            <asp:Label ID="lblPostcode" runat="server" Text="Enter a postcode"></asp:Label>
            <br />
            <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
            <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" OnClick="btnDisplayAll_Click" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>
       </asp:Content>
