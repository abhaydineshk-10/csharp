using System;
using System.Collections.Generic;

namespace library_management
{
    internal class Program
    {
        static List<Book> books = new List<Book>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. List Books");
                Console.WriteLine("3. Search Book by Title");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        ListBooks();
                        break;
                    case "3":
                        SearchBook();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddBook()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author: ");
            string author = Console.ReadLine();
            books.Add(new Book { Title = title, Author = author });
            Console.WriteLine("Book added successfully.");
        }

        static void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }
            Console.WriteLine("\nBooks in Library:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }

        static void SearchBook()
        {
            Console.Write("Enter title to search: ");
            string searchTitle = Console.ReadLine();
            var found = books.FindAll(b => b.Title.Contains(searchTitle, StringComparison.OrdinalIgnoreCase));
            if (found.Count == 0)
            {
                Console.WriteLine("No books found with that title.");
            }
            else
            {
                Console.WriteLine("Search Results:");
                foreach (var book in found)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
                }
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}