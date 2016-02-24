<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CustomValidator._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Validator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            New Username:<br />
            <asp:TextBox ID="usernameTextBox" runat="server" />
            <asp:CustomValidator ID="usernameUnique" runat="server"
                ControlToValidate="usernameTextBox" OnServerValidate="CheckUniqueUserName"
                ErrorMessage="This username already taken!" />
        </p>
        <p>
            <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" 
                Text="Submit" />
        </p>
    </div>
    </form>
</body>
</html>
