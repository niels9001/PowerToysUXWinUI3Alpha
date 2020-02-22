using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using PowerToysSettingsWinUI3Alpha.Views;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PowerToysSettingsWinUI3Alpha
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            NavView.SelectedItem = NavView.MenuItems[0];
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            switch (((NavigationViewItem)args.SelectedItem).Tag.ToString())
            {
                case "General": contentFrame.Navigate(typeof(General)); NavView.Header = "General"; break;
                //case "FancyZones": contentFrame.Navigate(typeof(PowerRename)); NavView.Header = "FancyZones"; break;
                case "PowerRename": contentFrame.Navigate(typeof(PowerRename)); NavView.Header = "Power Rename"; break;
                case "Shortcuts": contentFrame.Navigate(typeof(Shortcuts)); NavView.Header = "Shortcuts Guide"; break;
                case "PowerLauncher": contentFrame.Navigate(typeof(PowerLauncher)); NavView.Header = "Power Launcher"; break;
                case "Wallpaper": contentFrame.Navigate(typeof(AutomaticWallpaper)); NavView.Header = "Bing daily wallpaper"; break;
                case "NightLight": contentFrame.Navigate(typeof(NightLight)); NavView.Header = "Auto theming"; break;
            }
        }
    }
}
