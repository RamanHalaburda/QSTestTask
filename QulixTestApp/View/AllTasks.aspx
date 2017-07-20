<%@ Page Title="Задачи" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllTasks.aspx.cs" Inherits="QulixTestApp.View.Task.AllTasks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">  
          
<link href="style.css" rel="stylesheet" type="text/css" />
    
    <h2>Список всех задач</h2>
    
    <table>
            <tr>
                <th class="theader">Идентфикатор</th>
                <th class="theader">Название</th>
                <th class="theader">Объем работ</th>
                <th class="theader">Начато</th>
                <th class="theader">Завершено</th>
                <th class="theader">Исполнитель</th>
                <th class="theader">Статус</th>
                <th class="theader">Опции</th>
            </tr>
            <% 
                foreach (QulixTestApp.Models.TaskModel task in GetTasks())                
                {
                    Response.Write(String.Format(@"
                        <tr>
                            <td>{0}</td>
                            <td>{1}</td>
                            <td>{2}</td>
                            <td>{3}</td>
                            <td>{4}</td>
                            <td>{5}</td>
                            <td>{6}</td>
                            <td>
                                <a href='/View/EditTask.aspx?id={0}&n={1}&am={2}&ds={3}&df={4}&p={5}&pid={6}&st={7}&stid={8}'>Изменить</a>
                                <a href='/View/DeletingTask.aspx?id={0}'>Удалить</a>

                            </td>
                        </tr>", 
                        task.TaskId, task.Name, task.Amount, task.DateS, task.DateF,
                        task.Person.FirstName + " " + task.Person.SecondName + " " + task.Person.LastName,
                        task.Person.PersonId,
                        task.Status.Name, task.Status.StatusId));
                }
            %>
        </table>

</asp:Content>
