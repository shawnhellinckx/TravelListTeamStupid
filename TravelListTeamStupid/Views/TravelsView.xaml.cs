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

namespace TravelListTeamStupid.Views
{
    public partial class TravelsView : PhoneApplicationPage
    {
        public TravelsView()
        {
            InitializeComponent();
        }

        private void appButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/AddTravelView.xaml", UriKind.Relative));
        }
    }
}