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
    public partial class Drama : ContentPage
    {
        public Drama()
        {
            InitializeComponent();
            btnCoringa.Source = ImageSource.FromResource("AppEtecFlix.Poster.Coringa.jpg");
            btnGladiador.Source = ImageSource.FromResource("AppEtecFlix.Poster.Gladiador.jpg");
            btnORegresso.Source = ImageSource.FromResource("AppEtecFlix.Poster.ORegresso.jpg");
            btnSextaFeira13.Source = ImageSource.FromResource("AppEtecFlix.Poster.SextaFeira13.jpg");
        }

        private void btnCoringa_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Coringa());
            }
            catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnGladiador_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Gladiador());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnORegresso_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new ORegresso());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnSextaFeira13_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new SextaFeira13());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }
}