using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Test
{
    class FeuerwachenContent : ContentPage
    {

        public FeuerwachenContent()
        {
            Title = "Firestations";
            var listView = new ListView();
            listView.ItemsSource = Feuerwache.GetFireStationList();
            listView.ItemTemplate = new DataTemplate(typeof(FirestationCell));
            Content = listView;
        }
    }
}
