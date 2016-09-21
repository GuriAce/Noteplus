﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

namespace Noteplus.Android
{
	[Activity(Label = "Note+", MainLauncher = true)]
	public class MainActivity : FormsApplicationActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());
		}

	}
}

