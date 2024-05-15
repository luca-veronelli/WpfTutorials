using Microsoft.Win32;
using System.Windows;

namespace OpenFileDialogTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# source files | *.cs";
            //fileDialog.InitialDirectory = "C:\\temp";
            fileDialog.Title = "Please, pick a C# source a file(s)";
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();
            if (success == true)
            {
                string[] path = fileDialog.FileNames;
                string[] fileName = fileDialog.SafeFileNames;

                //tbInfo.Text = path;
            }
            else
            {
                // TODO
            }
        }
    }
}