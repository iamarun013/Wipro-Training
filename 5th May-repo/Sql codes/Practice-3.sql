BEGIN TRANSACTION ;
UPDATE Employees
SET Salary = Salary + 2000
WHERE Department = 'IT';

COMMIT;

--BEGIN TRANSACTION
--DELETE FROM Students WHERE Marks <60;
----Realized it's a mistake
--RollBack;
