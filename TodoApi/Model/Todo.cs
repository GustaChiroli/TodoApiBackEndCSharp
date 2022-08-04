using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApi.Model
{
    public class TodoClass
    {
        public string title { get; set; }
        public string description { get; set; }
        public bool isDone { get; set; }
        public DateTime date { get; set; }
        public DateTime creationDateTime { get; set; }

        public TodoClass(string title, string description, bool isDone, DateTime date, DateTime creationDateTime)
        {
            this.title = title;
            this.description = description;
            this.isDone = isDone;
            this.date = date;
            this.creationDateTime = creationDateTime;
        }
    }


}
