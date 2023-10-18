using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb205_enums.Models
{
    internal class Departament
    {

        public string  Name { get; set; }
        Person[] People;
        public Departament(string name)
        {   
            Name = name;
            People = new Person[0];
        }

        public void AddPerson(Person person)
        {
            Array.Resize(ref People, People.Length+1);
            People[^1]=person;
        }
        public void AddPerson(params Person[] persons)
        {
            foreach (var item in persons)
            {
                AddPerson(item);
            }
        }

        public Person[] FilterPosition(string search)
        {
            Person[] filterPersons = new Person[0];
            for (int i = 0; i < People.Length; i++)
            {
                if(People[i].Position.ToString().ToLower()==search.ToLower())
                {
                    Array.Resize(ref filterPersons,filterPersons.Length+1);
                    filterPersons[^1]=People[i];
                }
            }
            return filterPersons;



        }
        public Person[] FilterPosition(int search)
        {
            Person[] filterPersons = new Person[0];
            for (int i = 0; i < People.Length; i++)
            {
                if ((int)People[i].Position == search)
                {
                    Array.Resize(ref filterPersons, filterPersons.Length + 1);
                    filterPersons[^1] = People[i];
                }
            }
            return filterPersons;



        }



    }
}
