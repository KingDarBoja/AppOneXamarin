using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppOneXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            // InitializeComponent();
            var layout = new StackLayout { Margin = 20 };
            this.Content = layout;
            var button = new Button
            {
                Text = "El Botón",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            button.Clicked += OnButtonClicked;
            var label = new Label { Text = "Hola, presiona el botón" };
            layout.Children.Add(label);
            layout.Children.Add(button);
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert(" Alerta ", " Bienvenido ", "OK");
        }
    }
}