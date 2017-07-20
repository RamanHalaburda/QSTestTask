<%@ Page Title="Редактирование задачи" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditTask.aspx.cs" Inherits="QulixTestApp.View.Task.EditTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<link href="style.css" rel="stylesheet" type="text/css" />
    
    <div ID="filters">
        <asp:Label  ID="Label1" runat="server" Text="Идентификатор" CssClass="lbl"></asp:Label>
        <asp:TextBox ID="tbID" runat="server" CssClass="tb" ReadOnly="true"></asp:TextBox>
            
        <br>

        <asp:Label  ID="Label2" runat="server" Text="Название" CssClass="lbl"></asp:Label>
        <asp:TextBox ID="tbName" runat="server" CssClass="tb"></asp:TextBox>    

        <br>

        <asp:Label  ID="Label3" runat="server" Text="Объём работ" CssClass="lbl"></asp:Label>
        <asp:TextBox ID="tbAmount" runat="server" CssClass="tb"></asp:TextBox>

        <br>

        <asp:Label  ID="Label4" runat="server" Text="Дата начала" CssClass="lbl"></asp:Label>
        <asp:TextBox ID="tbDateS" runat="server" CssClass="tb" placeholder="YYYY-MM-DD"></asp:TextBox>

        <br>

        <asp:Label  ID="Label5" runat="server" Text="Дата завершения" CssClass="lbl"></asp:Label>
        <asp:TextBox ID="tbDateF" runat="server" CssClass="tb" placeholder="YYYY-MM-DD"></asp:TextBox>

        <br>

        <asp:Label  ID="Label6" runat="server" Text="Статус" CssClass="lbl"></asp:Label>
        <asp:DropDownList ID="ddlStatus" runat="server"  CssClass="tb"></asp:DropDownList>

        <br>

        <asp:Label  ID="Label7" runat="server" Text="Исполнитель" CssClass="lbl"></asp:Label>
        <asp:DropDownList ID="ddlPerson" runat="server"  CssClass="tb"></asp:DropDownList>

        <br>

        <asp:Button ID="btnEdit" runat="server" Text="Применить изменения" CssClass="btnEdit" OnClick="btnEdit_Click1"/>
        <asp:Button ID="btnCancel" runat="server" Text="Отмена" CssClass="btnEdit" OnClick="btnCancel_Click"/>
    </div>

</asp:Content>
