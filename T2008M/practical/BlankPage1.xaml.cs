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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M.practical
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
            var item1 = new Models.Products { Description = "des1", Name = "name1", Image = "https://i.pinimg.com/originals/c4/b4/0d/c4b40d6c726f2d88f52a9793478fd26b.png" };
            GV.Items.Add(item1);
            var item2 = new Models.Products { Description = "des2", Name = "name2", Image = "https://i.pinimg.com/originals/c4/b4/0d/c4b40d6c726f2d88f52a9793478fd26b.png" };
            GV.Items.Add(item2);
            var item3 = new Models.Products { Description = "des3", Name = "name3", Image = "https://i.pinimg.com/originals/c4/b4/0d/c4b40d6c726f2d88f52a9793478fd26b.png" };
            GV.Items.Add(item3);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (nameProduct.Text != "" && desProduct.Text != "" && imageProduct.Text != "")
            {
                var name = nameProduct.Text;
                var des = desProduct.Text;
                var image = imageProduct.Text;
                var item = new Models.Products() { Description = des, Name = name, Image = image };
                GV.Items.Add(item);
                nameProduct.Text = "";
                desProduct.Text = "";
                imageProduct.Text = "";
            }
        }
    }
}
