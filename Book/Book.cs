using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        public string Name { get; set; }
        public string Autor {  get; set; }
        public string Genre { get; set; }
        public int YearOfPublishing { get; set; }

        public Book(string name,string autor,string genre,int yearofpublishing)
        {
            Name = name;
            Autor = autor;
            Genre = genre;
            YearOfPublishing = yearofpublishing;
        }
        public override string ToString()
        {
            return $"Наименование {Name} Автор {Autor} Жанр {Genre} Год выпуска {YearOfPublishing}";
        }
    }
}
