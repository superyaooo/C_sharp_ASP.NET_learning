<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RadioButtonList._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButtonList ID="favoriteColor" runat="server">
            <asp:ListItem Text="Red" Value="red" />
            <asp:ListItem Text="Blue" Value="blue" />
            <asp:ListItem Text="Green" Value="green" />
        </asp:RadioButtonList>
    </div>
    </form>
</body>
</html>
