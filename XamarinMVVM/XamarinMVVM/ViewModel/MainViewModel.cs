using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinMVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private string _texto;

        public string Texto
        {
            get { return _texto; }
            set { SetProperty(ref _texto, value); }
        }

        public MainViewModel()
        {
            Texto = "Mostrar texto";
        }

    }
}
