using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ListViewDemo.Annotations;

namespace ListViewDemo.Model {
    public class Person : INotifyPropertyChanged {

        private string name;
        public string Name {
            set {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
            get { return name; }
        }

        private int age;
        public int Age {
            get { return age; }
            set {
                age = value;
                RaisePropertyChanged(nameof(Age));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
