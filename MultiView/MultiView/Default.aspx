﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MultiView._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MultiView Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:Button ID="myButton" Text="Switch Page" runat="server" OnClick="SwitchPage" />
        </p>
        <asp:MultiView ID="myMultiView" runat="server" ActiveViewIndex="0">
            <asp:View ID="firstView" runat="server">
                <p>... contents of the first view ...</p>
            </asp:View>
            <asp:View ID="secondView" runat="server">
                <p>... contents of the second view ...</p>
            </asp:View>
        </asp:MultiView> 
    </div>
    </form>
</body>
</html>
