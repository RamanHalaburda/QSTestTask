<%@ Page Title="Возникла ошибка" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="QulixTestApp.View.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">    
    <center>
        <h1>Возникла ошибка!</h1>
        <h4>Для повтора нажмите "Начать заново"</h4>
        <asp:Button ID="btnContinue" runat="server" Text="Продолжить" OnClick="btnContinue_Click"></asp:Button>
    </center>
</asp:Content>
