using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Properties
{
        public class Library
    {
        // shows the Composition Relationship between book list and library class
        private List<Book> Books { get; set; }
        public Library(List<Book> tempBooks)
        {
            this.Books = tempBooks;
        }

        public void AddBook(Book tempBook)
        {
            Books.Add(tempBook);
        }

        public void RemoveBooks()
        {
            Books.Clear();
        }

        public string ListBooks()
        {
            string listing = "";

            foreach (Book book in Books)
            {
                 listing += book.BookData.Name + " by " + book.BookData.Author + " " + book.BookData.ISBN + Environment.NewLine;


            }
            return listing;
        }
    }
}
