<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="OrdersList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ListBox ID="lstOrdersList" runat="server"></asp:ListBox><br/>

            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />

            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" /><br/><br/>

            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>

        </div>
    </form>
</body>
</html>
