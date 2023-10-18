using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb205_enums.Models
{
    internal class Book
    {
        public Book(string name, string genre, double price)
        {
            Name = name;
            Genre = genre;
            Price = price;
        }

        public string Name { get; set; }
        public string  Genre { get; set; }
        public double Price { get; set; }


    }
}
