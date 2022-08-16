using System;
using System.Collections.Generic;
using System.Text;
using XamarinToDoList.models;

namespace XamarinToDoList.Interfaces
{
    public interface IToDoItemRepository
    {
        ICollection<ToDoItem> GetToDoItems();

        bool CreateItem(string text);

        bool DeleteItem(int toDoId);

        bool CompleteItem(int toDoID);
    }
}