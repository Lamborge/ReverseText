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

namespace ReverseText
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char[] input_text = B1.Text.ToCharArray();
            string res_string = "";

            for (int i = input_text.Length; i > 0; i--)
            {
                res_string += input_text[i-1];
            }

            B2.Text = res_string;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Grid.Background = new SolidColorBrush(Color.FromRgb(31, 31, 31));
            NightTheme.Foreground = new SolidColorBrush(Color.FromRgb(204, 204, 204));
            B1.Background = new SolidColorBrush(Color.FromRgb(31, 31, 31));
            B2.Background = new SolidColorBrush(Color.FromRgb(31, 31, 31));
            B1.Foreground = new SolidColorBrush(Color.FromRgb(204, 204, 204));
            B2.Foreground = new SolidColorBrush(Color.FromRgb(204, 204, 204));
            Text1.Foreground = new SolidColorBrush(Color.FromRgb(204, 204, 204));
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Grid.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            NightTheme.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            B1.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            B2.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            B1.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            B2.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            Text1.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }
    }
}
