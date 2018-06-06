using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Testing
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    //(http://)tiendaproductospgs.azurewebsites.net/odata/productos 
	public partial class TextSpeech : ContentPage
	{
		public TextSpeech ()
		{
			InitializeComponent ();
            this.btnHablar.Clicked += BtnHablar_Clicked;
		}

        private void BtnHablar_Clicked(object sender, EventArgs e)
        {
            CrossTextToSpeech.Current.Speak(this.txtSpeech.Text);
        }
    }
}