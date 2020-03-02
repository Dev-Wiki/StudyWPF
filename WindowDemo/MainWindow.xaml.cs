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
using log4net;

namespace WindowDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private ILog log = LogManager.GetLogger("Test");

        public MainWindow() {
            InitializeComponent();
            log.Error("错误", new Exception("发生了一个异常"));//错误
            log.Fatal("严重错误", new Exception("发生了一个致命错误"));//严重错误
            log.Info("信息"); //记录一般信息
            log.Debug("调试信息");//记录调试信息
            log.Warn("警告");//记录警告信息
        }
    }
}
