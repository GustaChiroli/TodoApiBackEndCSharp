using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TodoApi.Model;
using System.Globalization;

namespace TodoApi
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fileAdress = "todoList.txt";

            using (var fileStream = new FileStream(fileAdress, FileMode.Open))
            using(var reader = new StreamReader(fileStream))
            {
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                    var Todo = ConvertStringToTodoList(line);
                }
            }
            Console.ReadLine();
        }
        public static TodoClass ConvertStringToTodoList(string line)
        {
            var split = line.Split(';');
            var title = split[0];
            var description = split[1];
            var isDone = split[2];
            var date = split[3];
            var creationDate = split[4];

            var isDoneToBool = Convert.ToBoolean(isDone);
            var dateToDateTime = Convert.ToDateTime(date);
            var creationDateToDateTime = Convert.ToDateTime(creationDate);

            var result = new TodoClass(title, description, isDoneToBool, dateToDateTime, creationDateToDateTime);
            return result;
        }
    }
   
}
