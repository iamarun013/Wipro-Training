CREATE TABLE Students(
StudentID INT PRIMARY KEY,
First_Name VARCHAR(50),
Marks INT,
DOB DATE
);

INSERT INTO Students(StudentID, First_Name, Marks, DOB)
VALUES
(1, 'AMIT', 92, '2003-05-10'),
(2, 'NEHA', 78, '2002-11-15'),
(3, 'Rahul', 61 , '2004-01-20'),
(4, 'SNEHA', 49, '2003-09-01');

CREATE TABLE Employees(
EmpID INT Primary Key,
Emp_Name VARCHAR(50),
Department VARCHAR(50),
Salary DECIMAL(10,2),
JoinDate DATE);

INSERT INTO Employees (EmpID, Emp_Name, Department, Salary, JoinDate)
VALUES
(1, 'John', 'HR', 5000, '2021-06-01'),
(2,'Priya', 'Finance', 60000, '2020-09-15'),
(3, 'Amit', 'IT',75000, '2019-01-10'),
(4,'SARA', 'IT', 72000, '2023-02-25');

----1. Convert student names to uppercase
SELECT First_name, UPPER(First_Name) AS UpperName FROM Students;

----2. GEt age of each student
SELECT First_name, DATEDIFF(YEAR, DOB, GETDATE()) AS Age FROM Students;

----3. Round off salary to nearest 1000
SELECT Emp_Name, ROUND(Salary, -3) AS RoundedSalary FROM Employees;



--AGGREGATE FUNCTIONS
--4. Total number of Students
SELECT COUNT(*) AS TotalStudents FROM Students;
--5.Average marks of all students
SELECT AVG(Marks) AS AverageMarks FROM Students;

--6.Highest Salary in each department
SELECT Department, MAX(Salary) AS HighesSalary
FROM Employees 
GROUP BY Department;