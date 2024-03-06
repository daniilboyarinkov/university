-- 1

-- SELECT COUNT(customer_id) as customers_count 
-- FROM customers;

-- 2

-- SELECT COUNT(DISTINCT country) as distinct_country_count 
-- FROM customers;

-- 3

-- SELECT * 
-- FROM orders 
-- WHERE ship_country = 'France' OR ship_country = 'Austria' OR ship_country = 'Spain';

-- 4

-- SELECT SUM(shipped_date - order_date)/COUNT(order_id) AS average_delivery_days 
-- FROM orders 
-- WHERE ship_country = 'USA';

-- 5

-- SELECT SUM( unit_price * units_in_stock ) 
-- FROM products 
-- WHERE discontinued = 0;

-- 6

-- SELECT * 
-- FROM orders 
-- WHERE ship_country LIKE 'U%';

-- 7

-- SELECT order_id, customer_id, freight, ship_country 
-- FROM orders 
-- WHERE ship_country 
-- LIKE 'N%' 
-- ORDER BY freight DESC 
-- LIMIT 10;

-- 8

-- SELECT COUNT(customer_id) 
-- FROM customers 
-- WHERE region IS NOT NULL;

-- 9

-- SELECT country, COUNT(country) as suppliers_count 
-- FROM suppliers 
-- GROUP BY country 
-- ORDER BY suppliers_count DESC;

-- 10

-- SELECT ship_country, SUM(freight) AS total_weight 
-- FROM orders 
-- WHERE ship_region IS NOT NULL 
-- GROUP BY ship_country
-- HAVING SUM(freight) > 2750
-- ORDER BY total_weight DESC;

-- 11

-- SELECT country FROM customers 
-- INTERSECT SELECT country FROM employees 
-- INTERSECT SELECT country FROM suppliers;

-- 12

-- SELECT country FROM customers 
-- INTERSECT SELECT country FROM suppliers 
-- EXCEPT SELECT country FROM employees;
