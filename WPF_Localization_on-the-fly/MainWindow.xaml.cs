using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WPF_Localization_on_the_fly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static bool _flag = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SwitchButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!_flag)
            {
                var culture = new CultureInfo("zh-CN");
                CultureResources.ChangeCulture(culture);
            }
            else
            {
                var culture = new CultureInfo("en-US");
                CultureResources.ChangeCulture(culture);
            }

            _flag = !_flag;
        }
    }
}
