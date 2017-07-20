using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QulixTestApp.Logic;
using System.Data;

namespace QulixTestApp.Models
{
    public class Repository
    {
        private DbContext context = new DbContext();


        /*
         methods for PersonModel
         */
        // person's repository
        public IEnumerable<PersonModel> Persons
        {
            get 
            {
                string query = "EXEC GetAllPersons";
                return ConvertPersons(context.CallSelectSP(query));
            }        
        }        
        
        // convert DataTable into IEnumerable
        private static IEnumerable<PersonModel> ConvertPersons(DataTable _dt)
        {
            return _dt.AsEnumerable().Select(row => new PersonModel(
                Convert.ToInt32(row["ИД"]),
                row["Фамилия"].ToString(),
                row["Имя"].ToString(),
                row["Отчество"].ToString()
            ));
        }

        // call stored procedure for editing person
        internal void EditPerson(PersonModel _person)
        {
            string query = String.Format(@"EXEC EditPerson {0},'{1}','{2}','{3}'", 
                _person.PersonId, 
                _person.FirstName, 
                _person.SecondName, 
                _person.LastName);
            context.CallUpdateSP(query);
        }
        
        // call stored procedure for deleting person
        internal void DeletePerson(PersonModel _person)
        {
            string query = String.Format(@"EXEC DeletePerson {0}", _person.PersonId);
            context.CallUpdateSP(query);
        }

        /*
         methods for TaskModel
         */

        // task's repository
        public IEnumerable<TaskModel> Tasks
        {
            get
            {
                string query = "EXEC GetAllTasks";
                return ConvertTasks(context.CallSelectSP(query));
            }
        }

        // convert DataTable into IEnumerable
        private static IEnumerable<TaskModel> ConvertTasks(DataTable _dt)
        {
            return _dt.AsEnumerable().Select(row => new TaskModel
            (
                Convert.ToInt32(row["ИД"]),
                Convert.ToString(row["Название"]),
                Convert.ToInt32(row["Объёмработ"]),
                Repository.ParseDate(row["Датаначала"].ToString()),
                Repository.ParseDate(row["Датаокончания"].ToString()),
                new StatusModel(Convert.ToInt16(row["stID"]), row["Статус"].ToString()),
                new PersonModel(Convert.ToInt32(row["pID"]), row["Фамилия"].ToString(), row["Имя"].ToString(), row["Отчество"].ToString())
            ));
        }

        // safety parse string into DateTime
        private static DateTime ParseDate(string _value)
        {
            DateTime date;
            if (DateTime.TryParse(_value, out date))
            {
                return date;
            }
            else 
            {
                return new DateTime();
            }
        }

        // call stored procedure for editing task
        internal void EditTask(TaskModel _task)
        {
            string query = String.Format(@"EXEC EditTask {0},'{1}',{2},'{3}','{4}',{5},{6}",
                _task.TaskId,
                _task.Name,
                _task.Amount,
                _task.DateS,
                _task.DateF,
                _task.Status.StatusId,
                _task.Person.PersonId);
            context.CallUpdateSP(query);
        }

        // call stored procedure for deleting task
        internal void DeleteTask(TaskModel _task)
        {
            string query = String.Format(@"EXEC DeleteTask {0}", _task.TaskId);
            context.CallUpdateSP(query);
        }
    }
}