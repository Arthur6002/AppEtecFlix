using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();
            btnOExorcista.Source = ImageSource.FromResource("AppEtecFlix.Poster.OExorcista.jpg");
            btnPanico.Source = ImageSource.FromResource("AppEtecFlix.Poster.Panico.jpg");
            btnSexaFeira13.Source = ImageSource.FromResource("AppEtecFlix.Poster.SextaFeira13.jpg");
            btnInvocacaodoMal.Source = ImageSource.FromResource("AppEtecFlix.Poster.InvocacaodoMal.jpg");
        }

        private void btnOExorcista_Clicked(object sender, EventArgs e)
        {

        }

        private void btnPanico_Clicked(object sender, EventArgs e)
        {

        }

        private void btnSexaFeira13_Clicked(object sender, EventArgs e)
        {

        }

        private void btnInvocacaodoMal_Clicked(object sender, EventArgs e)
        {

        }
    }
}