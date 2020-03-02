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
    public class SimpleLvVM : INotifyPropertyChanged {
        private ObservableCollection<string> mInfos;

        public ObservableCollection<string> Infos {
            set {
                mInfos = value;
                RaisePropertyChanged(nameof(Infos));
            }
            get { return mInfos ?? (mInfos = new ObservableCollection<string>()); }
        }

        public SimpleLvVM() {
            mInfos = new ObservableCollection<string>();
            List<string> testData = DataProvider.GetInfos();
            foreach (var str in testData) {
                Infos.Add(str);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
