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

namespace PowerToysSettingsWinUI3Alpha.Views
{
    public sealed partial class NightLight : Page
    {
        public NightLight()
        {
            this.InitializeComponent();
        }

        private void ScheduleSwitch_Toggled(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            if ((sender as ToggleSwitch).IsOn)
            {
                TimePanel.Visibility = Visibility.Visible;
            }
            else
            {
                TimePanel.Visibility = Visibility.Collapsed;
            }
        }
        
        private void CustomRadioButton_Checked(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            CustomTimePanel.Visibility = Visibility.Visible;
        }

        private void CustomRadioButton_Unchecked(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            CustomTimePanel.Visibility = Visibility.Collapsed;
        }

        private void Page_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            ScheduleSwitch.Toggled += ScheduleSwitch_Toggled;
        }
    }
}
