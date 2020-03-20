<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderline.aspx.cs" Inherits="AnOrderline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="lblOrderlineNo">Orderline No:</label>
            <input type="text" id="OrderlineNo" name="OrderlineNo"/>

            <!-- <asp:Button ID="Button1" runat="server" OnClick="btnFind_Click" Text="Find" /><br/><br/> -->

            <label for="lblShoeNo">Shoe No:</label>
            <input type="text" id="ShoeNo" name="ShoeNo"/><br/><br/>

            <label for="lblQuantity">Quantity:</label>
            <input type="text" id="Quantity" name="Quantity"/><br/><br/>

            <input type="checkbox" name="Active" value="Active"/> Active<br/><br/>

            <label>[lblError]</label><br/><br/>
            <!-- <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" /> -->

            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
