using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Documents;
using ListViewDemo.Annotations;
using ListViewDemo.Model;

namespace ListViewDemo {
    public class MultiLvVM : INotifyPropertyChanged{

        private ObservableCollection<Person> mPersons;
        public ObservableCollection<Person> Persons {
            set {
                mPersons = value;
                RaisePropertyChanged(nameof(Persons));
            }
            get { return mPersons; }
        }

        public MultiLvVM() {
            mPersons = new ObservableCollection<Person>();
            List<Person> testData = DataProvider.GetPersons();
            foreach (var person in testData) {
                Persons.Add(person);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}