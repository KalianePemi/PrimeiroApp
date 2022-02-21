using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimeiroApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        int count = 0;

        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = "Você clicou " + count.ToString() + "Vezes";
        }

        private void btnVerificar_Clicked(object sender, EventArgs e)
        {
            string texto = $"O nome tem {txtNome.Text.Length} Caracteres";
            DisplayAlert("Mensagem", texto, "Ok");
        }
        private async void btnLimpar_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Pergunta", "Deseja realmente limpar a tela?", "Yes", "No"))
            {
                txtNome.Text = string.Empty;
                btnCliqueAqui.Text = "Clique aqui";
            }
        }

        private void btnAdicionarDias_Clicked(object sender, EventArgs e)
        {
            DateTime dataDigitada = Convert.ToDateTime(txtData.Text);
            DateTime dataFutura = dataDigitada.AddDays(10);
            DisplayAlert("Mensagem", "A data futura é " + dataFutura.Date, "ok");
        }

        private async void btnAdicionarMeses_ClickedAsync(object sender, EventArgs e)
        {

            if (await DisplayAlert("Mensagem", "Deseja realmente somar os meses?", "yes", "no"))
            {
                DateTime dataDigitada = Convert.ToDateTime(txtData.Text);
                DateTime dataFutura = dataDigitada.AddMonths(10);
                await DisplayAlert("Mensagem", "A data futura é " + dataFutura.Date, "ok");
            }


        }
    }
}
