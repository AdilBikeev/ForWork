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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Days> days = new List<Days>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btCalculate1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbPrivoz1.Text != "" && tbExit1.Text != "")
                {
                    int num = 0;//колл-во человек которое работало в данный день недели
                    foreach (CheckBox item in lb1.Items)
                    {
                        if (item.IsChecked == true)//елси человек работал в данный день, то...
                        {
                            num++;
                        }
                    }
                    if (num != 0) tbPrice1.Text = ((Convert.ToDouble(tbExit1.Text)*5) / num).ToString();
                    else tbPrice1.Text = "0";
                }
                else
                {
                    throw new Exception("Поля \"Привоз\" и \"Выход\" должны быть заполнены в Понедельник");
                }
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void btCalculate2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbPrivoz2.Text != "" && tbExit2.Text != "")
                {
                    int num = 0;//колл-во человек которое работало в данный день недели
                    foreach (CheckBox item in lb2.Items)
                    {
                        if (item.IsChecked == true)//елси человек работал в данный день, то...
                        {
                            num++;
                        }
                    }
                    if (num != 0) tbPrice2.Text = ((Convert.ToDouble(tbExit2.Text)*5) / num).ToString();
                    else tbPrice2.Text = "0";
                }
                else
                {
                    throw new Exception("Поля \"Привоз\" и \"Выход\" должны быть заполнены во Вторник");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btCalculate3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbPrivoz3.Text != "" && tbExit3.Text != "")
                {
                    int num = 0;//колл-во человек которое работало в данный день недели
                    foreach (CheckBox item in lb3.Items)
                    {
                        if (item.IsChecked == true)//елси человек работал в данный день, то...
                        {
                            num++;
                        }
                    }
                    if (num != 0) tbPrice3.Text = ((Convert.ToDouble(tbExit3.Text)*5) / num).ToString();
                    else tbPrice3.Text = "0";
                }
                else
                {
                    throw new Exception("Поля \"Привоз\" и \"Выход\" должны быть заполнены в Среду");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btCalculate4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbPrivoz4.Text != "" && tbExit4.Text != "")
                {
                    int num = 0;//колл-во человек которое работало в данный день недели
                    foreach (CheckBox item in lb4.Items)
                    {
                        if (item.IsChecked == true)//елси человек работал в данный день, то...
                        {
                            num++;
                        }
                    }
                    if (num != 0) tbPrice4.Text = ((Convert.ToDouble(tbExit4.Text)*5) / num).ToString();
                    else tbPrice4.Text = "0";
                }
                else
                {
                    throw new Exception("Поля \"Привоз\" и \"Выход\" должны быть заполнены в Четверг");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btCalculate5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbPrivoz5.Text != "" && tbExit5.Text != "")
                {
                    int num = 0;//колл-во человек которое работало в данный день недели
                    foreach (CheckBox item in lb5.Items)
                    {
                        if (item.IsChecked == true)//елси человек работал в данный день, то...
                        {
                            num++;
                        }
                    }
                    if (num != 0) tbPrice5.Text = ((Convert.ToDouble(tbExit5.Text)*5) / num).ToString();
                    else tbPrice5.Text = "0";
                }
                else
                {
                    throw new Exception("Поля \"Привоз\" и \"Выход\" должны быть заполнены в Пятницу");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btCalculate6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbPrivoz6.Text != "" && tbExit6.Text != "")
                {
                    int num = 0;//колл-во человек которое работало в данный день недели
                    foreach (CheckBox item in lb6.Items)
                    {
                        if (item.IsChecked == true)//елси человек работал в данный день, то...
                        {
                            num++;
                        }
                    }
                    if (num != 0) tbPrice6.Text = ((Convert.ToDouble(tbExit6.Text)*5) / num).ToString();
                    else tbPrice6.Text = "0";
                }
                else
                {
                    throw new Exception("Поля \"Привоз\" и \"Выход\" должны быть заполнены в Субботу");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double price = 0;//харплата текущего человека

            //расчитываем зп за каждый день
            btCalculate1_Click(sender, e);
            btCalculate2_Click(sender, e);
            btCalculate3_Click(sender, e);
            btCalculate4_Click(sender, e);
            btCalculate5_Click(sender, e);
            btCalculate6_Click(sender, e);

            CheckBox item =  lb1.Items[cbPeople.SelectedIndex] as CheckBox;

            if(item.IsChecked==true)
            {
                price+= double.Parse(tbPrice1.Text);
            }

            item = lb2.Items[cbPeople.SelectedIndex] as CheckBox;
            if (item.IsChecked == true)
            {
                price += double.Parse(tbPrice2.Text);
            }

            item = lb3.Items[cbPeople.SelectedIndex] as CheckBox;
            if (item.IsChecked == true)
            {
                price += double.Parse(tbPrice3.Text);
            }

            item = lb4.Items[cbPeople.SelectedIndex] as CheckBox;
            if (item.IsChecked == true)
            {
                price += double.Parse(tbPrice4.Text);
            }

            item = lb5.Items[cbPeople.SelectedIndex] as CheckBox;
            if (item.IsChecked == true)
            {
                price += double.Parse(tbPrice5.Text);
            }

            item = lb6.Items[cbPeople.SelectedIndex] as CheckBox;
            if (item.IsChecked == true)
            {
                price += double.Parse(tbPrice6.Text);
            }

            tbPrice7.Text = price.ToString() + "р.";
        }

        private void btCalculator_Click(object sender, RoutedEventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }
    }
}
