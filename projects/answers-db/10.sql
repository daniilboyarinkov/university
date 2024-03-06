  -- 1

-- CREATE OR REPLACE FUNCTION politeness_tracker() RETURNS TRIGGER AS
-- $BODY$
-- BEGIN

-- 	IF (TG_OP = 'DELETE') THEN
-- 		RAISE EXCEPTION 'Я вам запрещаю удалять';
-- 		RETURN OLD;
-- 	ELSIF (TG_OP = 'UPDATE' OR TG_OP = 'INSERT')  THEN
-- 		IF (NEW.title_of_courtesy NOT IN ('Ms.', 'Mrs.', 'Mr.',  'Dr.')) THEN
-- 			RAISE EXCEPTION 'Я вам запрещаю не быть культурным';
-- 		END IF;
-- 		RETURN NEW;
-- 	END IF;

-- END
-- $BODY$
-- LANGUAGE plpgsql

-- CREATE OR REPLACE TRIGGER politness_trigger 
-- BEFORE insert or update or delete
-- ON employees
-- FOR EACH ROW
-- EXECUTE FUNCTION politeness_tracker();

-- INSERT INTO employees (employee_id, last_name,  first_name, title, title_of_courtesy, birth_date, hire_date, city)
-- VALUES (10, 'test', 'test', 'test repr.', 'lol', '2000-10-10', '2022-02-03', 'test' );

-- UPDATE employees 
-- SET title_of_courtesy='lol';

-- DELETE FROM employees
-- WHERE title_of_courtesy='Ms.';


--  2

-- CREATE TABLE "products_audit"(
-- 	product_name character varying,
-- 	old_price real,
-- 	new_price real,
-- 	change_date timestamp
-- );

-- CREATE OR REPLACE FUNCTION products_price_log() RETURNS TRIGGER AS
-- $BODY$
-- BEGIN

-- 	IF (TG_OP = 'DELETE') THEN
-- 		INSERT INTO products_audit SELECT OLD.product_name, OLD.unit_price, NEW.unit_price, now();
-- 		RETURN OLD;
-- 	ELSIF (TG_OP = 'INSERT' OR TG_OP = 'UPDATE') THEN
-- 		INSERT INTO products_audit SELECT NEW.product_name, OLD.unit_price, NEW.unit_price, now();
-- 		RETURN NEW;
-- 	END IF;
	
-- END
-- $BODY$
-- LANGUAGE plpgsql

-- CREATE OR REPLACE TRIGGER products_price_trigger 
-- BEFORE insert or update or delete
-- ON products
-- FOR EACH ROW
-- EXECUTE FUNCTION products_price_log();

-- UPDATE products 
-- SET unit_price = unit_price * 2;

-- 3

CREATE OR REPLACE FUNCTION check_products() RETURNS TRIGGER AS
$BODY$
DECLARE 
	in_stock smallint;
	on_order smallint;
BEGIN
	SELECT units_in_stock into in_stock FROM products WHERE products.product_id = NEW.product_id;
	SELECT units_on_order into on_order FROM products WHERE products.product_id = NEW.product_id;

	IF (TG_OP = 'INSERT') THEN
		IF (in_stock < on_order + NEW.quantity) 
			THEN RAISE NOTICE 'Недостаточно товара (%) на складе. Заказ товара невозможен', NEW.product_id;
			RETURN OLD;
		ELSE 
			RAISE NOTICE 'Заказ товара (%) возможен. Количества достаточно', NEW.product_id;
			UPDATE products SET units_on_order = units_on_order + NEW.quantity WHERE product_id = NEW.product_id;
			RETURN NEW;
		END IF;
	ELSIF (TG_OP = 'UPDATE') THEN 
		IF (in_stock < NEW.quantity) 
			THEN RAISE NOTICE 'Недостаточно товара (%) на складе. Заказ товара невозможен', NEW.product_id;
			RETURN OLD;
		ELSE 
			RAISE NOTICE 'Изменение заказа товара (%) возможно. Количества достаточно', NEW.product_id;
			UPDATE products SET units_on_order = NEW.quantity WHERE product_id = NEW.product_id;
			RETURN NEW;
		END IF;
	END IF;
END
$BODY$
LANGUAGE plpgsql

CREATE OR REPLACE TRIGGER enough_products_trigger 
BEFORE insert or update
ON order_details
FOR EACH ROW
EXECUTE FUNCTION check_products();

-- 

CREATE OR REPLACE FUNCTION check_products_change() RETURNS TRIGGER AS
$BODY$
BEGIN
	IF (TG_OP = 'UPDATE') THEN
		IF (OLD.units_in_stock < NEW.units_on_order) 
			THEN RAISE NOTICE 'Недостаточно товара (%) на складе. Заказ товара невозможен', OLD.product_id;
			RETURN OLD;
		ELSE 
			RAISE NOTICE 'Заказ товара (%) возможен. Количества достаточно', NEW.product_id;
			RETURN NEW;
		END IF;
	END IF;
END
$BODY$
LANGUAGE plpgsql

CREATE OR REPLACE TRIGGER enough_products_change_trigger 
BEFORE update
ON products
FOR EACH ROW
EXECUTE FUNCTION check_products_change();

-- --

-- insert into orders values (12345, 'AAAAA', 1)

SELECT *
FROM products 
WHERE product_id in (10, 11, 22, 50, 55);

INSERT INTO order_details 
VALUES (12345, 10, 5, 50, 0) -- f
,(12345, 11, 1, 30, 0) -- f
,(12345, 22, 7, 25, 0) -- t25
,(12345, 50, 10, 500, 0) -- f
,(12345, 55, 2, 105, 0); -- t105

SELECT * FROM order_details 
WHERE order_id = 12345;

-- 

UPDATE products SET units_on_order = 32 WHERE product_id = 10;

UPDATE order_details SET quantity=106 WHERE product_id=55 AND order_id=12345;


