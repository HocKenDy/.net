using BookStore.Abstract;
using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Concrete
{
    class MainRepository : IMainRepository
    {
        private BookStoreEntities context = new BookStoreEntities();
        public IQueryable<Book> Books
        {
            get
            {
                return context.Books;
            }
           
        }

        public IQueryable<KindOfBook> KindOfBooks
        {
            get
            {
                return context.KindOfBooks;
            }
        }

       

        public int Delete(Book book)
        {
            var tmp = context.Books.Where(x => x.BookId == book.BookId).FirstOrDefault();
            if (tmp != null)
            {
                context.Books.Remove(book);
                return context.SaveChanges();
            }
            return 0;
        }

        public int Save(Book book)
        {
            if (book.BookId == 0) 
            {
                //Add book
                context.Books.Add(book);
                return context.SaveChanges();
            }
            else
            {   
                //Edit info book
                var tmp = context.Books.Where(x => x.BookId == book.BookId).FirstOrDefault();
                if (tmp != null)
                {
                    tmp.BookName = book.BookName;
                    tmp.ReleaseDate = book.ReleaseDate;
                    tmp.Price = book.Price;
                    tmp.Amount = book.Amount;
                    tmp.KindOfBookId = book.KindOfBookId;
                    return context.SaveChanges();
                }
            }
            return 0;
        }
    }
}
