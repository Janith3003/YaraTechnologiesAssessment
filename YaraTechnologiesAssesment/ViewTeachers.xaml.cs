using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;

namespace YaraTechnologiesAssesment
{
    /// <summary>
    /// Interaction logic for ViewTeachers.xaml
    /// </summary>
    public partial class ViewTeachers : Window
    {
        DBData db = new DBData();
        DataTable dt;

        public ViewTeachers()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            dt = db.getAllData();
            dgv_teachers.ItemsSource = dt.DefaultView;

        }

        private void btn_view_Click(object sender, RoutedEventArgs e)
        {
            if (txt_name.Text.Length != 0)
            {

                dt = db.getDataFromName(txt_name.Text);
                dgv_teachers.ItemsSource = dt.DefaultView;
            }
            else
            {
                dt = db.getAllData();
                dgv_teachers.ItemsSource = dt.DefaultView;
            }
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

    }
}
