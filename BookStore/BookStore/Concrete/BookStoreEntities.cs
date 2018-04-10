using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Concrete
{
    public class BookStoreEntities : DbContext
    {
        public BookStoreEntities()
            : base("Server=TIEUTHUTRAN\\SQLEXPRESS;Database=BookStore;User Id=ttdiep;Password=Baoboi469;")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<KindOfBook> KindOfBooks { get; set; }

    }
}
