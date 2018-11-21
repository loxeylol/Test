using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace Test
{
    class ListviewPage1 :ContentPage
    {

        public ListviewPage1()
        {
            var classNames = new[]
            {
                "test1",
                "test2",
                "hallo",
                "welt"
            };

            //what plattform is running
            var dupe = Device.RuntimePlatform;
            Console.WriteLine("Currentplatform: "+dupe);
           
            Padding = new Thickness(0, 0, 0,0);

            var listView = new ListView();
            //listView.ItemsSource = classNames;
            //listView.ItemsSource =
            //  from c in classNames
            //   where c.StartsWith("t")
            //  select c;
            listView.ItemsSource = Feuerwache.GetFireStationList();

            listView.ItemSelected += (sender, e) =>
            {

                //only if anything is selected
                if (e.SelectedItem != null)
                {
                    Console.WriteLine("Selected item: " + e.SelectedItem);
                    listView.SelectedItem = null;

                }

            };
            //set content
            Content = listView;
        }
    }
}
