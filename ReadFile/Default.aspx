﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" 
    Inherits="ReadFile._Default" %>
<%@ Import Namespace="System.IO" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    void ReadText(Object s, EventArgs e)
    {
        string inputString;
        resultLabel.Text = "";
        using (StreamReader streamReader=File.OpenText(MapPath("myText.txt")))
        {
            inputString = streamReader.ReadLine();
            while(inputString!=null)
            {
                resultLabel.Text += inputString + "<br />";
                inputString = streamReader.ReadLine();
            }
        }
    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reading from Text Files</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="readButton" Text="Read" runat="server" OnClick="ReadText" />
            <br />
            <asp:Label ID="resultLabel" runat="server" />
        </div>
    </form>
</body>
</html>
