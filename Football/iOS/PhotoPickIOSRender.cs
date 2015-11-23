using System;
using FormsApp2.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using UIKit;
[assembly:ExportRenderer(typeof(FormsApp2.PickPhotoRenderer), typeof(FormsApp2.iOS.PhotoPickIOSRender))]
namespace FormsApp2.iOS
{



	public class PhotoPickIOSRender : PageRenderer
	{
		#region ImagePick implementation


		#endregion


	
		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);
			UIImagePickerController imagePicker = new UIImagePickerController ();

			imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;

			imagePicker.MediaTypes = UIImagePickerController.AvailableMediaTypes (UIImagePickerControllerSourceType.PhotoLibrary);
			imagePicker.FinishedPickingMedia += ImagePicker_FinishedPickingMedia;
			imagePicker.Canceled += ImagePicker_Canceled;
		
			View.Add (imagePicker.View);

		}

		void ImagePicker_Canceled (object sender, EventArgs e)
		{

			App.Current.MainPage.Navigation.PopAsync (true);

		}

		void ImagePicker_FinishedPickingMedia (object sender, UIImagePickerMediaPickedEventArgs e)
		{
			//UIImage originalImage = e.Info[UIImagePickerController.OriginalImage] as UIImage;

				
				
				
			
		}
	


		public PhotoPickIOSRender ()
		{
		}
	}



}

