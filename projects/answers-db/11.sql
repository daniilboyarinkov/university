-- personnel

-- GRANT SELECT, INSERT, UPDATE ON employees TO personnel;

-- SELECT * FROM employees
-- WHERE employee_id = 21;

-- UPDATE employees 
-- SET last_name = 'new_test'
-- WHERE employee_id = 21;

-- INSERT INTO employees (employee_id, last_name, first_name)
-- VALUES (21, 'test', 'test');

-- DELETE FROM employees 
-- WHERE employee_id = 21;

-- warehouse

-- GRANT SELECT, INSERT ON products TO warehouse;
-- GRANT UPDATE(units_in_stock) ON products TO warehouse;
-- GRANT SELECT, INSERT ON categories TO warehouse;

-- SELECT *
-- FROM products;

-- INSERT INTO products (product_id, product_name, unit_price, units_in_stock, units_on_order)
-- VALUES (111, 'test', 111, 21, 10);

-- UPDATE products 
-- SET units_in_stock=units_in_stock+10
-- WHERE product_id=111;

-- UPDATE products 
-- SET product_name='error'
-- WHERE product_id=111;

-- DELETE FROM products 
-- WHERE product_id=111;

-- SELECT * 
-- FROM categories;

-- INSERT INTO categories (category_id, category_name)
-- VALUES(21, 'test');

-- DELETE FROM categories
-- WHERE category_id=21;

-- manager 

-- GRANT SELECT, INSERT, UPDATE ON orders, order_details TO manager;
-- GRANT SELECT, INSERT ON customers TO manager;

-- SELECT *
-- FROM orders
-- WHERE order_id=22222

-- UPDATE orders
-- SET employee_id=2
-- WHERE order_id=22222

-- INSERT INTO orders (order_id, customer_id, employee_id)
-- VALUES (22222, 'AAAAA', 1)

-- DELETE FROM orders
-- WHERE order_id=22222

-- SELECT *
-- FROM order_details
-- WHERE order_id=22222 AND product_id=50

-- INSERT INTO order_details
-- VALUES(22222, 50, 10, 0, 0)

-- UPDATE order_details
-- SET unit_price=9
-- WHERE order_id=22222 AND product_id=50

-- DELETE order_details
-- WHERE order_id=22222 AND product_id=50

-- SELECT * 
-- FROM customers

-- INSERT INTO customers (customer_id, company_name, contact_name)
-- VALUES ('CCCCC', 'fake_compane', 'test')

-- UPDATE customers 
-- SET contact_name='new_test'
-- WHERE customer_id='CCCCC'

-- DELETE customers 
-- WHERE customer_id='CCCCC'

-- boss

-- GRANT SELECT ON ALL TABLES IN SCHEMA public TO boss;
-- GRANT DELETE ON employees TO boss;
-- GRANT INSERT, UPDATE, DELETE ON suppliers, shippers TO boss;

-- INSERT INTO customers (customer_id, company_name, contact_name)
-- VALUES ('DDDDD', 'fake_compane', 'test') -- f
-- SELECT * FROM employees

-- DELETE FROM employees 
-- WHERE employee_id=21

-- SELECT * FROM suppliers;

-- INSERT INTO suppliers (supplier_id, company_name, contact_name)
-- VALUES(73, 'test', 'test');

-- UPDATE suppliers
-- SET contact_name='new_test'
-- WHERE supplier_id=73;

-- DELETE FROM suppliers
-- WHERE supplier_id=73;

-- 

-- SELECT * FROM shippers
-- WHERE shipper_id=7;

-- INSERT INTO shippers(shipper_id, company_name)
-- VALUES (7, 'test');

-- UPDATE shippers 
-- SET company_name='new_test'
-- WHERE shipper_id=7;

-- DELETE FROM shippers
-- WHERE shipper_id=7