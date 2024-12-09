-- Write your PostgreSQL query statement below
SELECT t_u.user_id, UPPER(LEFT(t_u.name, 1)) || LOWER(SUBSTRING(t_u.name FROM 2)) AS "name"
FROM Users AS t_u
ORDER BY t_u.user_id
