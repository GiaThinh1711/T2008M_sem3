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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M.Laps2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Laps2 : Page
    {
        public Laps2()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Pages.Homexaml));
        }

        private void button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void button_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var item1 = new MenuItem() { Name = "Home", MenuPage = "home" };
            MainFrame.Navigate(typeof(Pages.Homexaml));
            menu.Items.Add(item1);
        }

        private void button_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var item2 = new MenuItem() { Name = "Person", MenuPage = "pi" };
            MainFrame.Navigate(typeof(Pages.BlankPage1));
            menu.Items.Add(item2);
        }

        private void button_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var item3 = new MenuItem() { Name = "Email", MenuPage = "mail" };
            MainFrame.Navigate(typeof(Pages_2.BlankPage1));
            menu.Items.Add(item3);

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


    }
}
