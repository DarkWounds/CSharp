using System;
using Microsoft.Maui.Controls;

namespace PescuirtTel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        // Add this field to reference the SettingsPanel1 control
        private ContentView SettingsPanel1;

        public MainPage()
        {
            // Ensure the partial class is generated from XAML
            InitializeComponent();

            // Initialize SettingsPanel1 by finding it in the XAML
            SettingsPanel1 = this.FindByName<ContentView>("SettingsPanel1");
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;
        }

        private void OnTimerButtonClicked(object sender, EventArgs e)
        {
            // TODO: Add your timer start logic here
        }

        private void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            SettingsPanel1.IsVisible = !SettingsPanel1.IsVisible;
        }

        private void OnOptionCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            // Handle the checked change event here
        }

        private void OnResetButtonClicked(object sender, EventArgs e)
        {
            // TODO: Add your reset logic here
        }
    }
}
