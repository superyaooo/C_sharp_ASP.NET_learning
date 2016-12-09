<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UsingStyles._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Testing CSS</title>
    <%-- link the stylesheet to project --%>
    <link rel="Stylesheet" type="text/css" href="Styles.css" />
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <p class="title">
            Please select a product:
        </p>
        <p>
            <asp:DropDownList ID="productsList" CssClass="dropdownmenu" runat="server">
                <asp:ListItem Text="Shirt" Selected="True" />
                <asp:ListItem Text="Hat" />
                <asp:ListItem Text="Pants" />
                <asp:ListItem Text="Socks" />
            </asp:DropDownList>
        </p>
        <p>
            <asp:TextBox ID="quantityTextBox" CssClass="textbox" runat="server" />
        </p>
        <p>
            <asp:Button ID="addToCartButton" CssClass="button" Text="Add To Cart" runat="server" OnClick="addToCartButton_Click" />
        </p>
        
        <asp:Label AssociatedControlID="lstCart" runat="server" ID="lblCart" Text="Shopping Cart:" Visible="false"  />
        <asp:BulletedList id="lstCart" runat="server" />
    </div>
    </form>
</body>
</html>
