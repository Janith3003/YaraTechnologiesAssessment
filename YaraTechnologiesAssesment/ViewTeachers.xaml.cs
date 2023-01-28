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
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace YaraTechnologiesAssesment
{
    /// <summary>
    /// Interaction logic for ViewTeachers.xaml
    /// </summary>
    public partial class ViewTeachers : Window
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        public ViewTeachers()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost; uid=root; password=; database=yaratechnologiesassessment");
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM teachers", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_teachers.ItemsSource = dt.DefaultView;
            con.Close();

        }

        private void btn_view_Click(object sender, RoutedEventArgs e)
        {
            if (txt_name.Text.Length != 0)
            {
                con.Open();
                da = new MySqlDataAdapter("SELECT * FROM teachers where name='" + txt_name.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_teachers.ItemsSource = dt.DefaultView;
                con.Close();
            }
            else
            {
                con.Open();
                da = new MySqlDataAdapter("SELECT * FROM teachers", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_teachers.ItemsSource = dt.DefaultView;
                con.Close();
            }
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

    }
}
