using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using BloxsploitWPF.Properties;

namespace BloxsploitWPF
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : UserControl
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Loadstringify_Click(object sender, RoutedEventArgs e)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(Loadstringer.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (result == true)
            {
                Loadstringer.Text = "loadstring(game:HttpGet(\"" + Loadstringer.Text + "\",true))()";
            }
            else
            {
                Loadstringer.Text = "Invalid URL.";
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void Discord_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://discord.com/invite/qhgRFQw");
        }

        private void KillRoblox_Click(object sender, RoutedEventArgs e)
        {
            foreach (Process pc in Process.GetProcessesByName("RobloxPlayerBeta"))
            {
                pc.Kill();
            }
        }

        private void TopMost_Checked(object sender, RoutedEventArgs e)
        {
            if (TopMost.IsChecked == true)
            {
                Properties.Settings.Default.OnTop = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.OnTop = false;
                Properties.Settings.Default.Save();
            }
        }

        private void AutoAttach_Checked(object sender, RoutedEventArgs e)
        {
            if (AutoAttach.IsChecked == true)
            {
                Properties.Settings.Default.AutoAttach = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.AutoAttach = false;
                Properties.Settings.Default.Save();
            }
        }

        private void AltGenLink_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Process.Start("https://altgen.club/");
        }

        private void FPSSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double currentFps = FPSSlider.Value + 60;
            FPSCount.Text = currentFps.ToString();
        }
    }
}