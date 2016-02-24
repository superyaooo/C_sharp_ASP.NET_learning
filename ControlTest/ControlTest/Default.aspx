<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlTest._Default" %>

<%-- reference user control "SmartBox.ascx" --%>
<%@ Register TagPrefix="sp" TagName="SmartBox" Src="~/SmartBox.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Creating ASP.NET Web Server Controls</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <sp:SmartBox ID="nameSb" runat="server" LabelText="Name:" />
            <sp:SmartBox ID="addressSb" runat="server" LabelText="Address:" />
            <sp:SmartBox ID="countrySb" runat="server" LabelText="Country:" />
            <sp:SmartBox ID="phoneSb" runat="server" LabelText="Phone:" />

            <%--<sp:SmartBox ID="nameSb" runat="server" />
            <sp:SmartBox ID="addressSb" runat="server"  />
            <sp:SmartBox ID="countrySb" runat="server"/>
            <sp:SmartBox ID="phoneSb" runat="server" />--%>
        </div>
    </form>
</body>
</html>
