using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace CAFE_MENU_DISCOUNT.Core
{
    class ObservableObject : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnpropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }
    }
}
