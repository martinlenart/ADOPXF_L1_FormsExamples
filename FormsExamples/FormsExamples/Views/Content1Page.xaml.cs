using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace FormsExamples.Views
{
	public partial class Content1Page : ContentPage
	{
		public Content1Page ()
		{
			InitializeComponent ();
		}

		protected void ButtonClicked(object sender, EventArgs e) {

			((Button)sender).Text = myEntry.Text;
			myBoxView.Color = Color.Yellow;
			
		}

		async protected void ImageTapped(object sender, EventArgs e) {

			Image image = ((Image)sender);

			image.Opacity = .5;
			await Task.Delay(5000);
			image.Opacity = 1;
			myButton.Text = "Imaged Tapped";
		}

        private void myEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
			myButton.Text = myEntry.Text;
        }
    }
}
