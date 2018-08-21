using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Days
    {
        public List<Peoples> peoples = new List<Peoples>();//список людей, которые работали в данный день
        public string Day { get; set; }
        public Days(string day)
        {
            peoples.Add(new Peoples("Я"));
            peoples.Add(new Peoples("Ангелина Кузнецов"));
            peoples.Add(new Peoples("Фатима Османова"));
            peoples.Add(new Peoples("Света Ягъяева"));
            peoples.Add(new Peoples("Молодой парень"));
            peoples.Add(new Peoples("Марина Семёнова"));
            Day = day;
        }
    }

    public class Peoples
    {
        public string FIO { get; set; }
        public Peoples(string FIO)
        {
            this.FIO = FIO;
        }
    }
}
