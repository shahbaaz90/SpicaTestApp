using System.Collections.Generic;
using System.Threading.Tasks;
using SpicaTestApp.Contracts;
using SpicaTestApp.Models;

namespace SpicaTestApp.Services
{
    public class ToDoService : IToDoService
    {
        public Task<GetToDoItemsResponse> GetToDoItems()
        {
            return Task.FromResult(new GetToDoItemsResponse
            {
                ToDoItems = new List<ToDoItem> {
                new ToDoItem { Key = 0, Name = "Todo item one", Description="this is a description" },
                    new ToDoItem { Key = 1, Name = "Todo item two", Description="this is a description" },
                        new ToDoItem { Key = 2, Name = "Todo item three", Description="this is a description" },
                            new ToDoItem { Key = 3, Name = "Todo item four", Description="this is a description" }
                            }
            });
        }
    }
}
