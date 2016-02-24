<%@ Page Title="Dorknozzle Departments" Language="C#" MasterPageFile="~/Dorknozzle.Master" 
    AutoEventWireup="true" CodeBehind="Departments.aspx.cs" Inherits="Dorknozzle.Departments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Dorknozzle Departments</h1>
    <asp:GridView id="departmentsGrid" runat="server" AllowPaging="true" PageSize="4" 
        AllowSorting="True" OnPageIndexChanging="departmentsGrid_PageIndexChanging" 
        OnSorting="departmentsGrid_Sorting" >

    </asp:GridView>
</asp:Content>
