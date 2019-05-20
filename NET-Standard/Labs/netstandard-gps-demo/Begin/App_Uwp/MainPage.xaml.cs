using Gps;
using Windows.ApplicationModel.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App_Uwp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            TextBlock.Text = "Getting location...";
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var geo = await GpsLocation.GetCoordinates();

            TextBlock.Text = $"You're at ({geo.latitude:N2}, {geo.longitude:N2})";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }
    }
}
