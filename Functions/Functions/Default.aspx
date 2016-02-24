<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Functions._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    string getName()
    {
        return "Jone Doe";
    }
    
    void Page_Load(Object s,EventArgs e)
    {
        messageLabel.Text = getName();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET Functions</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="messageLabel" runat="server" />
    </div>
    </form>
</body>
</html>
