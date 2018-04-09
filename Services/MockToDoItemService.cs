using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreToDo.Models;

namespace AspNetCoreToDo.Services
{
    public class MockToDoItemService : IToDoItemService
    {
        public Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync()
        {
            IEnumerable<ToDoItem> items = new[]
            {
                new ToDoItem
                {
                    Title = "Finish laundry",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                },

                new ToDoItem
                {
                    Title = "Learn ASP.NET Core",
                    DueAt = DateTimeOffset.Now.AddMonths(1)
                }
            };

            return Task.FromResult(items);
        }

        public async Task<bool> AddItemAsync(NewToDoItem toDoItem)
        {
            throw new NotImplementedException();
        }
    }
}
