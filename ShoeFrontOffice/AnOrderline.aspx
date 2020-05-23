<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderline.aspx.cs" Inherits="AnOrderline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderlineNo" runat="server" Text="Orderline No" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtOrderlineNo" runat="server" ></asp:TextBox>

            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" /><br/><br/>

            <asp:Label ID="lblShoeNo" runat="server" Text="Shoe No" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtShoeNo" runat="server" ></asp:TextBox><br/><br/>

            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtQuantity" runat="server" ></asp:TextBox><br/><br/>

            <input type="checkbox" name="Active" value="Active"/> Active<br/><br/>

            <label>[lblError]</label><br/><br/>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" /> 

            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
