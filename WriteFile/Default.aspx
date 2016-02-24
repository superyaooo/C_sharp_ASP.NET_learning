﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WriteFile._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    void WriteText(Object s, EventArgs e)
    {
        using (System.IO.StreamWriter streamWriter = System.IO.File.AppendText(
            MapPath("~/myText.txt")))
        {
            streamWriter.WriteLine(myText.Text);
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Writing to Text Files</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Write the following text within a text file:</p>
            <asp:TextBox ID="myText" runat="server" />
            <asp:Button ID="writeButton" Text="Write" runat="server" OnClick="WriteText" />
        </div>
    </form>
</body>
</html>
