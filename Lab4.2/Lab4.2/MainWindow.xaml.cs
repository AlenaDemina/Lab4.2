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

namespace Lab4._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(A.Text);
            double y = double.Parse(B.Text);
            double z = x + y;
            v.Content = z;
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(A.Text);
            double y = double.Parse(B.Text);
            double r = x - y;
            v.Content = r;
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(A.Text);
            double y = double.Parse(B.Text);
            double r = x * y;
            v.Content = r;
        }
        private void _4_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(A.Text);
            double y = double.Parse(B.Text);
            double r = x / y;
            v.Content = r;
        }
    }
}
