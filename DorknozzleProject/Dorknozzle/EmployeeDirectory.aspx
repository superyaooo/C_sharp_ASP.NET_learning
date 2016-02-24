<%@ Page Title="Dorknozzle Employee Directory" Language="C#" MasterPageFile="~/Dorknozzle.Master" AutoEventWireup="true" 
    CodeBehind="EmployeeDirectory.aspx.cs" Inherits="Dorknozzle.WebForm2"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Employee Directory</h1>
    <%--<asp:Repeater ID="employeesRepeater" runat="server">--%>
    <asp:DataList ID="employeesList" runat="server" 
        OnItemCommand="employeesList_ItemCommand" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <ItemTemplate>
            <%--Employee ID:
            <strong><%# Eval("EmployeeID") %></strong><br/>--%>
            <asp:Literal ID="extraDetailsLiteral" runat="server"
                EnableViewState="false" />
            Name: <strong><%# Eval("Name") %></strong><br />
            Username: <strong><%# Eval("Username") %></strong><br />
            <asp:LinkButton ID="detailsButton" runat="server"
                Text=<%#"View more details about "+Eval("Name") %>
                CommandName="MoreDetailsPlease"
                CommandArgument=<%#Eval("EmployeeID") %> />
            <br />
            <asp:LinkButton ID="editButton" runat="server"
                Text=<%#"Edit employee "+Eval("Name") %>
                CommandName="EditItem"
                CommandArgument=<%#Eval("EmployeeID") %> />
        </ItemTemplate>
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <%--<SeparatorTemplate>
            <hr />
        </SeparatorTemplate>--%>
        <AlternatingItemStyle BackColor="#F7F7F7" />
        <EditItemTemplate>
            Name: <asp:TextBox ID="nameTextBox" runat="server"
                Text=<%#Eval("Name") %> /><br />
            Username: <asp:TextBox ID="usernameTextBox" runat="server"
                Text=<%#Eval("Username") %> /><br />
            <asp:LinkButton ID="updateButton" runat="server"
                Text="Update Item" CommandName="UpdateItem"
                CommandArgument=<%#Eval("EmployeeID") %> />
            or
            <asp:LinkButton ID="cancelButton" runat="server"
                Text="Cancel Editing" CommandName="CancelEditing"
                CommandArgument=<%#Eval("EmployeeID") %> />
        </EditItemTemplate>
    </asp:DataList>
    <%--</asp:Repeater>--%>
</asp:Content>
