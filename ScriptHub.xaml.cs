using System.Windows;
using System.Windows.Controls;

namespace BloxsploitWPF
{
    /// <summary>
    /// Interaction logic for ScriptHub.xaml
    /// </summary>
    public partial class ScriptHub : UserControl
    {
        public ScriptHub()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
