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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BackgroundChanger
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }
        //Generate a random color
        static Random color = new Random();
        
        //Method to change colors
        public void ColorChanger()
        {
            mainPage.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            btnColor.Background = new SolidColorBrush(Windows.UI.Colors.Red);
        }
        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
           // Visibility Collapsed = new Visibility();
            txtBlock.Visibility = Visibility.Visible;
            //Call color changing method
            ColorChanger();
        }
    }
}
