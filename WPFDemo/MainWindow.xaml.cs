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

namespace WPFDemo
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

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "9";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "0";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Clear();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var lastIndexInText = Display.Text.Length - 1;

            if (lastIndexInText != -1)
            {
                if (Display.Text[lastIndexInText] != '+' && Display.Text[lastIndexInText] != '-')
                {
                    Display.Text += "+";
                }
            }
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            var lastIndexInText = Display.Text.Length - 1;
            if (lastIndexInText != -1)
            {
                if (Display.Text[lastIndexInText] != '+' && Display.Text[lastIndexInText] != '-')
                {
                    Display.Text += "-";
                }
            }
        }
    }
}
