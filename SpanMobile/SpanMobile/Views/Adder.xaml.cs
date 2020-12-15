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
    public partial class Adder : ContentPage
    {
        public Adder()
        {
            InitializeComponent();
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            int number1;
            if (!int.TryParse(num1.Text, out number1))
            {
                ans.Text = "Please Enter numbers only";
                ans.TextColor = Color.Red;
                return;
            }
            int number2;
            if (!int.TryParse(num2.Text, out number2))
            {
                ans.Text = "Please Enter numbers only";
                ans.TextColor = Color.Red;
                return;
            }
            var answer = number1 + number2;
            ans.Text = $"sum of {number1 } and { number2} is {answer}";
            ans.TextColor = Color.Green;
        }
    }
}