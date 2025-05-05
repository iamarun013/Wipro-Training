CREATE PROCEDURE GetOrdersByProduct
@Prodcut_ID INT
AS
BEGIN
SELECT 
o.order_id,
o.order_quantity,
o.order_date,
p.product_name,
p.price
FROM Orders o 
INNER JOIN Products p ON o.product_id=p.product_id
WHERE o.product_id = @Prodcut_ID;
END;

