using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApi.Model
{
    public class Todo
    {
        public int Id { get; set; } 
        public string title { get; set; }
        public string description { get; set; }
        public bool isDone { get; set; }
        public DateTime date { get; set; }
        public DateTime creationDateTime { get; set; }

    }


}
