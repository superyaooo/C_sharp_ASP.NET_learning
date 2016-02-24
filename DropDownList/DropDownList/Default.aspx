<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DropDownList._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlFavColor" runat="server">
            <asp:ListItem Text="Red" Value="red" />
            <asp:ListItem Text="Blue" Value="blue" />
            <asp:ListItem Text="Green" Value="green" />
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" 
                Font-Size="XX-Large" ForeColor="#FF3399" Text="Label" Visible="false"/>
        </p>
    </form>
</body>
</html>
