-- 

-- CREATE DATABASE test_db
--     WITH
--     OWNER = postgres
--     ENCODING = 'UTF8'
--     LC_COLLATE = 'Russian_Russia.1251'
--     LC_CTYPE = 'Russian_Russia.1251'
--     TABLESPACE = pg_default
--     CONNECTION LIMIT = -1
--     IS_TEMPLATE = False;

-- 

-- CREATE TABLE teacher (
-- 	teacher_id SERIAL,
-- 	lastname varchar,
-- 	firstname varchar,
-- 	birthday date,
-- 	phone varchar
-- );

-- 

-- ALTER TABLE teacher ADD COLUMN secondname varchar;

-- 

-- ALTER TABLE teacher DROP COLUMN secondname;

-- 

-- ALTER TABLE teacher RENAME COLUMN birthday TO birth_date;

-- 

-- ALTER TABLE teacher ALTER COLUMN phone SET DATA TYPE varchar(32);

-- 

-- CREATE TABLE exam (
-- 	exam_id serial UNIQUE NOT NULL,
-- 	exam_name varchar(256),
-- 	exam_date date
-- );

-- 

-- INSERT INTO exam (exam_name, exam_date)
-- VALUES
-- ('exam 1', '2023-01-02'),
-- ('exam 2', '2023-02-02'),
-- ('exam 3', '2023-03-02');

-- 

-- ALTER TABLE exam
-- DROP CONSTRAINT exam_exam_id_key;

-- 

-- ALTER TABLE exam
-- ADD PRIMARY KEY (exam_id);

-- 

-- CREATE TABLE person (
-- 	person_id integer NOT NULL,
-- 	first_name varchar(64) NOT NULL,
-- 	last_name varchar(64) NOT NULL,
	
-- 	CONSTRAINT PK_person_person_id PRIMARY KEY(person_id)
-- );

-- 

-- CREATE TABLE passport (
-- 	passport_id int,
-- 	serial_number int NOT NULL,
-- 	registration text NOT NULL,
-- 	person_id int NOT NULL,
	
-- 	CONSTRAINT PK_passport_passport_id PRIMARY KEY (passport_id),
-- 	CONSTRAINT FK_passport_person FOREIGN KEY (person_id) REFERENCES person(person_id)
-- );

-- 

-- CREATE TABLE student (
-- 		student_id serial,
-- 		last_name varchar,
-- 		first_name varchar,
-- 		second_name varchar,
-- 		grade int DEFAULT 1
-- )

-- 

-- INSERT INTO student
-- VALUES(1, 'test', 'student', 'came');
-- SELECT * FROM student;

-- 

-- ALTER TABLE student
-- ALTER COLUMN grade DROP DEFAULT;

-- 

-- INSERT INTO student
-- VALUES(2, 'another', 'test', 'student');
-- SELECT * FROM student;

-- 
-- а вот это уже в northwind
-- 

-- ALTER TABLE products
-- ADD CONSTRAINT chk_products_price CHECK (unit_price > 0);

-- 

-- SELECT MAX(product_id) FROM products; -- 77

-- CREATE SEQUENCE IF NOT EXISTS products_product_id_seq
-- START WITH 78 OWNED BY products.product_id;

-- ALTER TABLE products
-- ALTER COLUMN product_id SET DEFAULT nextval('products_product_id_seq');

-- 

-- INSERT INTO products (product_name, supplier_id, category_id, 
-- 					  quantity_per_unit, unit_price, units_in_stock, 
-- 					  units_on_order, reorder_level, discontinued)
-- VALUES('test', 1, 1, 1, 1, 1, 1, 1, 1)
-- RETURNING product_id;

-- 
