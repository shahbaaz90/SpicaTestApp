using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using SpicaTestApp.Models;
using SpicaTestApp.Services;

namespace SpicaTestApp.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {

        private readonly IToDoService _toDoService;

        public HomeViewModel(IToDoService toDoService)
        {
            this._toDoService = toDoService;

            ToDoList = new MvxObservableCollection<ToDoItem>();
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private MvxObservableCollection<ToDoItem> _toDoList;
        public MvxObservableCollection<ToDoItem> ToDoList
        {
            get { return _toDoList; }
            set { SetProperty(ref _toDoList, value); }
        }

        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);

        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            var res = await _toDoService.GetToDoItems();

            PopulateToDoItems(res?.ToDoItems);
        }

        private void PopulateToDoItems(IEnumerable<ToDoItem> toDoItems)
        {
            if (toDoItems == null || !toDoItems.Any())
            {
                return;
            }

            ToDoList.Clear();

            foreach(var item in toDoItems)
            {
                ToDoList.Add(item);
            }
        }
    }
}
