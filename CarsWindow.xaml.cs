using laba2.lab1DataSetTableAdapters;
using System;
using System.Data;
using System.Windows;

namespace laba2
{
    public partial class CarsWindow : Window
    {
        carsTableAdapter carsAdapter = new carsTableAdapter();
        public CarsWindow()
        {
            InitializeComponent();
            CarsData.ItemsSource = carsAdapter.GetData();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            carsAdapter.InsertQuery(modelBox.Text, numberBox.Text, colorBox.Text);
            RefreshTable();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (CarsData.SelectedItem != null)
            {
                object id = (CarsData.SelectedItem as DataRowView).Row[0];
                carsAdapter.UpdateQuery(modelBox.Text, numberBox.Text, colorBox.Text, Convert.ToInt32(id));
                RefreshTable();
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (CarsData.SelectedItem != null)
            {
                object id = (CarsData.SelectedItem as DataRowView).Row[0];
                carsAdapter.DeleteQuery(Convert.ToInt32(id));
                RefreshTable();
            }
        }

        private void RefreshTable()
        {
            CarsData.ItemsSource = carsAdapter.GetData();
        }
    }
}
