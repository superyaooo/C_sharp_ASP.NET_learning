<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidationGroups._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--Login Controls -->
        <h1>Login</h1>
        <!-- Username -->
        <p>
            Username:<br />
            <asp:TextBox ID="usernameTextBox" runat="server" />
            <asp:RequiredFieldValidator ID="usernameReq" runat="server"
                ControlToValidate="usernameTextBox" ErrorMessage="Username is required!"
                SetFocusOnError="true" ValidationGroup="Login" />
        </p>
        <!-- Password -->
        <p>
            Password:<br />
            <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="passwordReq" runat="server"
                ControlToValidate="passwordTextBox" ErrorMessage="Password is required!"
                SetFocusOnError="true" ValidationGroup="Login" />
        </p>
        <p>
            <asp:Button ID="loginButton" runat="server" Text="Log In" ValidationGroup="Login" />
        </p>
        <!-- Login Controls -->
        <h1>Register</h1>
        <!-- Username -->
        <p>
            Username:<br />
            <asp:TextBox ID="newUserNameTextBox" runat="server" />
            <asp:RequiredFieldValidator ID="newUserNameReq" runat="server"
                ControlToValidate="newUserNameTextBox" ErrorMessage="Username is required!"
                SetFocusOnError="true" ValidationGroup="Register" />
        </p>
        <!-- Password -->
        <p>
            Password:<br />
            <asp:TextBox ID="newPasswordTextBox" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="newPasswordReq" ControlToValidate="newPasswordTextBox"
                ErrorMessage="Password is required!" runat="server"
                SetFocusOnError="true" ValidationGroup="Register" />
        </p>
        <p>
            <asp:Button ID="registerButton" runat="server" Text="Register" 
                ValidationGroup="Register" />
        </p>
    </div>
    </form>
</body>
</html>
