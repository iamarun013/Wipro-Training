using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    // Book class
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(int id, string title, string author)
        {
            BookID = id;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{BookID}: {Title} by {Author} (Available: {IsAvailable})";
        }
    }

    // Student class
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        // Dictionary of borrowed books and their due dates
        public Dictionary<Book, DateTime> BorrowedBooks { get; set; } = new Dictionary<Book, DateTime>();

        public Student(int id, string name)
        {
            StudentID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{StudentID}: {Name}";
        }

        public void BorrowBook(Book book, DateTime dueDate)
        {
            BorrowedBooks[book] = dueDate;
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.ContainsKey(book))
                BorrowedBooks.Remove(book);
        }
    }

    class Program
    {
        static List<Book> books = new List<Book>();
        static List<Student> students = new List<Student>();
        static int bookCounter = 1;
        static int studentCounter = 1;

        static void Main(string[] args)
        {
            // Example interaction
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Delete Book");
                Console.WriteLine("3. Register Student");
                Console.WriteLine("4. Borrow Book");
                Console.WriteLine("5. Return Book");
                Console.WriteLine("6. Show Books");
                Console.WriteLine("7. Show Students");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddBook();
                            break;
                        case 2:
                            DeleteBook();
                            break;
                        case 3:
                            RegisterStudent();
                            break;
                        case 4:
                            BorrowBook();
                            break;
                        case 5:
                            ReturnBook();
                            break;
                        case 6:
                            ShowBooks();
                            break;
                        case 7:
                            ShowStudents();
                            break;
                        case 8:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
            }
        }

        static void AddBook()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author name: ");
            string author = Console.ReadLine();
            Book newBook = new Book(bookCounter++, title, author);
            books.Add(newBook);
            Console.WriteLine("Book added successfully.");
        }

        static void DeleteBook()
        {
            Console.Write("Enter Book ID to delete: ");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                var book = books.FirstOrDefault(b => b.BookID == id);
                if (book != null)
                {
                    books.Remove(book);
                    Console.WriteLine("Book deleted.");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
        }

        static void RegisterStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Student student = new Student(studentCounter++, name);
            students.Add(student);
            Console.WriteLine("Student registered successfully.");
        }

        static void BorrowBook()
        {
            Console.Write("Enter Student ID: ");
            int studentId;
            if (int.TryParse(Console.ReadLine(), out studentId))
            {
                var student = students.FirstOrDefault(s => s.StudentID == studentId);
                if (student == null)
                {
                    Console.WriteLine("Student not found.");
                    return;
                }

                Console.Write("Enter Book ID to borrow: ");
                int bookId;
                if (int.TryParse(Console.ReadLine(), out bookId))
                {
                    var book = books.FirstOrDefault(b => b.BookID == bookId);
                    if (book == null)
                    {
                        Console.WriteLine("Book not found.");
                        return;
                    }
                    if (!book.IsAvailable)
                    {
                        Console.WriteLine("Book is currently borrowed.");
                        return;
                    }

                    DateTime dueDate = DateTime.Now.AddDays(14); // 2 weeks loan
                    book.IsAvailable = false;
                    student.BorrowBook(book, dueDate);
                    Console.WriteLine($"Book borrowed. Due date: {dueDate.ToShortDateString()}");
                }
            }
        }

        static void ReturnBook()
        {
            Console.Write("Enter Student ID: ");
            int studentId;
            if (int.TryParse(Console.ReadLine(), out studentId))
            {
                var student = students.FirstOrDefault(s => s.StudentID == studentId);
                if (student == null)
                {
                    Console.WriteLine("Student not found.");
                    return;
                }

                Console.Write("Enter Book ID to return: ");
                int bookId;
                if (int.TryParse(Console.ReadLine(), out bookId))
                {
                    var book = books.FirstOrDefault(b => b.BookID == bookId);
                    if (book == null)
                    {
                        Console.WriteLine("Book not found.");
                        return;
                    }

                    if (student.BorrowedBooks.ContainsKey(book))
                    {
                        student.ReturnBook(book);
                        book.IsAvailable = true;
                        Console.WriteLine("Book returned successfully.");
                    }
                    else
                    {
                        Console.WriteLine("This student did not borrow this book.");
                    }
                }
            }
        }

        static void ShowBooks()
        {
            Console.WriteLine("\nBooks List:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        static void ShowStudents()
        {
            Console.WriteLine("\nStudents List:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
                if (student.BorrowedBooks.Count > 0)
                {
                    Console.WriteLine(" Borrowed Books:");
                    foreach (var kvp in student.BorrowedBooks)
                    {
                        Console.WriteLine($"  - {kvp.Key.Title} (Due: {kvp.Value.ToShortDateString()})");
                    }
                }
                else
                {
                    Console.WriteLine(" No borrowed books.");
                }
            }
        }
    }
}