using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinToDoList.models
{
    public class ToDoItem
    {
        public int ToDoId { get; set; }
        public string ToDoText { get; set; }
        public Boolean Complete { get; set; }

        public ToDoItem(int id, string text, bool complete)
        {
            ToDoId = id;
            ToDoText = text;
            Complete = complete;
        }
    }
}