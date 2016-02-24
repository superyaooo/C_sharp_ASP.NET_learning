<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="Calendar_2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar 02</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Pick your dates:</h1>
        <asp:Calendar ID="myCalendar" runat="server"
            DayNameFormat="Short" FirstDayOfWeek="Sunday"
            NextPrevFormat="FullMonth" SelectionMode="DayWeekMonth"
            SelectWeekText="Select Week"
            SelectMonthText="Select Month" TitleFormat="Month"
            OnSelectionChanged="SelectionChanged" />
        <h1>You selected these dates:</h1>
        <asp:Label ID="myLabel" runat="server" />
    </div>
    </form>
</body>
</html>
