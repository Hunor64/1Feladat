using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Feladat
{
    internal class People
    {
        public string Full_Name { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public People(string sor)
        {
            string[] adatok = sor.Split(';');
            Full_Name = adatok[0] + " " + adatok[1];
            First_Name = adatok[0];
            Last_Name = adatok[1];
            ID = adatok[2];
            Age = int.Parse(adatok[2].Split('-')[1]);
        }
    }
}
