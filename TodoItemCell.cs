using System;
using Xamarin.Forms;

namespace Noteplus
{
	public class TodoItemCell : ViewCell
	{
		public TodoItemCell ()
		{
			var label = new Label {
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.StartAndExpand
			};

			label.SetBinding (Label.TextProperty, "Name");

			var tick = new Image {
				Source = FileImageSource.FromFile ("tick.png"),
				HorizontalOptions = LayoutOptions.End
			};

			tick.SetBinding (Image.IsVisibleProperty, "Done");

			var layout = new StackLayout {
				Padding = new Thickness (20, 0, 20, 0),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Children = { label, tick }
			};

			View = layout;
		}
	}
}

