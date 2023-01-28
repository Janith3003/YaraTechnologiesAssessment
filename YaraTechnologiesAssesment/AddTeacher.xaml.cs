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
        DBData db = new DBData();
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (db.insertData(txt_name.Text, txt_subject.Text)==1)
                {
                    new MainWindow().Show();
                    this.Close();
                }
                else MessageBox.Show("Please Check Your Details Again");
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
