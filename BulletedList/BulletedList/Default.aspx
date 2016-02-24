<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BulletedList._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="favoriteTVShows" BulletStyle="Circle" DisplayMode="HyperLink" runat="server">
                <asp:ListItem Text="Doctor Who" Value="doctorwho" />
                <asp:ListItem Text="Black Books" Value="blackbooks" />
                <asp:ListItem Text="IT Crowd" Value="itcrowd" />
            </asp:BulletedList>
        </div>

        <div>
            <asp:BulletedList ID="BulletedList1" BulletStyle="Square" DisplayMode="HyperLink" runat="server">
                <asp:ListItem Text="Doctor Who" Value="doctorwho" />
                <asp:ListItem Text="Black Books" Value="blackbooks" />
                <asp:ListItem Text="IT Crowd" Value="itcrowd" />
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
