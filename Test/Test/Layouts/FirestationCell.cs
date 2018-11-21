using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Test
{
    class FirestationCell : ViewCell
    {
        public FirestationCell()
        {
            var nameLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));

            var ortLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                HorizontalTextAlignment = TextAlignment.End,
                HorizontalOptions =LayoutOptions.FillAndExpand
            };
            ortLabel.SetBinding(Label.TextProperty, new Binding("Adresse"));

            View = new StackLayout
            {
                Children = { nameLabel, ortLabel },
                Orientation = StackOrientation.Horizontal
            };
        }
    }
}
