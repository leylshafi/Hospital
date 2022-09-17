using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Human
    {
        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString() => ($@"
Name: {Name},
Surname: {Surname}");

    }
}
