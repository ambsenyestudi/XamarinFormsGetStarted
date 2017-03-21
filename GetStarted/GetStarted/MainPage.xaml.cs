using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GetStarted
{
    public partial class MainPage : ContentPage
    {
        public int NClicks { get; set; }
        private string _registro = "Registro";
        private string _frase = "Veces has clicado el botón";
        public string TextoAplicacion { get; set; }
        public ObservableCollection<string> Registros { get; set; }
        public MainPage()
        {
            InitializeComponent();
            counterTxt.Text = "Aqui va a ir mi texto";
            TextoAplicacion = "Pincha el botón tantas veces como quieras";
            Registros = new ObservableCollection<string>();
            Registros.Add(_registro + " " + NClicks);
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            NClicks++;
            counterTxt.Text = NClicks + " " + _frase;
            Registros.Add(_registro + " " + NClicks);
            TextoAplicacion = "Estate quieto";
        }
    }
}
