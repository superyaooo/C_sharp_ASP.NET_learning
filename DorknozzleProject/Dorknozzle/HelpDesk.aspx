<%@ Page Title="Dorknozzle Help Desk" Language="C#" MasterPageFile="~/Dorknozzle.Master" 
    AutoEventWireup="true" CodeBehind="HelpDesk.aspx.cs" Inherits="Dorknozzle.HelpDesk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Employee Help Desk Request</h1>
    <asp:Label ID="dbErrorMessage" ForeColor="Red" runat="server" />
    <p>
        Station Number:<br/>
        <asp:TextBox ID="stationTextBox" runat="server" CssClass="textbook" />
        <asp:RequiredFieldValidator ID="stationReq" runat="server" Display="Dynamic" 
            SetFocusOnError="true" ControlToValidate="stationTextBox" 
            ErrorMessage="<br/>Station Number cannot be empty!" />
        <asp:CompareValidator ID="stationCompare" runat="server" 
            ErrorMessage="<br/>Station Number must be a valid number!" 
            ControlToValidate="stationTextBox" Operator="DataTypeCheck" 
            Type="Integer" Display="Dynamic" SetFocusOnError="true" />
        <asp:RangeValidator ID="stationRange" runat="server" Type="Integer" 
            ControlToValidate="stationTextBox" MinimumValue="1" MaximumValue="50"
            ErrorMessage="<br/>Must be between 1 - 50!" SetFocusOnError="true" />
    </p>
    <p>
        Problem Category:<br />
        <asp:DropDownList id="categoryList" runat="server" CssClass="dropdownmenu" />
    </p>
    <p>
        Problem Subject:<br />
        <asp:DropDownList id="subjectList" runat="server" CssClass="dropdownmenu" />
    </p>
    <p>
        Problem Description:<br />
        <asp:TextBox id="descriptionTextBox" runat="server" CssClass="textbox"
            Columns="40" Rows="4" TextMode="MultiLine" />
        <asp:RequiredFieldValidator ID="descriptionReq" runat="server" 
            ControlToValidate="descriptionTextBox" ErrorMessage="<br/>Must enter description!"
            SetFocusOnError="true" Display="Dynamic" />
    </p>
    <p>
        <asp:Button id="submitButton" runat="server" CssClass="button" Text="Submit Request" 
            OnClick="submitButton_Click" />
    </p>
</asp:Content>
