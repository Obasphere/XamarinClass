using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpanMobile.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        //private async void btnAdder_Clicked(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync("Adder");
        //}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Adder");
        }

        private async void Bttn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Calculator");
        }
    }
}