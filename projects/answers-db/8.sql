-- 1

-- CREATE OR REPLACE FUNCTION show_number_of_undone_orders ()
-- RETURNS integer
-- AS
-- $BODY$

-- SELECT count(*) 
-- FROM orders 
-- WHERE shipped_date IS NULL;

-- $BODY$
-- LANGUAGE SQL;

-- SELECT show_number_of_undone_orders();

-- 2

-- CREATE OR REPLACE FUNCTION edges_category_prices ()
-- RETURNS TABLE(c_id smallint, min_price real, max_price real) AS
-- $BODY$
-- BEGIN

-- 	RETURN query
-- 	SELECT category_id, MIN(unit_price), MAX(unit_price) 
-- 	FROM products
-- 	GROUP BY category_id;
	
-- END;
-- $BODY$
-- LANGUAGE plpgsql;

-- SELECT edges_category_prices();


-- 3

-- CREATE OR REPLACE FUNCTION show_customers_from_country (_country character varying)
-- RETURNS TABLE(customer_id character, company_name character varying) AS
-- $BODY$
-- BEGIN

-- 	RETURN query
-- 	SELECT customers.customer_id, customers.company_name
-- 	FROM customers
-- 	WHERE customers.country = _country;
	
-- END;
-- $BODY$
-- LANGUAGE plpgsql;

-- SELECT show_customers_from_country('USA');

-- 4

-- CREATE OR REPLACE FUNCTION recompute_price ()
-- RETURNS TABLE(category_id smallint, old_price real, new_price real) AS
-- $BODY$
-- BEGIN

-- 	RETURN query
-- 	SELECT products.category_id, unit_price, 
-- 	CASE 
-- 		WHEN products.category_id::integer % 2 = 0 
-- 		THEN CAST(unit_price * 1.8 AS real)
-- 		ELSE CAST(unit_price / 1.5 AS real)
-- 	END AS new_unit_price
-- 	FROM products;
	
-- END;
-- $BODY$
-- LANGUAGE plpgsql;

-- SELECT recompute_price();

-- 5

-- CREATE OR REPLACE FUNCTION edges_salary_of_employee_from_city (city_c character varying)
-- RETURNS record AS
-- $BODY$
-- DECLARE res record;
-- BEGIN

-- 	SELECT MIN(salary), MAX(salary) into res
-- 	FROM employees
-- 	WHERE employees.city = city_c;
	
-- 	RETURN res;
-- END;
-- $BODY$
-- LANGUAGE plpgsql;

-- SELECT edges_salary_of_employee_from_city('London');

-- 6

-- CREATE OR REPLACE FUNCTION change_employees_salary (_percent numeric)
-- RETURNS void AS
-- $BODY$
-- BEGIN

-- 	UPDATE employees SET salary = salary * (1 + _percent / 100);
	
-- END;
-- $BODY$
-- LANGUAGE plpgsql;

-- SELECT change_employees_salary(5);

