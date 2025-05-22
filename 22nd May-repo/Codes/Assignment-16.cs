using System;
using System.Collections.Generic;
using System.Linq;

// 1. Book class
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }
}

// 2. Library class
public class Library
{
    private List<Book> books = new List<Book>();

    // 3. Methods to add and search books
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> SearchByAuthor(string author)
    {
        return books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Book> SearchByTitle(string title)
    {
        return books.Where(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}

class Program
{
    static void Main()
    {
        // 4. Create a library and add sample books
        Library library = new Library();

        library.AddBook(new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", IsAvailable = true });
        library.AddBook(new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", IsAvailable = true });
        library.AddBook(new Book { Id = 3, Title = "1984", Author = "George Orwell", IsAvailable = false });
        library.AddBook(new Book { Id = 4, Title = "Animal Farm", Author = "George Orwell", IsAvailable = true });
        library.AddBook(new Book { Id = 5, Title = "Brave New World", Author = "Aldous Huxley", IsAvailable = true });

        // Search by author
        Console.WriteLine("Books by George Orwell:");
        var booksByOrwell = library.SearchByAuthor("George Orwell");
        foreach (var book in booksByOrwell)
        {
            Console.WriteLine($"- {book.Title} (Available: {book.IsAvailable})");
        }

        Console.WriteLine();

        // Search by title
        Console.WriteLine("Search for 'The Great Gatsby':");
        var gatsbyBooks = library.SearchByTitle("The Great Gatsby");
        foreach (var book in gatsbyBooks)
        {
            Console.WriteLine($"- {book.Title} by {book.Author} (Available: {book.IsAvailable})");
        }
    }
}