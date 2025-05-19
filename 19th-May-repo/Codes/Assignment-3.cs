using System;
using System.Collections.Generic;

// Step 1: Book class
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"\"{Title}\" by {Author}";
    }
}

class Program
{
    static void Main()
    {
        // 2. Manage borrowed books using Queue<Book>
        Queue<Book> borrowedBooks = new Queue<Book>();
        
        // Add 5 borrowed books
        borrowedBooks.Enqueue(new Book("1984", "George Orwell"));
        borrowedBooks.Enqueue(new Book("To Kill a Mockingbird", "Harper Lee"));
        borrowedBooks.Enqueue(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
        borrowedBooks.Enqueue(new Book("Pride and Prejudice", "Jane Austen"));
        borrowedBooks.Enqueue(new Book("The Hobbit", "J.R.R. Tolkien"));

        // Display the next book to be returned
        if (borrowedBooks.Count > 0)
        {
            Console.WriteLine($"Next book to be returned: {borrowedBooks.Peek()}");
        }

        // Remove the book after it is returned
        if (borrowedBooks.Count > 0)
        {
            Book returnedBook = borrowedBooks.Dequeue();
            Console.WriteLine($"Returned book: {returnedBook}");
        }

        // 3. Manage newly purchased books using Stack<Book>
        Stack<Book> newBooks = new Stack<Book>();

        // Add 3 new books
        newBooks.Push(new Book("Dune", "Frank Herbert"));
        newBooks.Push(new Book("The Catcher in the Rye", "J.D. Salinger"));
        newBooks.Push(new Book("Moby-Dick", "Herman Melville"));

        // Display the last purchased book
        if (newBooks.Count > 0)
        {
            Console.WriteLine($"Last purchased book: {newBooks.Peek()}");
        }

        // Remove a book after processing
        if (newBooks.Count > 0)
        {
            Book processedBook = newBooks.Pop();
            Console.WriteLine($"Processed book: {processedBook}");
        }

        // 4. Print remaining books in both queue and stack
        Console.WriteLine("\nRemaining borrowed books in queue:");
        foreach (var book in borrowedBooks)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nRemaining new books in stack:");
        foreach (var book in newBooks)
        {
            Console.WriteLine(book);
        }
    }
}