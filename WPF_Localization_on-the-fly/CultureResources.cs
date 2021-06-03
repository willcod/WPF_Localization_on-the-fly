using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF_Localization_on_the_fly
{
    public class CultureResources
    {
        private static ObjectDataProvider _provider;

        public static ObjectDataProvider ResourceProvider
        {
            get {
                return _provider ?? (_provider = (ObjectDataProvider) Application.Current.FindResource("CultureRes"));
            }
        }

        public static void ChangeCulture(CultureInfo culture)
        {
            Properties.Resources.Culture = culture;
            ResourceProvider.Refresh();
        }

        public Properties.Resources GetResourceInstance()
        {
            return new Properties.Resources();
        }
    }
}