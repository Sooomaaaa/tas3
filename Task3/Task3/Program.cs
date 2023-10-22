using System.Runtime.Intrinsics.X86;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            Library lb = new Library();
            while (true)
            {
                lb.screen();

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Enter id");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Title");
                        string title = Console.ReadLine();

                        Console.WriteLine("Enter Author");
                        string author = Console.ReadLine();

                        Console.WriteLine("Enter Year of Publish");
                        int yearPublish = int.Parse(Console.ReadLine());

                        lb.addBook(id, title, author, yearPublish);
                        goto case 2;
                    case 2:

                        lb.displayBook();
                        break;
                }
            }


        }

     
        public class Book
        {
            public int id { get; set; }
            public string title { get; set; }
            public string author { get; set; }
            public int publishYear { get; set; }

            Book()
            {

            }
            public Book(int _id, string _title, string _author, int _publishYear)
            {
                id = _id;
                title = _title;
                author = _author;
                publishYear = _publishYear;
            }
        }

        public class Library
        {
            List<Book> books = new List<Book>();

            public void addBook(int id, string title, string author, int publishYear)
            {
                Book book = new Book(id, title, author, publishYear);
                books.Add(book);
            }

            public void displayBook()
            {
                Console.WriteLine("Books in Library");

                foreach (Book b in books)
                {
                    Console.WriteLine($" Book Id : {b.id} , Book Title {b.title} , Author {b.author} , Published in {b.publishYear}");
                }

            }
            
            public void screen()
            {
                Console.WriteLine("Library System :");
                Console.WriteLine("1- Add Book");
                Console.WriteLine("2- Display Book");
                Console.WriteLine("Enter choice");
            }

        }

    }
}
