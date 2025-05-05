--Q- Write a stored procedure where the total revenue is calculated (order quantity 8 price) through an input ID to the procedure.

CREATE PROCEDURE GetProductName
@Product_ID INT
AS
BEGIN 
Select (orders.order_quantity*products.price) AS totalRevenue
FROM orders
INNER JOIN products on orders.product_id = products.product_id;
WHERE orders.product_id=@Prodcut_ID;
END
----
EXEC GetProductName @Product_ID = 1;