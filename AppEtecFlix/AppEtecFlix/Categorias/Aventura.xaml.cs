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
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();
            btnCapitaMarvel.Source = ImageSource.FromResource("AppEtecFlix.Poster.CapitaMarvel.jpg");
            btnCidadePerdida.Source = ImageSource.FromResource("AppEtecFlix.Poster.CidadePerdida.jpg");
            btnComoTreinaroSeuDragao.Source = ImageSource.FromResource("AppEtecFlix.Poster.ComoTreinaroSeuDragao.jpg");
            btnGatodeBotas2.Source = ImageSource.FromResource("AppEtecFlix.Poster.GatodeBotas.jpg");
        }

        private void btnCapitaMarvel_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new CapitaMarvel());
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

        private void btnComoTreinaroSeuDragao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new ComoTreinaroSeuDragao());
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