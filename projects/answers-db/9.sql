CREATE OR REPLACE FUNCTION is_raise_valid(cur numeric, minn numeric, maxx numeric, pr numeric) 
RETURNS numeric AS 
$BODY$
DECLARE 
	computed numeric;
BEGIN
	computed := cur * (1 + pr);

	CASE 
		WHEN minn > maxx THEN 
			RAISE EXCEPTION '(1) минимальная цена товара превышает максимальную'; 
		WHEN minn < 0 OR maxx < 0 THEN 
    		RAISE EXCEPTION '(2) ни минимальная, ни максимальная цена товара не могут быть меньше нуля'; 
		WHEN computed > maxx THEN 
    		RAISE EXCEPTION '(3) цена товара после увеличения превышает максимальную'; 
		WHEN pr < 0.1 THEN
			RAISE EXCEPTION '(4) коэффициент повышения цены товара не может быть ниже 0.1'; 
		ELSE RETURN computed;
	END CASE;
	
END
$BODY$
LANGUAGE plpgsql;

SELECT is_raise_valid(5000, 10000, 8000, 0.25);
SELECT is_raise_valid(5000, -1000, 1000, 0.2);
SELECT is_raise_valid(5000, 1000, 6000, 0.05);
SELECT is_raise_valid(5000, 2000, 8000, 0.3);
SELECT is_raise_valid(5000, 2000, 6000, 0.3);
