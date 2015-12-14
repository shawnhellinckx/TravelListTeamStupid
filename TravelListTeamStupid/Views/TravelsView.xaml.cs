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
            TravelsViewModel.AddAll();

            list.ItemsSource = TravelsViewModel.GetTravelList();
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
    }
}