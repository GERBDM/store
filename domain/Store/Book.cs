using System;

namespace Store
{
    public class Book
    {
        public int Id { get; }

        public string Title{ get; }
        
        public string Isbn { get; }
        
        public string Author { get; }

        public Book (int id, string isbn, string author, string title)
        {
            Id = id;
            Title = title;
            Isbn = isbn;
            Author = author;

        }

        internal static bool IsIsbn(string query)
        {
            return false;
        }
    }
}
