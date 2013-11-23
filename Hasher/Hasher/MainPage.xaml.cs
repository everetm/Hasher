using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Hasher.Resources;
using System.Windows.Media;
using Windows.UI;

namespace Hasher
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void SearchTB_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchTB.Text = "";
            SolidColorBrush Brush1 = new SolidColorBrush();
            SolidColorBrush Brush2 = new SolidColorBrush();
            SolidColorBrush Brush3 = new SolidColorBrush();

            Brush1.Color = Colors.Transparent;
            Brush2.Color = Colors.White;
            Brush3.Color = Colors.White;
            SearchTB.Background = Brush1;
            SearchTB.Foreground = Brush2;
            SearchTB.BorderBrush = Brush3;

        }

        // The foreground color of the text in SearchTB is set to Blue when SearchTB
        // loses focus. Also, if SearchTB loses focus and no text is entered, the
        // text "Search" is displayed.
        private void SearchTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTB.Text == String.Empty)
            {
                SolidColorBrush Brush4 = new SolidColorBrush();
                Brush4.Color = Colors.White;
                SearchTB.Foreground = Brush4;
            }
        }
        //private void  

         
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonS_Click(object sender, RoutedEventArgs e)
        {

        }

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