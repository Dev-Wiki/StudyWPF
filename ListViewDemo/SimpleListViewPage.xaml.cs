using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListViewDemo {
    /// <summary>
    /// Interaction logic for SimpleListViewPage.xaml
    /// </summary>
    public partial class SimpleListViewPage : Page {
        public SimpleListViewPage() {
            InitializeComponent();
        }

        private void EnableBtn_OnClick(object sender, RoutedEventArgs e) {
            SimpleLv.IsEnabled = !SimpleLv.IsEnabled;
        }
    }
}
