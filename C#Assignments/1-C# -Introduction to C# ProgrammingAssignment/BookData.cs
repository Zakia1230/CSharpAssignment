using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    using System;
    enum bookTypes
    {
        Magazine = 1,
        Novel = 2,
        ReferenceBook = 3,
        Miscellaneous = 4
    }

    struct Book
    {
        private int bookId;
        private string title;
        private double price;
        private int bookType;

        public void getBookDetail(int id, string bookTitle, double bookPrice, int type)
        {
            bookId = id;
            title = bookTitle;
            price = bookPrice;
            bookType = type;
        }

        public void displayBookDetail()
        {
            Console.WriteLine("Book Id " + bookId);
            Console.WriteLine("Book Title " + title);
            Console.WriteLine("Book Price " + price);
            Console.WriteLine("Book Type " + (bookTypes)bookType);
        }
    }

    public class BookData
    {
        public static void Main()
        {
            Book Book1 = new Book();

            Console.Write("Enter the Book Id: ");
            int bId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Book Name: ");
            string bName = Console.ReadLine();
            Console.Write("Enter the Book Price: ");
            int bPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Book Type: ");
            int bType = Convert.ToInt32(Console.ReadLine());

            Book1.getBookDetail(bId, bName, bPrice, bType);
            Book1.displayBookDetail();

        }

    }
}
