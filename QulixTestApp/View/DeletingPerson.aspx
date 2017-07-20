<%@ Page Title="Удаление исполнителя" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeletingPerson.aspx.cs" Inherits="QulixTestApp.View.DeletePerson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <h1>Запись исполнителя удалена</h1>
        <h4>Для продолжения нажмите "Продолжить"</h4>
        <asp:Button ID="btnContinue" runat="server" Text="Продолжить" OnClick="btnContinue_Click"></asp:Button>
    </center>
</asp:Content>
