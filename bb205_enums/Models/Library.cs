namespace bb205_enums.Models
{
    internal class Library
    {
        public string Name { get; set; }

        Book[] Books;

        public Book this[int index]
        {
            get
            {
                if (index > Books.Length - 1)
                {
                    Console.WriteLine($"Menim bele bir indexim yoxdur max index {Books.Length - 1} ");
                    return null;
                }

                return Books[index];
            }
            set
            {
                Books[index] = value;
            }
        }
        public int Length
        {
            get
            {
                return Books.Length;
            }
        }
        public Library(string name)
        {
            Name = name;
            Books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[^1] = book;
        }

        public Book[] GetFilterBook(string search)
        {
            Book[] filterBooks = new Book[0];

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name.ToLower().Contains(search.ToLower()))
                {
                    Array.Resize(ref filterBooks, filterBooks.Length + 1);
                    filterBooks[^1] = Books[i];

                }
            }
            return filterBooks;

        }






    }
}
