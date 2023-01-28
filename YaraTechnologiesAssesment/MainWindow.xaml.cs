using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YaraTechnologiesAssesment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_add(object sender, RoutedEventArgs e)
        {
            AddTeacher obj = new AddTeacher();
            obj.Show();
            this.Close();
        }

        private void btn_view(object sender, RoutedEventArgs e)
        {

            ViewTeachers obj = new ViewTeachers();
            obj.Show();
            this.Close();
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
