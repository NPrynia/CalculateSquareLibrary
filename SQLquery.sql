SELECT p.name,c.name
FROM product p LEFT JOIN product_category pc
ON p.id= pc.id_product LEFT JOIN category c
ON pc.id_category = c.id


