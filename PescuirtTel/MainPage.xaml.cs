using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace C_Start
{
    public partial class MainPage : ContentPage
    {
        DispatcherTimer[] timers = new DispatcherTimer[4];
        int[] seconds = new int[4];
        ObservableCollection<string>[] options = new ObservableCollection<string>[4];

        public MainPage()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                timers[i] = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
                int idx = i;
                timers[i].Tick += (s, e) => UpdateTimerLabel(idx);
                options[i] = new ObservableCollection<string>();
            }

            OptionsList1.ItemsSource = options[0];
            // Repeat for OptionsList2, OptionsList3, OptionsList4
        }

        void OnTimerButtonClicked(object sender, EventArgs e)
        {
            int idx = GetButtonIndex(sender);
            if (!timers[idx].IsRunning)
            {
                timers[idx].Start();
                GetTimerButton(idx).BackgroundColor = Colors.LightGreen;
            }
            else
            {
                timers[idx].Stop();
                GetTimerButton(idx).BackgroundColor = Colors.LightGray;
            }
        }

        void OnResetButtonClicked(object sender, EventArgs e)
        {
            int idx = GetButtonIndex(sender);
            timers[idx].Stop();
            seconds[idx] = 0;
            UpdateTimerLabel(idx);
            GetTimerButton(idx).BackgroundColor = Colors.LightGray;
        }

        void UpdateTimerLabel(int idx)
        {
            seconds[idx]++;
            var ts = TimeSpan.FromSeconds(seconds[idx]);
            GetTimerLabel(idx).Text = $"{ts.Minutes:D2}:{ts.Seconds:D2}";
        }

        void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            int idx = GetButtonIndex(sender);
            var panel = GetSettingsPanel(idx);
            panel.IsVisible = !panel.IsVisible;
        }

        void OnOptionCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            int idx = GetCheckBoxIndex(sender);
            var option = GetOptionName(sender);
            if (e.Value)
            {
                if (!options[idx].Contains(option))
                    options[idx].Add(option);
            }
            else
            {
                options[idx].Remove(option);
            }
        }

        // Helper methods to map controls to indices
        int GetButtonIndex(object sender)
        {
            if (sender == TimerButton1 || sender == ResetButton1 || sender == SettingsButton1) return 0;
            // Repeat for TimerButton2, etc.
            return 0; // Default
        }
        int GetCheckBoxIndex(object sender)
        {
            if (sender == BoilesCheck1 || sender == NadaCheck1 || sender == UsturoiCheck1) return 0;
            // Repeat for other panels
            return 0;
        }
        string GetOptionName(object sender)
        {
            if (sender == BoilesCheck1) return "Boiles";
            if (sender == NadaCheck1) return "Nada";
            if (sender == UsturoiCheck1) return "Usturoi";
            return "";
        }
        Button GetTimerButton(int idx) => idx switch { 0 => TimerButton1, /* 1 => TimerButton2, ... */ _ => TimerButton1 };
        Label GetTimerLabel(int idx) => idx switch { 0 => TimerLabel1, /* 1 => TimerLabel2, ... */ _ => TimerLabel1 };
        StackLayout GetSettingsPanel(int idx) => idx switch { 0 => SettingsPanel1, /* 1 => SettingsPanel2, ... */ _ => SettingsPanel1 };
    }
}