using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Test
{
    class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "Main Page";

            var menuButton1 = new Button { Text = "Firestations" };
            menuButton1.Clicked += (o, e) =>
            { Navigation.PushAsync(new FeuerwachenContent()); };

            var menuButton2 = new Button { Text = "self study" };
            menuButton2.Clicked += (o, e) =>
            { };

            var menuButton3 = new Button { Text = "other" };
            menuButton3.Clicked += (o, e) =>
            { };

            var menuButton4 = new Button { Text = "about" };
            menuButton4.Clicked += (o, e) =>
            { };
            Content = new StackLayout
            {
                Spacing = 10,
                Children = { menuButton1, menuButton2, menuButton3, menuButton4 }
            };
        }
    }
}
