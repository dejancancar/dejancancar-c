-- ********* INNER JOIN ***********

-- Let's find out who made payment 16666:
SELECT *
	FROM payment p
	JOIN customer c ON p.customer_id = c.customer_id

-- Ok, that gives us a customer_id, but not the name. We can use the customer_id to get the name FROM the customer table
SELECT *
	FROM payment p
	JOIN customer c ON p.customer_id = c.customer_id
	WHERE p.payment_id = 16666

-- We can see that the * pulls back everything from both tables. We just want everything from payment and then the first and last name of the customer:
SELECT p.*, c.first_name, c.last_name
	FROM payment p
	JOIN customer c ON p.customer_id = c.customer_id
	WHERE p.payment_id = 16666

-- But when did they return the rental? Where would that data come from? From the rental table, so let’s join that.
SELECT p.*, c.first_name, c.last_name, return_date
	FROM payment p
	JOIN customer c ON p.customer_id = c.customer_id
	JOIN rental r ON r.rental_id = p.rental_id
	WHERE p.payment_id = 16666

-- What did they rent? Film id can be gotten through inventory.

-- What if we wanted to know who acted in that film?

-- What if we wanted a list of all the films and their categories ordered by film title

-- Show all the 'Comedy' films ordered by film title

-- Finally, let's count the number of films under each category

-- (There aren't any great examples of left joins in the "dvdstore" database, so go back to the "world" queries)

-- *********** UNION *************

-- Gathers a list of all first names used by actors and customers
-- By default removes duplicates

-- Gather the list, but this time note the source table with 'A' for actor and 'C' for customer
