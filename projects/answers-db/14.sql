CREATE TABLE vip_customers (
    customer_id bpchar NOT NULL,
    company_name character varying(40),
    contact_name character varying(30),
    contact_title character varying(30),
    address character varying(60),
    city character varying(15),
    region character varying(15),
    postal_code character varying(10),
    country character varying(15),
    phone character varying(24),
    fax character varying(24)
);

create or replace procedure hunt_for_vips()
language plpgsql
as $$
begin
	delete from vip_customers;
	insert into vip_customers (select * from customers where customer_id in (
		select customer_id
		from orders
		group by customer_id
		having count (customer_id) > 25
	));
end; 
$$

call hunt_for_vips();

