
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two LibraryBook objects
        LibraryBook book1 = new LibraryBook(
            101,
            "The Great Gatsby",
            "F. Scott Fitzgerald"
        );

        LibraryBook book2 = new LibraryBook(
            102,
            "Harry Potter",
            "J.K. Rowling"
        );

        Console.WriteLine("=================================");
        Console.WriteLine("       LIBRARY BOOK SYSTEM");
        Console.WriteLine("=================================");

        // Display book information
        Console.WriteLine("\n--- BOOK INFORMATION ---");

        Console.WriteLine($"Book ID: {book1.BookID}");
        Console.WriteLine($"Title: {book1.Title}");
        Console.WriteLine($"Author: {book1.Author}");
        Console.WriteLine($"Borrowed: {book1.IsBorrowed}");

        Console.WriteLine();

        Console.WriteLine($"Book ID: {book2.BookID}");
        Console.WriteLine($"Title: {book2.Title}");
        Console.WriteLine($"Author: {book2.Author}");
        Console.WriteLine($"Borrowed: {book2.IsBorrowed}");

        // Test Book 1
        Console.WriteLine("\n--- BOOK 1 TEST ---");

        book1.BorrowBook();
        book1.BorrowBook();
        book1.ReturnBook();
        book1.ReturnBook();

        // Test Book 2
        Console.WriteLine("\n--- BOOK 2 TEST ---");

        book2.BorrowBook();

        // Display final borrowing status
        Console.WriteLine("\n--- FINAL BOOK STATUS ---");

        Console.WriteLine(
            $"{book1.Title} - Borrowed: {book1.IsBorrowed}"
        );

        Console.WriteLine(
            $"{book2.Title} - Borrowed: {book2.IsBorrowed}"
        );

        Console.WriteLine("\n=================================");
        Console.WriteLine("       PROGRAM FINISHED");
        Console.WriteLine("=================================");
    }
}
