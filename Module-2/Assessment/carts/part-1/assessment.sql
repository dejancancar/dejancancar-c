USE assessment;
GO

-- Select all the columns in cart where the username is kmilner1j
SELECT * FROM carts WHERE username = 'kmilner1j'

-- Select the id and name from cart_items where the item was added on or after Jan. 15, 2019 and the weight is null
SELECT id, name FROM cart_items WHERE added >= '2019/01/15'


-- Select username and the cookie_value from carts where the username isn't null, ordered by the created date, latest first

SELECT username, cookie_value
	FROM carts 
	WHERE username IS NOT NULL
	ORDER BY created DESC
	

-- Select the added date and the count of all the cart_items added on that date

SELECT added, COUNT(*) 'Items Added on Date'
	FROM cart_items
	GROUP BY added

-- Select the cart's username and created date and the cart_item's name for all carts created in the month of Sept. 2019

SELECT c.username, c.created, ci.name
	FROM carts c
	JOIN cart_items ci ON c.id = ci.id
	WHERE ci.added BETWEEN '2019/09/01' AND '2019/09/30'
