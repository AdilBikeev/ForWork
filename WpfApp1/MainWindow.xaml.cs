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
        public List<Peoples> peoples = new List<Peoples>();//список людей, которые работали в данный день
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            peoples.Add(new Peoples("Я"));
            peoples.Add(new Peoples("Ангелина Кузнецов"));
            peoples.Add(new Peoples("Фатима Османова"));
            peoples.Add(new Peoples("Света Ягъяева"));
            peoples.Add(new Peoples("Молодой парень"));
            peoples.Add(new Peoples("Марина Семёнова"));
        }
    }
}
