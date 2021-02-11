-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT f.title
	FROM actor a
	JOIN film_actor fa ON a.actor_id = fa.actor_id
	JOIN film f ON f.film_id = fa.film_id
	WHERE a.first_name = 'Nick' and a.last_name = 'Stallone'

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT f.title
	FROM actor a
	JOIN film_actor fa ON a.actor_id = fa.actor_id
	JOIN film f ON f.film_id = fa.film_id
	WHERE a.first_name = 'Rita' and a.last_name = 'Reynolds'


-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT f.title
	FROM actor a
	JOIN film_actor fa ON a.actor_id = fa.actor_id
	JOIN film f ON f.film_id = fa.film_id
	WHERE a.first_name = 'Judy' or a.first_name = 'River' and a.last_name = 'Dean'


-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT *
	FROM category c
	JOIN film_category fc ON c.category_id = fc.category_id
	JOIN film f ON f.film_id = fc.film_id
	WHERE c.name = 'Documentary'


-- 5. All of the ‘Comedy’ films
-- (58 rows)
SELECT *
	FROM category c
	JOIN film_category fc ON c.category_id = fc.category_id
	JOIN film f ON f.film_id = fc.film_id
	WHERE c.name = 'Comedy'

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT *
	FROM category c
	JOIN film_category fc ON c.category_id = fc.category_id
	JOIN film f ON f.film_id = fc.film_id
	WHERE c.name = 'Children' and  f.rating = 'G'


-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT *
	FROM category c
	JOIN film_category fc ON c.category_id = fc.category_id
	JOIN film f ON f.film_id = fc.film_id
	WHERE c.name = 'Family' and  f.rating = 'G' and f.length < 120


-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT f.title
	FROM actor a
	JOIN film_actor fa ON a.actor_id = fa.actor_id
	JOIN film f ON f.film_id = fa.film_id
	WHERE a.first_name = 'Matthew' and a.last_name = 'Leigh' and f.rating = 'G'


-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT f.title
	FROM category c
	JOIN film_category fc ON c.category_id = fc.category_id
	JOIN film f ON f.film_id = fc.film_id
	WHERE c.name = 'Sci-Fi' and f.release_year = 2006

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT f.title, a.first_name + ' ' +  a.last_name 'starring'
	FROM actor a
	JOIN film_actor fa ON fa.actor_id = a.actor_id
	JOIN film f ON f.film_id = fa.film_id
	JOIN film_category fc ON f.film_id = fc.film_id
	JOIN category c ON c.category_id = fc.category_id
	WHERE a.first_name = 'Nick' and a.last_name = 'Stallone' and c.name = 'Action'

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
SELECT a.address
	FROM store s
	JOIN address a ON s.address_id = a.address_id
	JOIN city c ON c.city_id = a.city_id
	JOIN country co ON c.country_id = co.country_id


-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
SELECT s.store_id, a.address, st.first_name, st.last_name
	FROM store s
	JOIN address a ON s.address_id = a.address_id
	JOIN city c ON c.city_id = a.city_id
	JOIN country co ON c.country_id = co.country_id
	JOIN staff st ON st.staff_id = s.manager_staff_id

-- 13. The first and last name of the top ten customers ranked by number of rentals
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
SELECT TOP(10)c.first_name + ' ' + c.last_name cust_name, COUNT(*) rentals
	FROM rental r
	JOIN customer c ON c.customer_id = r.customer_id
	GROUP BY c.first_name, c.last_name
	ORDER BY rentals DESC



-- 14. The first and last name of the top ten customers ranked by dollars spent
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)
SELECT TOP(10) c.first_name + ' ' + c.last_name cust_name, sum(p.amount) total_spent
	FROM customer c
	JOIN payment p ON c.customer_id = p.customer_id
	GROUP BY c.first_name, c.last_name
	ORDER BY total_spent DESC


-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that while a customer has only one primary store, they may rent from either store.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)
SELECT s.store_id, a.address, SUM(p.amount) 'total sales',  AVG(p.amount) 'avg sale', COUNT(*) rentals
	FROM rental r
	JOIN payment p ON r.rental_id = p.rental_id
	JOIN inventory i ON i.inventory_id = r.inventory_id
	JOIN store s ON s.store_id = i.store_id
	JOIN address a ON s.address_id = a.address_id
	GROUP BY s.store_id, a.address


-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT  TOP(10) f.title,  COUNT(*) 'Number of rentals'
	FROM rental r
	JOIN inventory i ON r.inventory_id = i.inventory_id
	JOIN film f ON f.film_id = i.film_id
	GROUP BY f.title
	ORDER BY [Number of rentals] DESC

-- 17. The top five film categories by number of rentals
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
SELECT TOP(5) c.name, COUNT(*) rentals
	FROM rental r
	JOIN inventory i ON r.inventory_id = i.inventory_id
	JOIN film f ON f.film_id = i.film_id
	JOIN film_category fc ON fc.film_id = f.film_id
	JOIN category c ON c.category_id = fc.category_id
	GROUP BY c.name
	ORDER BY rentals DESC


-- 18. The top five Action film titles by number of rentals
-- (#1 should have 30 rentals and #5 should have 28 rentals)
SELECT TOP(5) f.title, COUNT(*) rentals
	FROM rental r
	JOIN inventory i ON r.inventory_id = i.inventory_id
	JOIN film f ON f.film_id = i.film_id
	JOIN film_category fc ON fc.film_id = f.film_id
	JOIN category c ON c.category_id = fc.category_id
	WHERE c.name = 'Action'
	GROUP BY f.title
	ORDER BY rentals DESC

-- 19. The top 10 actors ranked by number of rentals of films starring that actor
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
SELECT TOP(10) a.first_name, a.last_name, COUNT(*) rentals
	FROM rental r
	JOIN inventory i ON i.inventory_id = r.inventory_id
	JOIN film f ON f.film_id = i.film_id
	JOIN film_actor fa ON fa.film_id = f.film_id
	JOIN actor a ON a.actor_id = fa.actor_id
	GROUP BY a.first_name, a.last_name, a.actor_id
	ORDER BY rentals DESC


-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor
-- (#1 should have 87 rentals and #5 should have 72 rentals)
SELECT TOP(5) COUNT(*) rentals
	FROM rental r
	JOIN inventory i ON r.inventory_id = i.inventory_id
	JOIN film f ON f.film_id = i.film_id
	JOIN film_category fc ON f.film_id = fc.film_id
	JOIN category c ON c.category_id = fc.category_id
	JOIN film_actor fa ON fa.film_id = f.film_id
	JOIN actor a ON a.actor_id = fa.actor_id
	WHERE c.name = 'comedy'
	GROUP BY a.actor_id
	ORDER BY rentals DESC

