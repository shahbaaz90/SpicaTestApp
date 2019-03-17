using System;
using System.Collections.Generic;
using SpicaTestApp.Models;

namespace SpicaTestApp.Contracts
{
    public class GetToDoItemsResponse
    {
        public List<ToDoItem> ToDoItems { get; set; }
        public bool IsSuccess { get; set; }
    }
}
