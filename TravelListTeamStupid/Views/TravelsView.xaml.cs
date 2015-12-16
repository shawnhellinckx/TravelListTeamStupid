using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TravelListTeamStupid.Resources;
using TravelListTeamStupid.ViewModels;
using TravelListTeamStupid.Model;
using System.Collections.ObjectModel;
using Microsoft.Phone.Tasks;

namespace TravelListTeamStupid.Views
{
    public partial class TravelsView : PhoneApplicationPage
    {
        TravelsViewModel travelsViewModel = new TravelsViewModel();
        LongListSelector list;
        public TravelsView()
        {
            InitializeComponent();
            list = longListTravel;
            //travelsViewModel.Get();

            if (list != null)
            {
                list.ItemsSource = travelsViewModel.GetTravels();
            }
        }

        private void appButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/AddTravelView.xaml", UriKind.Relative));
        }


        private void longListTravel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/CategoriesView.xaml", UriKind.Relative));
            longListTravel.SelectedItem = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string location = (string)button.CommandParameter;

            // instantie
            BingMapsDirectionsTask bingTask = new BingMapsDirectionsTask();

            // properties
            LabeledMapLocation lml = new LabeledMapLocation(location, null);
            bingTask.End = lml;

            //show
            bingTask.Show();
        }
    }
}