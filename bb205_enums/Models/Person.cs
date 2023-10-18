using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb205_enums.Models
{
    internal class Person
    {
        public Person(string name, string surname, PositionEnum position)
        {
            Name = name;
            Surname = surname;
            Position = position;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public PositionEnum Position { get; set; }//Employe,Director,Boss
    }
}
