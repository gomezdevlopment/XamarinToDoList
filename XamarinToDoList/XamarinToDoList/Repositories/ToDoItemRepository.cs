using System;
using System.Collections.Generic;
using System.Text;
using XamarinToDoList.Interfaces;
using XamarinToDoList.models;

namespace XamarinToDoList.Repositories
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        public ICollection<ToDoItem> GetToDoItems()
        {
            var list = new List<ToDoItem>();
            list.Add(new ToDoItem(1, "mow lawn", false));
            return list;
        }

        public bool CompleteItem(int toDoID)
        {
            return false;
        }

        public bool CreateItem(string text)
        {
            return false;
        }

        public bool DeleteItem(int toDoId)
        {
            return false;
        }
    }
}