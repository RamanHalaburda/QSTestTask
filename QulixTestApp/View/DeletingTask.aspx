<%@ Page Title="Удаление задачи" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeletingTask.aspx.cs" Inherits="QulixTestApp.View.DeletingTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <h1>Запись задачи удалена</h1>
        <h4>Для продолжения нажмите "Продолжить"</h4>
        <asp:Button ID="btnContinue" runat="server" Text="Продолжить" OnClick="btnContinue_Click"></asp:Button>
    </center>
</asp:Content>
