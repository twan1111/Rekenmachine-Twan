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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long number1 = 0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click_1(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                display.Text = number1.ToString();
            } else
            {
                number2 = (number2 *10) + 1;
                display.Text = number2.ToString();
            }
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                display.Text = number2.ToString();
            }
        }

        private void btn3_Click_1(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                display.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                display.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                display.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                display.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                display.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                display.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                display.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 0;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 0;
                display.Text = number2.ToString();
            }
        }

        private void btnplus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            display.Text = "0";
        }

        private void btnmin_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            display.Text = "0";
        }

        private void btnkeer_Click(object sender, RoutedEventArgs e)
        {
            operation = "x";
            display.Text = "0";
        }

        private void btndelen_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            display.Text = "0";
        }

        private void btnis_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    display.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    display.Text = (number2 - number1).ToString();
                    break;
                case "x":
                    display.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    display.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void btnce_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            } else
            {
                number2 = 0;
            }

            display.Text = "0";
        }

        private void btnc_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            display.Text = "0";
        }
    }
}
