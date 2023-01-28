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

namespace YaraTechnologiesAssesment
{
    /// <summary>
    /// Interaction logic for ViewTeachers.xaml
    /// </summary>
    public partial class ViewTeachers : Window
    {
        public ViewTeachers()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
