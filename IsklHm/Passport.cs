using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsklHm
{
    class Passport
    {
        public string Name;
        public string numpass;
        public string date;
        
        public Passport()
        {
            Name =  "None";
            numpass = "None";
            date = "None";
        }
        public Passport(string Name,string numpass,string date) {
            this.Name = Name;
            this.numpass = numpass;
            this.date = date;
        }
        public override string ToString()
        {
            return $"Name:{Name}\nNumber passport:{numpass}\nDate:{date}";
        }
        public string NamePass
        {
            get { return Name; }

            set { Name = value; }
        }
        public string NumberPass
        {
            get { return numpass; }

            set { numpass = value; }
        }
        public string Dateofgave
        {
            get { return date; }

            set { date = value; }
        }
    }
}
