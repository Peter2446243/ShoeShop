<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="289px" Width="427px"></asp:ListBox>
        </div>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <br />
        <br />
        <asp:Label ID="lblEnterASurName" runat="server" Text="Enter a surname"></asp:Label>
&nbsp;<asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
