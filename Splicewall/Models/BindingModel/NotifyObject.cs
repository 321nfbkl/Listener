using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Listener.Models.BindingModel
{
    public class NotifyObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool Set<T>(ref T oldValue, T newValue, [CallerMemberName] string propertyName = "")
        {
            if (Equals(oldValue, newValue))
                return false;
            oldValue = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
