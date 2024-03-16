using laba2.lab1DataSetTableAdapters;
using System;
using System.Data;
using System.Windows;

namespace laba2
{
    public partial class DriversWindow : Window
    {
        driversTableAdapter driversAdapter = new driversTableAdapter();
        public DriversWindow()
        {
            InitializeComponent();
            DriversData.ItemsSource = driversAdapter.GetData();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            var current_car_id = Convert.ToInt32(car_idBox.Text);
            driversAdapter.InsertQuery(firstnameBox.Text, surnameBox.Text, middlenameBox.Text, current_car_id);
            RefreshTable();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriversData.SelectedItem != null)
            {
                var current_car_id = Convert.ToInt32(car_idBox.Text);
                object id = (DriversData.SelectedItem as DataRowView).Row[0];
                driversAdapter.UpdateQuery(firstnameBox.Text, surnameBox.Text, middlenameBox.Text, current_car_id, Convert.ToInt32(id));
                RefreshTable();
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriversData.SelectedItem != null)
            {
                object id = (DriversData.SelectedItem as DataRowView).Row[0];
                driversAdapter.DeleteQuery(Convert.ToInt32(id));
                RefreshTable();
            }
        }

        private void RefreshTable()
        {
            DriversData.ItemsSource = driversAdapter.GetData();
        }
    }
}
