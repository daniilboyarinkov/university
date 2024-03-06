-- 1

-- SELECT shippers.company_name, employees.last_name, employees.first_name 
-- FROM orders 
-- INNER JOIN shippers ON orders.ship_via = shippers.shipper_id
-- INNER JOIN employees ON orders.employee_id = employees.employee_id
-- INNER JOIN customers ON orders.customer_id = customers.customer_id
-- WHERE employees.city = 'London' AND customers.city = 'London' AND shippers.company_name = 'Speedy Express';

-- 2

-- SELECT products.product_name, products.units_in_stock, suppliers.contact_name, suppliers.phone
-- FROM products
-- INNER JOIN suppliers ON products.supplier_id = suppliers.supplier_id
-- INNER JOIN categories ON products.category_id = categories.category_id
-- WHERE products.discontinued = 0 AND products.units_in_stock < 20 AND ( categories.category_name = 'Beverages' OR categories.category_name = 'Seafood' );

-- 3

-- SELECT customers.contact_name, orders.order_id
-- FROM orders
-- RIGHT OUTER JOIN customers ON orders.customer_id = customers.customer_id
-- WHERE orders.order_id IS NULL;