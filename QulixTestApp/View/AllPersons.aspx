<%@ Page Title="Исполнители" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllPersons.aspx.cs" Inherits="QulixTestApp.View.Person.AllPersons" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<link href="style.css" rel="stylesheet" type="text/css" />
    
    <h2>Список всех исполнителей</h2>   
    <asp:Button ID="btnAdd" runat="server" Text="Добавить задачу" CssClass="btnEdit" OnClick="btnAdd_Click"/>    
    <br><br>
    <table>
        <tr>
            <th class="theader">Идентфикатор</th>
            <th class="theader">Фамилия</th>
            <th class="theader">Имя</th>
            <th class="theader">Отчество</th>
            <th class="theader">Опции</th>
        </tr>
        <% 
            foreach (QulixTestApp.Models.PersonModel person in GetPersons())                
            {
                Response.Write(String.Format(@"
                    <tr>
                        <td>{0}</td>
                        <td>{1}</td>
                        <td>{2}</td>
                        <td>{3}</td>
                        <td>
                            <a href='/View/EditPerson.aspx?id={0}&f={1}&s={2}&l={3}'>Изменить</a>
                            <a href='/View/DeletingPerson.aspx?id={0}'>Удалить</a>

                        </td>
                    </tr>", 
                    person.PersonId, person.FirstName, person.SecondName, person.LastName));
            }
        %>
    </table>

</asp:Content>
