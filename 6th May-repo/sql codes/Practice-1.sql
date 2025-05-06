CREATE TABLE Books(
    BookID INT PRIMARY KEY,
    Title VARCHAR(100),
    Author VARCHAR(100),
    Genre VARCHAR(50),
    Price DECIMAL(8,2),
    PublishedYear INT
     
);
INSERT INTO Books(BookID, Title, Author, Genre, Price, PublishedYear ) VALUES
(1, 'Sesher Kobita', 'Penu', 'Romantic', 499.00, 2020),
(2, 'Atomic Habits', 'james Clear', 'Self-Help', 499.00, 2018),
(3, 'the Alchemist', 'Paulo Coelho', 'Fiction', 299.00, 1993),
(4, 'Clean Code', ' Robert C. Martin',  'Programming', 799, 2008),
(5, 'Sapiens', 'Yuval, Noah Harari', 'History', 599, 2015);


UPDATE Books
SET Price=949.00
WHERE BookID=1;



DELETE FROM Books
WHERE BookID = 6;

SELECT * FROM Books;