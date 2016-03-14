using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using JavaneseRecipesTest.Resources;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Controls.Primitives;
using System.ComponentModel;

namespace JavaneseRecipesTest
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
 
        public MainPage()
        {
            InitializeComponent();
        }

        public class About_
        {
            public About_ () { }
            public About_(string _about)
            {
                About = _about;
            }
            public String About { get; set; }
        }

        private void StackPanel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AyamBumbuRujak.xaml", UriKind.Relative));
        }

        private void StackPanel_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HatiAmpela.xaml", UriKind.Relative));
        }

        private void StackPanel_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MasakNus.xaml", UriKind.Relative));
        }

        private void StackPanel_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DendengRagi.xaml", UriKind.Relative));
        }

        private void StackPanel_Tap_4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Krengsengan.xaml", UriKind.Relative));
        }

        private void StackPanel_Tap_5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Gudeg.xaml", UriKind.Relative));
        }

        private void StackPanel_Tap_6(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PecelMadiun.xaml", UriKind.Relative));
        }

        private void RateIcon_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MarketplaceReviewTask review = new MarketplaceReviewTask();
            review.Show();
        }

    }
}