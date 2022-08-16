using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using XamarinToDoList.models;
using XamarinToDoList.Repositories;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinToDoList.ViewModels
{
    public class ToDoListViewModel
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        public ToDoItemRepository repository;
        public string ToDoInputValue { get; set; }

        public ToDoListViewModel()
        {
            repository = new ToDoItemRepository();
            ToDoItems = new ObservableCollection<ToDoItem>(repository.GetToDoItems());
        }

        public ICommand AddToDoCommand => new Command(AddToDoItem);

        private void AddToDoItem()
        {
            ToDoItems.Add(new ToDoItem(1, ToDoInputValue, false));
        }

        public ICommand DeleteToDoCommand => new Command(DeleteToDoItem);

        private void DeleteToDoItem(object o)
        {
            ToDoItem toDoItemToDelete = o as ToDoItem;
            ToDoItems.Remove(toDoItemToDelete);
        }
    }
}