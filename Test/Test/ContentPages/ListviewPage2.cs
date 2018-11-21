using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
namespace Test
{
    class ListviewPage2 :ContentPage
    {

        public ListviewPage2()
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
            listView.ItemsSource = Feuerwache.GetFireStationList();


            var cell = new DataTemplate(typeof(TextCell));
            //cell.SetBinding(TextCell.TextProperty, new Binding("."));
            cell.SetBinding(TextCell.TextProperty, new Binding("Name"));
            cell.SetBinding(TextCell.DetailProperty, new Binding("Ort"));
            cell.SetValue(TextCell.TextColorProperty, Color.Blue);
            cell.SetValue(TextCell.DetailColorProperty, Color.Red);
            listView.ItemTemplate = cell;
            //set content
            Content = listView;
        }
    }
}
