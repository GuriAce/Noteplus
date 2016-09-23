using System;
using Xamarin.Forms;

namespace Noteplus
{
	public class App : Application
	{
		static TodoItemDatabase database;
		public static TodoItemDatabase Database {
			get {
				database = database ?? new TodoItemDatabase ();
				return database;
			}
		}

		public App ()
		{
			Resources = new ResourceDictionary ();
			Resources.Add ("primaryorange", Color.FromHex("#ff661a"));
			Resources.Add ("primaryDarkorange", Color.FromHex ("#ff661a"));

			var nav = new NavigationPage (new TodoListPage ());
			nav.BarBackgroundColor = (Color)App.Current.Resources["primaryorange"];
			nav.BarTextColor = Color.Black;


			MainPage = nav;
		}
	}
}