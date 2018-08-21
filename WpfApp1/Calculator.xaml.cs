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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        private double current=0;//хранит текущее значениеы
        private string operation;//хранит знак выбранной математической операции

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //сделать проверку на наличие лишних нулей
            //if( (tbesult.Text.Length==0|| tbesult.Text.Length == 1)&& ((Button)sender).Content == )
           tbesult.Text += ((Button)sender).Content;
        }

        private void Button_Operation_Click(object sender, RoutedEventArgs e)
        {
            current = Convert.ToDouble(tbesult.Text);
            operation = ((Button)sender).Content.ToString();//запоминаем выбранную мат. операцию

            lbOperation.Items.Add(lbOperation.Items.Count+1 +") " + operation + " " + current.ToString());
            //изменить вид ListBox,чтобы можно было понять текущее общее значение
            tbesult.Text = "";
        }

        private void btEqual_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        {
                            current += Convert.ToDouble(tbesult.Text);
                            break;
                        }
                    case "-":
                        {
                            current -= Convert.ToDouble(tbesult.Text);
                            break;
                        }
                    case "*":
                        {
                            current *= Convert.ToDouble(tbesult.Text);
                            break;
                        }
                    case "/":
                        {
                            if (Convert.ToDouble(tbesult.Text) == 0) throw new Exception("Невозможно выполнить операцию деления на 0 !");
                            current /= Convert.ToDouble(tbesult.Text);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                lbOperation.Items.Add(lbOperation.Items.Count + 1 + ") " + operation + " " + tbesult.Text);
                tbesult.Text = current.ToString();
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            tbesult.Text = "";
            current = 0;
        }

        private void btReset_Click(object sender, RoutedEventArgs e)
        {
            tbesult.Text = "";
        }

        private void btDot_Click(object sender, RoutedEventArgs e)
        {
           if(tbesult.Text.IndexOf(".") == -1)tbesult.Text += ".";
        }

        private void btSigned_Click(object sender, RoutedEventArgs e)
        {
            double num = Convert.ToDouble( tbesult.Text );
            num = -num;
            tbesult.Text = num.ToString();
        }
    }
}
