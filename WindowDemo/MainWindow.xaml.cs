using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Common.Log;
using log4net;

namespace WindowDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private XLog log = XLog.getLog(nameof(MainWindow));
        private static string TAG = nameof(MainWindow);

        public MainWindow() {
            InitializeComponent();
        }

        private void MainWindow_OnStateChanged(object sender, EventArgs e)
        {
            log.Info("MainWindow", WindowState.ToString());
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            log.Info(TAG, $"OnInitialized");
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            log.Info(TAG, "OnActivated");
        }

        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
            log.Info(TAG, "OnDeactivated");
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            log.Info(TAG, "OnClosing");
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            log.Info(TAG, "OnClosed");
        }

        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);
            log.Info(TAG, "OnContentRendered");
        }

        protected override void OnStateChanged(EventArgs e)
        {
            base.OnStateChanged(e);
            log.Info(TAG, $"OnStateChanged:{WindowState.ToString()}");
        }

        private void ShowHintWindowBtn_OnClick(object sender, RoutedEventArgs e)
        {
            HintWindow window = new HintWindow();
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Show();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
        }

        private void MainWindow_OnUnloaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
