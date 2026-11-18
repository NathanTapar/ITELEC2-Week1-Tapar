
using System;

public class LibraryBook
{
    // Properties
    public int BookID { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public bool IsBorrowed { get; private set; }

    // Constructor
    public LibraryBook(int bookID, string title, string author)
    {
        BookID = bookID;
        Title = title;
        Author = author;
        IsBorrowed = false;
    }


    // Method to borrow a book
    public void BorrowBook()
    {
        if (IsBorrowed)
        {
            Console.WriteLine($"{Title} is already borrowed!");
        }
        else
        {
            IsBorrowed = true;
            Console.WriteLine($"{Title} has been borrowed successfully.");
        }
    }


    // Method to return a book
    public void ReturnBook()
    {
        if (!IsBorrowed)
        {
            Console.WriteLine($"{Title} is not currently borrowed!");
        }
        else
        {
            IsBorrowed = false;
            Console.WriteLine($"{Title} has been returned successfully.");
        }
    }

}
