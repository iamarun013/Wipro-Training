CREATE PROCEDURE STOREDPROCEDURE
AS 
BEGIN 
SELECT * FROM products;
END;

EXEC STOREDPROCEDURE;


----Getting Higher end products 
CREATE PROCEDURE HigherEndProducts
AS 
BEGIN 
SELECT * FROM products
WHERE price>6000;
END;

EXEC HigherEndProducts;


--- 