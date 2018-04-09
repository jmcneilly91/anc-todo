using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreToDo.Models
{
    /// <summary>
    /// A model for a new 'ToDoItem'
    /// The properties here should always be a subset of the 'ToDoItem' model
    /// </summary>
    public class NewToDoItem
    {
        [Required]
        public string Title { get; set; }
        
        [Required]
        public DateTimeOffset DueAt { get; set; }
    }
}
