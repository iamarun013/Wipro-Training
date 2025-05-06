BEGIN TRANSACTION ;
UPDATE Employees
SET Salary = Salary + 2000
WHERE Department = 'IT';

COMMIT;

BEGIN TRANSACTION
DELETE FROM Students WHERE Marks <60;
--Realized it's a mistake
RollBack;

BEGIN TRANSACTION;
UPDATE Employees
SET Salary = Salary + 1000
WHERE EmpID = 1;

SAVE TRANSACTION IncreaseJohn;

UPDATE Employees
SET Salary = Salary + 1000
WHERE EmpID = 2;

--ops rollback second increment only
ROLLBACK TRANSACTION IncreaseJohn;
COMMIT;

----
Partition BY (Group-Wise Analysis)
SELECT
Name, Department, Salary,
AVG(Salary) OVER(Partition BY Department) AS DeptAvgSalary
FROM Employees;

--Ranking Functions
Row_Number()
SELECT
Name,
Department,
Salary,
Row_Number() OVER(Partition by Department Order by Salaey DESC) AS Row_Number

FROM Employees;

----------------------------------
CREATE USER test_user FOR LOGIN test_login;
--first ensure the login exists if not:
CREATE LOGIN test_login WITH PASSWORD = 'StrongPls@123';