using BookStore.Abstract;
using BookStore.Concrete;
using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Program
    {
        private static IMainRepository mainRepository = new MainRepository();
        static void Main(string[] args)
        {
            // Add book
            //Book book1 = new Book();
            //book1.Init();
            //mainRepository.Save(book1);

            //Edit book
            //book1.BookName = "abc";
            //mainRepository.Save(book1);
            //Print Amount Each KindOfBook
            foreach(var item in mainRepository.KindOfBooks)
            {
                var list = mainRepository.Books.Where(x => x.KindOfBookId == item.KindOfBookId).ToList();
                Console.WriteLine(item.KindOfBookName + "-" + list.Count);
            }


            Console.ReadLine();
        }
    }
}
