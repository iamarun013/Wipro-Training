CREATE PROCEDURE CheckProductExist
@Product_ID INT
AS
BEGIN
SELECT
CASE
WHEN (SELECT COUNT(*)  FROM products where products.product_ID=@Product_ID) > 0 THEN 'Product Exists' 
ELSE 'Product not found'
END AS ProductStatus;
END

-----
EXEC CheckProductExist @Product_ID=1;