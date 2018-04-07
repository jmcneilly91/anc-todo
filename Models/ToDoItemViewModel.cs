using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreToDo.Models
{
    public class ToDoItemViewModel
    {
        public IEnumerable<ToDoItem> Items { get; set; }
    }
}
