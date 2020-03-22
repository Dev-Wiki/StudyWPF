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

namespace CustomUI
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomUI"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomUI;assembly=CustomUI"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误:
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:TitleBar/>
    ///
    /// </summary>
    public class TitleBar : Control
    {
        public static readonly DependencyProperty BackIconProperty = DependencyProperty.Register(nameof(BackIcon),
            typeof(BitmapImage), typeof(TitleBar), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty BackIconVisibilityProperty = DependencyProperty.Register(
            nameof(BackIconVisibility), typeof(Visibility), typeof(TitleBar),
            new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty BackIconCommandProperty = DependencyProperty.Register(
            nameof(BackIconCommand), typeof(ICommand), typeof(TitleBar),
            new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty TitleTextProperty = DependencyProperty.Register(nameof(TitleText),
            typeof(string), typeof(TitleBar), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty MenuIconProperty = DependencyProperty.Register(nameof(MenuIcon),
            typeof(BitmapImage), typeof(TitleBar), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty MenuIconVisibilityProperty = DependencyProperty.Register(
            nameof(MenuIconVisibility), typeof(Visibility), typeof(TitleBar),
            new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty MenuIconCommandProperty = DependencyProperty.Register(
            nameof(MenuIconCommand), typeof(ICommand), typeof(TitleBar),
            new FrameworkPropertyMetadata(null));

        public BitmapImage BackIcon { get; set; }
        public Visibility BackIconVisibility { get; set; }
        public ICommand BackIconCommand { get; set; }

        public string TitleText { get; set; }

        public BitmapImage MenuIcon { set; get; }
        public Visibility MenuIconVisibility { get; set; }
        public ICommand MenuIconCommand { get; set; }

        static TitleBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TitleBar), new FrameworkPropertyMetadata(typeof(TitleBar)));
        }
    }
}