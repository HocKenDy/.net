using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; } 

        public string BookName { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public int KindOfBookId { get; set; }

        // Each Book attached a King Of Book 
        public virtual KindOfBook KindOfBook { get; set; }

        public void Init()
        {
            Console.Write("Name Book:");
            BookName = Console.ReadLine();

            Console.Write("Release Date: ");
            ReleaseDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Price: ");
            Price = double.Parse(Console.ReadLine());

            Console.Write("Amount: ");
            Amount = int.Parse(Console.ReadLine());

            Console.Write("KindOfBook Id: ");
            KindOfBookId = int.Parse(Console.ReadLine());

        }
    
    }
}
