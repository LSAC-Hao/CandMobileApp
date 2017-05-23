using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;

namespace CandMobileApp
{

    class CandCollapsedMenuViewModel : INotifyPropertyChanged
    {
        bool _collapsed = true;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool Collapsed
        {
            set
            {
                if (_collapsed != value)
                {
                    _collapsed = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Collapsed"));
                    }
                }
            }
            get
            {
                return _collapsed;
            }
        }
    }

}
    

