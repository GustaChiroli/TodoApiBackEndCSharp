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
            GravarUsandoEntity();
            DeletarPrimeiraOcorrenciaPTitle("");


            Console.ReadLine();

        }

        private static void DeletarPrimeiraOcorrenciaPTitle(string title)
        {
            using (var context = new TodoContext())
            {
                context.Remove(context.Todo.First(a => a.title == "Dar banho no Tobi"));
                context.SaveChanges();
            }
        }

        private static void GravarUsandoEntity()
        {
            Todo p = new Todo();
            p.title = "Dar banho no Tobi2";
            p.description = "Levar o Tobi no PetShop para tomar banho e tosar";
            p.isDone = Convert.ToBoolean((byte)1);
            p.creationDateTime = DateTime.Now;

            using (var context = new TodoContext())
            {
                context.Remove(context.Todo.First(a => a.title == "Dar banho no Tobi"));
                context.SaveChanges();
            }

        }

        //private static void WriteOnTodoList(string fileAdress)
        //{
        //    var response = "";
        //    //meotodo para escrever no arquivo
        //    using (var inFlow = Console.OpenStandardInput())
        //    using (var fs = new FileStream(fileAdress, FileMode.Append))
        //    {
        //        var buffer = new byte[1024];
        //        //condicional que para de escrever quando digitado end
        //        while (!response.StartsWith("end"))
        //        {
        //            StreamWriter sw = new StreamWriter(fs);
        //            var readBytes = inFlow.Read(buffer, 0, 1024);
        //            response = Encoding.UTF8.GetString(buffer);
        //            //evita que end seja escrito no arquivo
        //            if (!response.StartsWith("end"))
        //            {
        //                Console.WriteLine($"resposta: {response}");
        //                fs.Write(buffer, 0, readBytes);
        //                fs.Flush();
        //            }
        //        }
        //    }
        //}

        //private static void ReadTodoList(string fileAdress)
        //{
        //    using (var fileStream = new FileStream(fileAdress, FileMode.Open))
        //    using (var reader = new StreamReader(fileStream))
        //    {
        //        while (!reader.EndOfStream)
        //        {
        //            var line = reader.ReadLine();
        //            var todo = TodoList.ConvertTodoList(line);
        //            Console.WriteLine($"titulo: {todo.title}");
        //            Console.WriteLine($"data criação: {todo.creationDateTime.ToString("dd-MM-yyyy")}");
        //            Console.WriteLine($"data todo: {todo.date.Date.ToString("dd-MM-yyyy")}");
        //            Console.WriteLine("=============================");
        //        }
        //    }
        //}
    }
   
}
