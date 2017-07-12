using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinMVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private string _texto;

        public string Texto
        {
            get { return _texto; }
            set
            {
                if(SetProperty(ref _texto, value));//IF para se o SetProperty for True seja executado o Command
                    BotaoCommand.ChangeCanExecute();//código para que o CanExecute do Command seja executado
            }
        }

        //propriedade Command get only
        public Command BotaoCommand { get; }

        public MainViewModel()
        {
            BotaoCommand = new Command(ExecuteBotaoCommand, CanExecuteBotaoCommand);
        }

        //metódo para execultar o Command
        static void ExecuteBotaoCommand()
        {
            //forma de executar o Display Alert, mas quebrando o MVVM
            App.Current.MainPage.DisplayAlert("Titulo", "Mensagem para o usuário", "Botão de Confirmação");
        }

        //metódo para verificar se o Command pode ser executado
        private bool CanExecuteBotaoCommand()
        {
            return string.IsNullOrWhiteSpace(Texto) == false;
        }
    }
}
