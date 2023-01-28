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
    public partial class AddTeacher : Window
    {
        private MySqlConnection con;
        private MySqlCommand cmd;

        public AddTeacher()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost; uid=root; password=; database=yaratechnologiesassessment");
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO teachers (name, subject) VALUES('" + txt_name.Text + "', '" + txt_subject.Text + "')", con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    new MainWindow().Show();
                    this.Close();
                }
                else MessageBox.Show("Please Check Your Details Again");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
