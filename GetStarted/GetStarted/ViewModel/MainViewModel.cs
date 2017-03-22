using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GetStarted.ViewModel
{
    public class MainViewModel:BindableObject
    {

        private string _registro = "Registro";
        private string _frase = "Veces has clicado el botón";
        public int NClicks { get; set; }
        private string _textoAplicacion;

        public string TextoAplicacion
        {
            get { return _textoAplicacion; }
            set
            {
                _textoAplicacion = value;
                OnPropertyChanged("TextoAplicacion");
            }
        }
        private string _textInfo;

        public string TextInfo
        {
            get { return _textInfo; }
            set
            {
                _textInfo = value;
                OnPropertyChanged("TextInfo");
            }
        }

        private ICommand _clickCommand;

        public ICommand ClickCommand
        {
            get { return _clickCommand; }
            set {
                    _clickCommand = value;
                OnPropertyChanged("ClickCommand");
            }
        }



        public ObservableCollection<string> Registros { get; set; }
        public MainViewModel()
        {
            Registros = new ObservableCollection<string>();
            Registros.Add(_registro + " " + NClicks);
            TextoAplicacion = "Un simple texto";
            TextInfo="Aqui va a ir mi texto";
            ClickCommand = new Command(Click);
        }

        public void Click()
        {
            NClicks++;
            TextInfo = NClicks + " " + _frase;
            Registros.Add(_registro + " " + NClicks);
            //Esto no funciona
            TextoAplicacion = "Estate quieto";
        }
    }
}
