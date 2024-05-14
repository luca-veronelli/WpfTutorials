using System.Windows;

namespace WpfTutorial2
{
    public partial class MainWindow : Window
    {
        bool isRunning = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                tbStatus.Text = "Stopped, click to run";
                btnToggleRun.Content = "Run";
            }
            else
            {
                tbStatus.Text = "Running, click to stop";
                btnToggleRun.Content = "Stop";
            }

            isRunning = !isRunning;
        }
    }
}