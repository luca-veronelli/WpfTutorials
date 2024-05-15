using System.Windows;
using Winforms = System.Windows.Forms;

namespace FolderBrowsingDialogTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

            Winforms.MessageBox.Show("");
        }
    }
}