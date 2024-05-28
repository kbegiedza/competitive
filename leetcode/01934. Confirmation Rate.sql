-- Write your PostgreSQL query statement below
WITH Counts AS (
    SELECT s.user_id,
        COUNT(c.action)::numeric as total,
        COUNT(c.action) FILTER (WHERE c.action = 'confirmed')::numeric as confirmed
    FROM Signups AS s
    LEFT JOIN Confirmations AS c
        ON s.user_id = c.user_id
    GROUP BY s.user_id, s.time_stamp
)

SELECT c.user_id, ROUND(c.confirmed / GREATEST(c.total, 1), 2) AS confirmation_rate
FROM Counts AS c;