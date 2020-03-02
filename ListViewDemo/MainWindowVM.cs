using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ListViewDemo.Annotations;
using ListViewDemo.Model;

namespace ListViewDemo {
    public class MainWindowVM : INotifyPropertyChanged {

        private ObservableCollection<Person> mPersons;
        public ObservableCollection<Person> Persons {
            set {
                mPersons = value;
                RaisePropertyChanged(nameof(Persons));
            }
            get { return mPersons; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
