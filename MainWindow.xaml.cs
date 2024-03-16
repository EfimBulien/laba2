using System.Windows;

namespace laba2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenCarsEditorWindow_Click(object sender, RoutedEventArgs e)
        {
            CarsWindow carsWindow = new CarsWindow();
            carsWindow.ShowDialog();
        }

        private void OpenDriversEditorWindow_Click(object sender, RoutedEventArgs e)
        {
            DriversWindow driversWindow = new DriversWindow();
            driversWindow.ShowDialog();
        }
    }
}
