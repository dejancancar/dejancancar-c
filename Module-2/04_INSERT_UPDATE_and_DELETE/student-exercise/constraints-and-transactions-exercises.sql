-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT INTO actor (first_name, last_name)
	VALUES ('Hampton', 'Avenue'), ('Lisa', 'Byway')

SELECT * FROM actor

SELECT @@IDENTITY
--Hampton 201
--Lisa 202

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
INSERT INTO Film (title, description, release_year, language_id, length)
	VALUES ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in
-- ancient Greece', 2008, 1, 198)

SELECT * FROM film WHERE title = 'Euclidean PI'
SELECT @@IDENTITY
-- EUCLIDEAN PI - ID 1001

SELECT * FROM film WHERE title = 'Euclidean PI'

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
INSERT INTO film_actor (actor_id, film_id)
	VALUES (201, 1001), (202,1001)

SELECT * FROM film_actor WHERE actor_id = 201
SELECT @@IDENTITY

-- 4. Add Mathmagical to the category table.
INSERT INTO category (name)
	VALUES ('Mathmagical')

SELECT * FROM category WHERE name = 'Mathmagical'
SELECT @@IDENTITY

--Mathmagical - 17

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
INSERT INTO film_category (film_id, category_id)
	VALUES ((SELECT film_id FROM film WHERE title = 'Euclidean PI'), (SELECT category_id FROM category WHERE name = 'Mathmagical'))
INSERT INTO film_category (film_id, category_id)
	VALUES ((SELECT film_id FROM film WHERE title = 'EGG IGBY'), (SELECT category_id FROM category WHERE name = 'Mathmagical')),
	((SELECT film_id FROM film WHERE title = 'KARATE MOON'), (SELECT category_id FROM category WHERE name = 'Mathmagical')),
	((SELECT film_id FROM film WHERE title = 'RANDOM GO'), (SELECT category_id FROM category WHERE name = 'Mathmagical')),
	((SELECT film_id FROM film WHERE title = 'YOUNG LANGUAGE'), (SELECT category_id FROM category WHERE name = 'Mathmagical'))




-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

SELECT * FROM film where TITLE = 'egg igby'
UPDATE film SET rating = 'G' WHERE FILm_id in(SELECT film_id FROM film_category WHERE category_id = (SELECT category_id FROM category WHERE name = 'Mathmagical'))

SELECT * FROM film_category WHERE category_id = 17
commit transaction
-- 7. Add a copy of "Euclidean PI" to all the stores.
INSERT INTO inventory(film_id,store_id)
	VALUES ((SELECT film_id FROM film WHERE title = 'Euclidean PI'),1),
	((SELECT film_id FROM film WHERE title = 'Euclidean PI'),2)


-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
DELETE FROM film WHERE title = 'Euclidean PI'

-- <YOUR ANSWER HERE>
--Primary Key is referenced elsewhere by a foreign key so it is constrained and cannot be deleted
	--The film_Id is connected to the catergory_id in the film_category table, actors_id in the film_actor table, and inventory_id in the store table.
	--The error states that it is connected to the film_actor table through film_id

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
DELETE FROM category WHERE name = 'Mathmagical'
-- <YOUR ANSWER HERE>
	--Same as above primary key is referenced by a foreign key in film_category
	--Error says that its connected in the film_category through catergory_id

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
DELETE FROM film_category WHERE category_id = (SELECT category_id FROM category WHERE name = 'Mathmagical')
-- <YOUR ANSWER HERE>
	--we are deleting the forign key from the primary key of category so you are not constrained.

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
DELETE FROM category WHERE name = 'Mathmagical'
DELETE FROM film WHERE title = 'Euclidean PI'
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>
	--the primary key in the category table is not referenced anywhere else so Mathmagical is able to be deleted.
	--The film_id (primary key) is still referenced in the inventory table and actor_film tables.


-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
	--The only other constraint seems to be on the film_actor table, so to remove Euclidean PI from film you would first have to remove the reference in film_actor
	--after further looking at it the PK film_id is the restraint. film_id was also refereced in inventory so it would need to be removed there as well first.


