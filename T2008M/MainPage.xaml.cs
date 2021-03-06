using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T2008M.Models;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2008M
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Pages.Homexaml));
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Homexaml));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.BlankPage1));
        }

        private void ad_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void menu_Loaded(object sender, RoutedEventArgs e)
        {
            var item1 = new MenuItem() { Name = "Home", MenuPage = "home" };
            var item2 = new MenuItem() { Name = "Person", MenuPage = "pi" };
            var item3 = new MenuItem() { Name = "Email", MenuPage = "mail" };
            menu.Items.Add(item1);
            menu.Items.Add(item2);
            menu.Items.Add(item3);
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
                MenuItem selecteditem = (MenuItem)menu.SelectedItem;
                switch (selecteditem.MenuPage)
                {
                    case "home": MainFrame.Navigate(typeof(Pages.Homexaml)); break;
                    case "pi": MainFrame.Navigate(typeof(Pages.BlankPage1)); break;
                    case "mail": MainFrame.Navigate(typeof(Pages_2.BlankPage1)); break;
                }
        }
    }
}
