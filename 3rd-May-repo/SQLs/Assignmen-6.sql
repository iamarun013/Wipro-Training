CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    price DECIMAL(10, 2) NOT NULL
);

CREATE TABLE orders(
    order_id INT PRIMARY KEY,
    product_id INT,
    order_quantity INT NOT NULL,
    order_date DATE NOT NULL,
    FOREIGN KEY (product_id) REFERENCES products(product_id)

);

INSERT INTO products
VALUES
(1, 'Laptop', 70000),
(2, 'Mobile', 25000),
(3, 'Tablet', 30000),
(4, 'Monitor', 15000);

INSERT INTO orders
VALUES
(101, 1, 10, 2024-04-28),
(102, 2, 30, 2024-04-28),
(103, 3, 20, 2024-04-20),
(104, 4, 15, 2025-01-18);

SELECT 
orders.order_id,
products.product_id,
orders.order_quantity,
products.price,
(orders.order_quantity * Products.price)As TotalAmount,
orders.order_date

FROM orders
INNER JOIN Products ON orders.product_id= products.product_id

-- LEFT Join
SELECT
products.product_id,
products.product_name,
orders.order_id,
orders.order_quantity,
orders.order_date

FROM products
LEFT JOIN orders on products.product_id=orders.order_id;

SELECT
products.product_name
SUM(orders.order_quantity) AS TotalUnitsSold

FROM orders
INNER JOIN products on orders.product_id = products.product_id
GROUP BY products.product_name