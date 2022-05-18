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
        private RekenMachineState _state;
        private long _number1 = 0;
        private long _number2 = 0;
        private string _operation = "";

        public MainWindow()
        {
            InitializeComponent();
            _state = RekenMachineState.Invoer1;
        }

        private void VoerNummerIn(int nummer)
        {
            switch (_state)
            {
                case RekenMachineState.Invoer1:
                    _number1 = (_number1 * 10) + nummer;
                    display.Text = _number1.ToString();
                    break;
                case RekenMachineState.Invoer2:
                    _number2 = (_number2 * 10) + nummer;
                    display.Text = _number2.ToString();
                    break;
                case RekenMachineState.Uitkomst:
                    _number2 = nummer;
                    display.Text = _number2.ToString();
                    _state = RekenMachineState.Invoer2;
                    break;
            }

        }

        private void btn1_Click_1(object sender, RoutedEventArgs e)
        {
            VoerNummerIn(1);
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            VoerNummerIn(2);
        }

        private void btn3_Click_1(object sender, RoutedEventArgs e)
        {
            VoerNummerIn(3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            VoerNummerIn(4);
        }


        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            VoerNummerIn(5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            VoerNummerIn(6);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            VoerNummerIn(7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            VoerNummerIn(8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            VoerNummerIn(9);
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            VoerNummerIn(0);
        }

        private void btnplus_Click(object sender, RoutedEventArgs e)
        {
            _operation = "+";
            display.Text = "0";

            if (_state == RekenMachineState.Invoer1)
            {
                _state = RekenMachineState.Invoer2;
            }
            else
            {
                _state = RekenMachineState.Uitkomst;
            }
        }

        private void btnmin_Click(object sender, RoutedEventArgs e)
        {
            _operation = "-";
            display.Text = "0";

            if (_state == RekenMachineState.Invoer1)
            {
                _state = RekenMachineState.Invoer2;
            }
            else
            {
                _state = RekenMachineState.Uitkomst;
            }
        }

        private void btnkeer_Click(object sender, RoutedEventArgs e)
        {
            _operation = "x";
            display.Text = "0";


            if (_state == RekenMachineState.Invoer1)
            {
                _state = RekenMachineState.Invoer2;
            }
            else
            {
                _state = RekenMachineState.Uitkomst;
            }
        }

        private void btndelen_Click(object sender, RoutedEventArgs e)
        {
            _operation = "/";
            display.Text = "0";

            if (_state == RekenMachineState.Invoer1)
            {
                _state = RekenMachineState.Invoer2;
            }
            else
            {
                _state = RekenMachineState.Uitkomst;
            }
        }

        private void btnis_Click(object sender, RoutedEventArgs e)
        {
            switch (_operation)
            {
                case "+":
                    _number1 += _number2;
                    display.Text = _number1.ToString();
                    break;
                case "-":
                    _number1 -= _number2;
                    display.Text = _number1.ToString();
                    break;
                case "x":
                    _number1 *= _number2;
                    display.Text = _number1.ToString();
                    break;
                case "/":
                    _number1 /= _number2;
                    display.Text = _number1.ToString();
                    break;
                case "x²":
                    display.Text = Math.Pow(_number1, 2).ToString();
                    break;

            }

            if (_state == RekenMachineState.Invoer1)
            {
                _state = RekenMachineState.Invoer2;
            }
            else
            {
                _state = RekenMachineState.Uitkomst;
            }
        }

        private void btnce_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == "")
            {
                _number1 = 0;
                _state = RekenMachineState.Invoer1;
            } else
            {
                _number2 = 0;
                _state = RekenMachineState.Invoer2;
            }

            display.Text = "0";
        }

        private void btnc_Click(object sender, RoutedEventArgs e)
        {
            _number1 = 0;
            _number2 = 0;
            display.Text = "0";
            _state = RekenMachineState.Invoer1;
        }

        private void btnmacht_Click(object sender, RoutedEventArgs e)
        {
            _operation = "x²";
            display.Text = "0";
        }
    }
}
