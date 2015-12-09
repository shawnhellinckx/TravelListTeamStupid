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
    public partial class ItemsView : PhoneApplicationPage
    {
        private ObservableCollection<Category> Categories;
        private ObservableCollection<Item> Items;
        private Category category;
        public ItemsView()
        {
            Categories = CategoriesViewModel.GetAllCategories();
            Items = new ObservableCollection<Item>();
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            String id;

            if (NavigationContext.QueryString.TryGetValue("category", out id))
            {
                category = Categories.FirstOrDefault(c => c.Id == int.Parse(id));
                Items = category.GetItems();
                txtCategorie.Text = category.Name;

                listItems.ItemsSource = Items;
            }

        }


        private void btnAdd(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int id = (int)b.CommandParameter;
            Items.FirstOrDefault(i => i.Id == id).Count++;
        }

        private void btnMin(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int id = (int)b.CommandParameter;
            if (Items.FirstOrDefault(i => i.Id == id).Count > 0)
                Items.FirstOrDefault(i => i.Id == id).Count--;
        }


        private TextBox txtNewItem;
        private CustomMessageBox box;
        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            //Creating a new Page
            //Adding category to viewmodel
            box = new CustomMessageBox();
            StackPanel sp = new StackPanel() { Orientation = System.Windows.Controls.Orientation.Vertical };

            TextBlock txtDescription = new TextBlock();
            txtDescription.Text = "Geef de naam van het nieuwe item:";
            sp.Children.Add(txtDescription);

            txtNewItem = new TextBox();
            sp.Children.Add(txtNewItem);

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
                if (txtNewItem.Text.Length != 0)
                {
                    int id = category.GetLastIndex();
                    Item item = new Item() { Id = ++id, Count = 1, Done = false, Name = txtNewItem.Text };
                    Items.Add(item);
                }
            }
            box.Dismiss();
        }

        private void chIsCompleted_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
           
            if (checkBox.CommandParameter != null)
            {
                int id = (int)checkBox.CommandParameter;
                Items.FirstOrDefault(i => i.Id == id).Done = (bool)checkBox.IsChecked;
            }
        }
    }
}