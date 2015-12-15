using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TravelListTeamStupid.Model;
using TravelListTeamStupid.ViewModels;

namespace TravelListTeamStupid.Views
{
    public partial class CategorieView : PhoneApplicationPage
    {
        CategoriesViewModel CategoriesViewModel = new CategoriesViewModel();

        private ObservableCollection<Category> List;
        public CategorieView()
        {
            InitializeComponent();
            CategoriesViewModel.AddCategories();
            List = CategoriesViewModel.Categories;

            listCategory.ItemsSource = List;
        }

        private void listCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LongListSelector box = (LongListSelector)sender;
            Category category = (Category)box.SelectedItem;
            if (category != null)
                NavigationService.Navigate(new Uri("/Views/ItemsView.xaml?category=" + category.Id, UriKind.Relative));
            listCategory.SelectedItem = null;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }


        private TextBox txtNewCategory;
        private CustomMessageBox box;
        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            //Creating a new Page
            //Adding category to viewmodel
            box = new CustomMessageBox();
            StackPanel sp = new StackPanel() { Orientation = System.Windows.Controls.Orientation.Vertical };

            TextBlock txtDescription = new TextBlock();
            txtDescription.Text = "Geef de naam van de nieuwe categorie:";
            sp.Children.Add(txtDescription);

            txtNewCategory = new TextBox();
            sp.Children.Add(txtNewCategory);

            box.LeftButtonContent = "Voeg toe";
            box.RightButtonContent = "Cancel";
            box.Content = sp;

            box.Dismissing += Box_Dismissing;

            box.Show();
        }

        private void Box_Dismissing(object sender, DismissingEventArgs e)
        {
            if (e.Result == CustomMessageBoxResult.LeftButton)
            {
                //voeg toe
                if (txtNewCategory.Text.Length != 0)
                {
                    int id = CategoriesViewModel.GetLastIndex();
                    Category c = new Category() { Name = txtNewCategory.Text, items = new ObservableCollection<Item>(), Id = ++id };
                    CategoriesViewModel.AddCategorie(c);
                }
            }
            box.Dismiss();
        }
    }
}