-- Write your PostgreSQL query statement below
SELECT t_u.user_id, INITCAP(t_u.name) AS "name"
FROM Users AS t_u