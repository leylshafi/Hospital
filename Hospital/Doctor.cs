using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Doctor:Human
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public List<string> Worktime=new List<string>();
        public Doctor(int id, string name, string surname,int year) : base(name, surname)
        {
            Id = id;
            Year=year;
            Worktime.Add("9:00-11:00");
            Worktime.Add("12:00-14:00");
            Worktime.Add("15:00-17:00");
        }

        public override string ToString() => ($"Id: {Id}" +
            $"")+base.ToString() + ($@"
Year: {Year}");
    }
}
