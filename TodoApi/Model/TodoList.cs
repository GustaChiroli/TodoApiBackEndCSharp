using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApi.Model
{
    public class TodoList
    {
        public Todo[] todoList { get; set; }

        public TodoList(Todo[] todoList)
        {

        }
        //public static Todo ConvertTodoList(string line)
        //{
        //    CultureInfo culture = new CultureInfo("pt-BR");
        //    var split = line.Split(';');
        //    var title = split[0];
        //    var description = split[1];
        //    var isDone = split[2];
        //    var date = split[3];
        //    var creationDate = split[4];

        //    var isDoneToBool = Convert.ToBoolean(isDone);
        //    var dateToDateTime = Convert.ToDateTime(date, culture);
        //    var creationDateToDateTime = Convert.ToDateTime(creationDate, culture);

        //    var result = new Todo(title, description, isDoneToBool, dateToDateTime, creationDateToDateTime);
        //    return result;
        //}

    }


}
