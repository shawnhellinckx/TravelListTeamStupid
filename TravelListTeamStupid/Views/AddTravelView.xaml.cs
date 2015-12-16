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
        private TravelsViewModel travelsViewModel;
        private DateTime date;
        private List<string> states = new List<string>();

        public AddTravelView()
        {
            InitializeComponent();
            travelsViewModel = new TravelsViewModel();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string name = AutoCompleteTravel.Text;
            Travel travel = new Travel(name, date);
            Console.WriteLine(travel.Name);

            travelsViewModel.AddTravel(travel);

            NavigationService.GoBack();
        }

        private void datePickerValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            date = (DateTime)e.NewDateTime;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ReadFile();

            AutoCompleteTravel.ItemsSource = states;
        }

        private void ReadFile()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader("Assets/cities.txt");
            while ((line = file.ReadLine()) != null)
            {
                states.Add(line);
                counter++;
            }

            file.Close();
        }
    }
}