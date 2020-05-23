
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderNo" runat="server" Text="Order No" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtOrderNo" runat="server" ></asp:TextBox>

            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" /><br/><br/>

            <asp:Label ID="lblStaffNo" runat="server" Text="Staff No" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtStaffNo" runat="server" ></asp:TextBox><br/><br/>

            <asp:Label ID="lblCustomerNo" runat="server" Text="Customer No" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtCustomerNo" runat="server" ></asp:TextBox><br/><br/>

            <asp:Label ID="lblescription" runat="server" Text="Description" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtDescription" runat="server" ></asp:TextBox><br/><br/>

            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtDateAdded" runat="server" ></asp:TextBox><br/><br/>

            <asp:Label ID="lblPaymentMethod" runat="server" Text="Payment Method" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtPaymentMethod" runat="server" ></asp:TextBox><br/><br/>

            <asp:Label ID="lblDelivery" runat="server" Text="Delivery" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtDelivery" runat="server" ></asp:TextBox><br/><br/>

            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtTotalPrice" runat="server" ></asp:TextBox><br/><br/>

            <input type="checkbox" name="Active" value="Active"/> Active<br/><br/>

            <asp:Label ID="lblError" runat="server" ></asp:Label><br/><br/>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />

            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />

        </div>
    </form>
</body>
</html>
