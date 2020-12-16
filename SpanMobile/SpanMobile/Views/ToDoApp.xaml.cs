using SpanMobile.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpanMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoApp : ContentPage
    {
        public ObservableCollection<Todo> AllTodo { get; set; }
        public ToDoApp()
        {
            InitializeComponent();

            

            var db = new SQLiteConnection(SqlConnectionPath.SqlPath);
            //db.CreateTable<Todo>();
            AllTodo = new ObservableCollection<Todo>(db.Table<Todo>().ToList());
           // AllTodo = db.Table<Todo>().ToList();

            BindingContext = this;
        }

        private async void BtnTodo_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTodoText.Text))
            {
                await DisplayAlert("Error", "Enter Todoitem.", "Ok");
                return;
            }

            var db = new SQLiteConnection(SqlConnectionPath.SqlPath);
            db.CreateTable<Todo>();

            var todo = new Todo()
            {
                Done = false,
                TodoText = txtTodoText.Text,
                TodoTime = txtTime.Time.ToString()
            };

            db.Insert(todo);

            AllTodo.Add(todo);
            txtTodoText.Text = "";
            //txtTime = "";
            //AllTodo = db.Table<Todo>().ToList();

            await DisplayAlert("Success", $"Added Successfully.", "OK");
        }

        private async void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var checkbox = (CheckBox)sender;

            int id = (int)checkbox.BindingContext;

            var db = new SQLiteConnection(SqlConnectionPath.SqlPath);

            var todo = db.Get<Todo>(id);
            todo.Done = !todo.Done;

            db.Update(todo);

            await DisplayAlert("Success", $"Update Successfully", "OK");
        }
    }
}