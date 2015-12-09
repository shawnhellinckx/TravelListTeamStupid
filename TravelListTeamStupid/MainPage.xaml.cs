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

namespace TravelListTeamStupid
{
    public partial class MainPage : PhoneApplicationPage
    {
        //private TravelsViewModel vm;
        //// Constructor
        public MainPage()
        {
            InitializeComponent();
            //vm = new TravelsViewModel();


            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        //protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        //{
        //    base.OnNavigatedTo(e);

        //    if (!StateUtilities.IsLaunching && this.State.ContainsKey("Travels"))
        //    {
        //        vm = (TravelsViewModel)this.State["Travels"];
        //    }
        //    else
        //    {
        //        vm.GetTravelList();
        //    }
        //    TravelsViewOnPage.DataContext = vm.TravelsList;

        //}

        //protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        //{
        //    base.OnNavigatedFrom(e);

        //    if (this.State.ContainsKey("Travels"))
        //    {
        //        this.State["Travels"] = vm;
        //    }
        //    else
        //    {
        //        this.State.Add("Travels", vm);
        //    }

        //    StateUtilities.IsLaunching = false;
        //}


        //private void AppBarSave_Click(object sender, EventArgs e)
        //{
        //    vm.SaveAccomplishments();
        //}





        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}