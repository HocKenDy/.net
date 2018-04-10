using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Abstract
{
    interface IMainRepository
    {
        IQueryable<Book> Books { get; }
        IQueryable<KindOfBook> KindOfBooks { get; }
        //CRUD
        int Save(Book book);
        int Delete(Book book);


    }
}
