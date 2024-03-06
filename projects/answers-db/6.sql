-- 1

-- CREATE VIEW orders_customers_employees AS
-- SELECT order_date, required_date, shipped_date, ship_postal_code,
-- company_name, contact_name, phone, last_name, first_name, title
-- FROM orders
-- JOIN customers USING(customer_id)
-- JOIN employees USING(employee_id);

-- SELECT *
-- FROM orders_customers_employees
-- WHERE order_date > '1997-01-01';

-- 2

-- CREATE OR REPLACE VIEW orders_customers_employees_2 AS
-- SELECT order_date, required_date, shipped_date, 
-- ship_postal_code, company_name, contact_name, phone, 
-- last_name, first_name, title
-- FROM orders
-- JOIN customers USING(customer_id)
-- JOIN employees USING(employee_id);

-- rename view
-- ALTER VIEW orders_customers_employees_2 RENAME TO orders_customers_employees_new;

-- new view with necessary columns
-- CREATE OR REPLACE VIEW orders_customers_employees_2 AS
-- SELECT order_date, required_date, shipped_date, ship_postal_code, ship_country,
-- company_name, contact_name, phone, customers.postal_code, 
-- last_name, first_name, title, reports_to
-- FROM orders
-- JOIN customers USING(customer_id)
-- JOIN employees USING(employee_id);

-- 1 - first
-- 2 -needed
-- new 2nd without necessery fields

-- SELECT *
-- FROM orders_customers_employees_2
-- ORDER BY ship_country ASC;

-- DROP VIEW IF EXISTS orders_customers_employees_new;

-- 3 

-- CREATE VIEW active_products AS
-- SELECT * FROM products
-- WHERE discontinued = 0
-- WITH LOCAL CHECK OPTION;

-- INSERT INTO active_products 
-- VALUES(100, '1', 1, 1, '1', 1, 1, 1, 1, 1);


-- 4

-- CREATE OR REPLACE VIEW premium_1997 AS
-- SELECT employees.last_name, employees.first_name, sub.premium
-- FROM employees
-- JOIN orders USING (employee_id)
-- JOIN (
-- 	SELECT orders.employee_id, COUNT(orders.employee_id) as sold_products, 
-- 	CASE 
-- 		WHEN COUNT(orders.employee_id) > 60 
-- 		THEN 'Выдать премию' 
-- 		ELSE 'Плохо работали, премию не заслужили'  
-- 	END AS premium
-- 	 FROM orders 
-- 	 WHERE orders.order_date BETWEEN '1997-01-01' AND '1997-12-31' 
-- 	 GROUP BY orders.employee_id
-- ) AS sub USING (employee_id)
-- GROUP BY employees.last_name, employees.first_name, sub.premium;

