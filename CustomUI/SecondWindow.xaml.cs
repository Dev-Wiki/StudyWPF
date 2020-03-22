using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CustomUI.Annotations;

namespace CustomUI
{
    /// <summary>
    /// SecondWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SecondWindow : Window, INotifyPropertyChanged
    {

        private ICommand mBackCommand;
        public ICommand BackCommand
        {
            get
            {
                if (mBackCommand == null)
                {
                    mBackCommand = new RoutedCommand();
                    mBackCommand.Execute(new Action(Close));
                }

                return mBackCommand;
            }

            set
            {
                mBackCommand = value;
                OnPropertyRaised(nameof(BackCommand));
            }
        }
        public SecondWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyRaised([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
