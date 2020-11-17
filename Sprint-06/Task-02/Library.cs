using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_02
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
        }
    }

    public class Library : IEnumerable<Book> 
    {
        public IEnumerable<Book> Books { get; set; }
        public Predicate<Book> Filter { get; set; }

        public Library(IEnumerable<Book> books)
        {
            this.Books = books;
            Filter = Book => true;
        }

        IEnumerator<Book> GetEnumerator() 
        {
            return new MyEnumerator(Books, Filter);
        }

        IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public sealed class MyEnumerator : IEnumerator<Book>
    {
        private IEnumerator<Book> Books;
        private readonly Predicate<Book> Filter;

        private int curIndex;

        private Book curBook;
        public MyEnumerator(IEnumerable<Book> Books, Predicate<Book> Filter)
        {
            if (Books == null)
                throw new ArgumentNullException();
            this.Books = Books.GetEnumerator();
            this.Filter = Filter;
        }

        public Book Current { get { return Books.Current; } }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
            Books.Dispose();
        }

        public bool MoveNext()
        {
            while (Books.MoveNext())
            {
                if (Filter == null || Filter(Books.Current))
                {
                    return true;
                }
            }
            return false;
        }

        public void Reset()
        {
            Books.Reset();
        }
    }

    public class MyUtils
    {
        public static List<Book> GetFiltered(IEnumerable<Book> Books, Predicate<Book> Filter) 
        {
            var result = new List<Book>();
            using (var enunumerator = Books.GetEnumerator())
            {
                while (enunumerator.MoveNext())
                {
                    if (Filter(enunumerator.Current))
                        result.Add(enunumerator.Current);
                }
            }
            return result;
        }
    }
}
