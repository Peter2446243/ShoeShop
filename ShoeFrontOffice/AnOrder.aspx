
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <label for="lblOrderNo">Order No:</label>
            <input type="text" id="OrderNo" name="OrderNo"/>

            <asp:Button ID="Button1" runat="server" OnClick="btnFind_Click" Text="Find" /><br/><br/>

            <label for="lblStaffNo">Staff No:</label>
            <input type="text" id="StaffNo" name="StaffNo"/><br/><br/>

            <label for="lblCustomerNo">Customer No:</label>
            <input type="text" id="CustomerNo" name="CustomerNo"/><br/><br/>

            <label for="lblDescription">Description:</label>
            <input type="text" id="Description" name="Description"/><br/><br/>

            <label for="lblDateAdded">Date Added:</label>
            <input type="text" id="DateAdded" name="DateAdded"/><br/><br/>

            <label for="lblPaymentMethod">Payment Method:</label>
            <input type="text" id="PaymentMethod" name="PaymentMethod"/><br/><br/>

            <label for="lblDelivery">Delivery:</label>
            <input type="text" id="Delivery" name="Delivery"/><br/><br/>

            <label for="lblTotalPrice">Total Price:</label>
            <input type="text" id="TotalPrice" name="TotalPrice"/><br/><br/>

            <input type="checkbox" name="Active" value="Active"/> Active<br/><br/>

            <label>[lblError]</label><br/><br/>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />

            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />

        </div>
    </form>
</body>
</html>
