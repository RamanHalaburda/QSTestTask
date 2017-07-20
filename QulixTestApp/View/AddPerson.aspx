<%@ Page Title="Добавление исполнителя" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPerson.aspx.cs" Inherits="QulixTestApp.View.Person.AddCompany" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<link href="style.css" rel="stylesheet" type="text/css" />
    
    <div ID="filters">
        <asp:Label  ID="Label2" runat="server" Text="Фамилия" CssClass="lbl"></asp:Label>
        <asp:TextBox ID="tbF" runat="server" CssClass="tb"></asp:TextBox>    

        <br>

        <asp:Label  ID="Label3" runat="server" Text="Имя" CssClass="lbl"></asp:Label>
        <asp:TextBox ID="tbS" runat="server" CssClass="tb"></asp:TextBox>

        <br>

        <asp:Label  ID="Label4" runat="server" Text="Отчество" CssClass="lbl"></asp:Label>
        <asp:TextBox ID="tbL" runat="server" CssClass="tb"></asp:TextBox>

        <br>

        <asp:Button ID="btnEdit" runat="server" Text="Применить изменения" CssClass="btnEdit" OnClick="btnEdit_Click"/>
        <asp:Button ID="btnCancel" runat="server" Text="Отмена" CssClass="btnEdit" OnClick="btnCancel_Click"/>
    </div>

</asp:Content>
