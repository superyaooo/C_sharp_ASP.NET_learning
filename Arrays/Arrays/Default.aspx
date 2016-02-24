<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Arrays._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    void Page_Load(Object s,EventArgs e)
    {
        string[] drinkList = new string[4];
        drinkList[0] = "Water";
        drinkList[1] = "Juice";
        drinkList[2] = "Soda";
        drinkList[3] = "Milk";
        drinkLabel.Text = drinkList[3];
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Arrays</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="drinkLabel" runat="server" />
    </div>
    </form>
</body>
</html>
