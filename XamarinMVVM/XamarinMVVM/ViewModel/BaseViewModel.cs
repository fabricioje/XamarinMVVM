using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XamarinMVVM.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string nomePropriedade = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomePropriedade));
        }

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string nomePropriedade = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage,value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(nomePropriedade);

            return true;
        }
    }
}
