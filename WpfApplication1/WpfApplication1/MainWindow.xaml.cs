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

namespace WpfApplication1
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "9";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            label.Text += "0";
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            label.Text = "";
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
