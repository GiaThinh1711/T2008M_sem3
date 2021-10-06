﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M.Pages_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }
        int index = 1;
        List<String> DanhSach = new List<String>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DanhSach.Add(inputName.Text + " - " + inputTopic.Text + " - " + inputContent.Text.Substring(0,12) + "\n" + "------------------------- ");
            txtRecieved.Text += DanhSach.Last() + "\n";
            inputTopic.Text = "";
            inputName.Text = "";
            inputContent.Text = "";
            index++;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
