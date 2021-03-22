using System;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace BloxsploitWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly string CurrentVersion = "1.0.0";
        readonly string CondencedVersion = "1.0";

        public MainWindow()
        {
            InitializeComponent();
            Monaco.Source = new Uri(string.Format("file:///{0}/Editor/Editor.html", Directory.GetCurrentDirectory()));
        }
        private void Topbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.WindowState = WindowState.Normal;
                this.DragMove();
            }
        }

        private void Version_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Version.Text = "v" + CurrentVersion;
        }

        private void Version_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Version.Text = "v" + CondencedVersion;
        }

        private void Main_Loaded(object sender, RoutedEventArgs e)
        {
            var desktopWorkingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            this.Left = desktopWorkingArea.Right - this.Width;
            this.Top = desktopWorkingArea.Bottom - this.Height;
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.Theme != "Synapse" || Properties.Settings.Default.Theme != "SynapseLegacy" || Properties.Settings.Default.Theme != "Colorful")
            {
                this.Close();
            }
            else
            {
                this.WindowState = WindowState.Minimized;
            }
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void TitleName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.WindowState = WindowState.Normal;
                this.DragMove();
            }
        }

        private void Version_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.WindowState = WindowState.Normal;
                this.DragMove();
            }
        }

        private void ScriptHub_Click(object sender, RoutedEventArgs e)
        {
            this.ResizeMode = ResizeMode.NoResize;
            Monaco.Visibility = Visibility.Hidden;
            ScriptHubWindow.Visibility = Visibility.Visible;
            this.Height = this.MinHeight;
            this.Width = this.MinWidth;
        }

        private void ScriptHubWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (ScriptHubWindow.Visibility == Visibility.Collapsed)
            {
                this.ResizeMode = ResizeMode.CanResizeWithGrip;
                Monaco.Visibility = Visibility.Visible;
            }
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {
            this.ResizeMode = ResizeMode.NoResize;
            Monaco.Visibility = Visibility.Hidden;
            OptionsTab.Visibility = Visibility.Visible;
            this.Height = this.MinHeight;
            this.Width = this.MinWidth;
        }

        private void OptionsTab_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (OptionsTab.Visibility == Visibility.Collapsed)
            {
                this.ResizeMode = ResizeMode.CanResizeWithGrip;
                Monaco.Visibility = Visibility.Visible;
            }
        }
    }
}
