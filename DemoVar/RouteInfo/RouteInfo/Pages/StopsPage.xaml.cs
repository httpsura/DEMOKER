using RoutesInfoLibrary.Models;
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

namespace RouteInfo.Pages
{
    /// <summary>
    /// Логика взаимодействия для StopsPage.xaml
    /// </summary>
    public partial class StopsPage : Page
    {
        public StopsPage(Route selectedRoute)
        {
            InitializeComponent();
            LVStops.ItemsSource = selectedRoute.Stops.ToList();
            DataContext = selectedRoute;
        }

        private void BTBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
