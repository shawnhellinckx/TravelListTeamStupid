using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TravelListTeamStupid.Model;

namespace TravelListTeamStupid.ViewModels
{
    public partial class AddTravelView : PhoneApplicationPage
    {
        TravelsViewModel travelsViewModel;
        DateTime date;

        public AddTravelView()
        {
            InitializeComponent();
            travelsViewModel = new TravelsViewModel();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            Travel travel = new Travel(name, date);
            Console.WriteLine(travel.Name);

            travelsViewModel.AddTravel(travel);

            //foreach(Travel t in TravelsViewModel.GetTravelList())
            //{
            //    Console.WriteLine();
            //}

            NavigationService.GoBack();
        }

        private void datePickerValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            date = (DateTime)e.NewDateTime;
        }
    }
}