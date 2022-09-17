using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class User:Human
    {

        private string? email;

        public string? Email
        {
            get { return email; }
            init
            {

                if (value!.Length < 7 || !value.EndsWith(".com"))
                    throw new ArgumentException("Invalid email");

                email = value;
            }
        }
        public string Phone { get; set; }

        public User(string name, string surname, string email, string phone) :base(name,surname)
        {
            Email = email;
            Phone = phone;
        }

        public override string ToString() => base.ToString() + ($@"
Email: {Email},
Phone: {Phone}");
    }
}
