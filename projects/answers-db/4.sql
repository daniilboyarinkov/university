-- 1

-- SELECT product_name, units_in_stock
-- FROM products
-- WHERE units_in_stock < (SELECT AVG(quantity) FROM order_details GROUP BY product_id ORDER BY AVG(quantity) ASC LIMIT 1);

-- 2

-- SELECT orders.customer_id, (SUM(orders.freight)) AS freight_sum 
-- FROM orders
-- INNER JOIN customers ON orders.customer_id = customers.customer_id
-- WHERE orders.freight >= (SELECT AVG(orders.freight) FROM orders) 
-- 	AND orders.shipped_date BETWEEN '1996-07-16' AND '1996-07-31'
-- GROUP BY orders.customer_id
-- ORDER BY freight_sum ASC;

-- 3

-- SELECT orders.customer_id, orders.ship_country, order_price
-- FROM orders
-- JOIN (
-- 	SELECT order_id, SUM(unit_price * quantity - unit_price * quantity * discount) AS order_price
--     FROM order_details
--     GROUP BY order_id
-- ) as sub USING (order_id)
-- WHERE orders.ship_country IN ('Argentina', 'Brazil', 'Venezuela')
-- AND orders.order_date >= '1997-09-01'
-- ORDER BY order_price DESC
-- LIMIT 3;

