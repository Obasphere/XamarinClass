using System;
using System.Collections.Generic;
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
        public List<Todo> AllTodo { get; set; }
        public ToDoApp()
        {
            InitializeComponent();

            var db = new SQLiteConnection(sqlconnection.SqlPath);
            db.CreateTable<Todo>();

            AllTodo = db.Table<ToDoApp>().ToList();
        }

        private async void BtnTodo_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTodoText.Text))
            {
                await DisplayAlert("Error")
            }
            var db = new SQLiteConnection(sqlconnection.SqlPath);
            db.CreateTable<Todo>();

            var todo = new Todo()
            {
                Done = false,
                TodoText = txtTodoText.Text,
                TodoTime = txtTime.Time.ToString()
            };

        }
    }
}