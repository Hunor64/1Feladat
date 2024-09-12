using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Feladat
{
    internal class Pet
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Age { get; set; }
        public string Owner_Id { get; set; }

        public Pet(string sor)
        {
            string[] adatok = sor.Split(';');
            Name = adatok[0];
            Breed = adatok[1];
            Age = adatok[2];
            Owner_Id = adatok[3];
        }
    }
}
