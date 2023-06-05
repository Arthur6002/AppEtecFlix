using AppEtecFlix.Filmes;
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
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();
            btnFreeGuy.Source = ImageSource.FromResource("AppEtecFlix.Poster.FreeGuy.jpg");
            btnGatodeBotas2.Source = ImageSource.FromResource("AppEtecFlix.Poster.GatodeBotas.jpg");
            btnLuck.Source = ImageSource.FromResource("AppEtecFlix.Poster.Luck.png");
            btnCidadePerdida.Source = ImageSource.FromResource("AppEtecFlix.Poster.CidadePerdida.jpg");
        }

        private void btnFreeGuy_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new FreeGuy());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnLuck_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Luck());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnCidadePerdida_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new CidadePerdida());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnGatodeBotas2_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new GatodeBotas());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }
}
