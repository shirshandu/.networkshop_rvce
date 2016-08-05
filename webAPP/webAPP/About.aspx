<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="webAPP.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        About
    </h2>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Name "></asp:Label>
        <asp:TextBox ID="name" runat="server" style="margin-left: 36px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="name" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Semester"></asp:Label>
        <asp:DropDownList ID="semester" runat="server" Height="45px" 
            style="margin-left: 24px" Width="121px">
            <asp:ListItem Selected="True" Value="1">1</asp:ListItem>
            <asp:ListItem Value="2">2</asp:ListItem>
            <asp:ListItem Value="3">3</asp:ListItem>
            <asp:ListItem Value="4">4</asp:ListItem>
            <asp:ListItem Value="5">5</asp:ListItem>
            <asp:ListItem Value="6">6</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Percentage"></asp:Label>
        <asp:TextBox ID="percentage" runat="server" style="margin-left: 8px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="save" runat="server" style="margin-left: 102px" 
            Text="Button" Width="75px" onclick="save_Click" />
    </p>
<p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
</asp:Content>
