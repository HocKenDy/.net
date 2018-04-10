using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities
{
    public class KindOfBook
    {
        [Key]
        public int KindOfBookId { get; set; }

        public string KindOfBookName { get; set; }
        public string StoreName { get; set; }

        public ICollection<Book> Books { get; set; }

        public KindOfBook()
        {
            Books = new HashSet<Book>();
        }

    }
}
