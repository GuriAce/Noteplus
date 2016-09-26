using System;
using System.Collections.Generic;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace Todo.Android
{
	public partial class Attachment : ContentPage
	{
		public Attachment()
		{
			InitializeComponent();
		}

		private async void UploadPictureButton_Clicked(object sender,
												 EventArgs e)
		{
			if (!CrossMedia.Current.IsPickPhotoSupported)
			{

				await DisplayAlert("No Upload", "Picking a photo is not supported.", "OK");
				return;
			}

			var file = await CrossMedia.Current.PickPhotoAsync();
			if (file == null)
				return;

			Image1.Source = ImageSource.FromStream(() => file.GetStream());
		}


		private async void TakePictureButton_Clicked(object sender, EventArgs e)
		{
			await CrossMedia.Current.Initialize();

			if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
			{
				await DisplayAlert("No Camera", "No Camera Available.", "OK");
				return;
			}
			var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
			{
				
				SaveToAlbum = true,
				Name = "test.jpg"
			});

			if (file == null)
				return;

				Image1.Source = ImageSource.FromStream(() => file.GetStream());
		}
	}
}
