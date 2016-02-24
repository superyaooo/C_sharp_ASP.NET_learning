<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ListBox._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="listTechnologies" runat="server" SelectionMode="Multiple">
            <asp:ListItem Text="ASP.NET" Value="aspnet" />
            <asp:ListItem Text="JSP" Value="jsp" />
            <asp:ListItem Text="PHP" Value="php" />
            <asp:ListItem Text="CGI" Value="cgi" />
            <asp:ListItem Text="ColdFusion" Value="cf" />
        </asp:ListBox>
    </div>
    </form>
</body>
</html>
