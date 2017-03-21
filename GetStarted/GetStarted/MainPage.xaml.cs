using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GetStarted
{
    public partial class MainPage : ContentPage
    {
        public int NClicks { get; set; }
        private string _frase = "Veces has clicado el botón";
        public MainPage()
        {
            InitializeComponent();
            counterTxt.Text = "Aqui va a ir mi texto";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            NClicks++;
            counterTxt.Text = NClicks + " " + _frase;
        }
    }
}
