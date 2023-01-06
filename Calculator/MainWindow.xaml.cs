using System;
using System.Collections.Generic;
using System.Data;
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
 using static System.Math;




namespace Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string s = txt.Text;
            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }
            txt.Text = s;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txt.Text=txt.Text+"8";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "7";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "9";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "4";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "5";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "6";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "1";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "2";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "3";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + ".";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "0";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "/";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "*";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "+";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "-";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + ")";
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + "(";
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            try
            {
                string s = txt.Text;
                s = s.Substring(s.LastIndexOf('=') + 1);

                double rez = Convert.ToDouble(new DataTable().Compute(s, ""));
                txt.Text = txt.Text + "=" + $"{rez}";
            }
            catch (DivideByZeroException e)
            {
                txt.Text = e.Message;
            }
        }
    }
}
