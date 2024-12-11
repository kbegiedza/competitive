SELECT
    r.contest_id,
    ROUND((COUNT(u.user_id)::decimal / (SELECT COUNT(*) FROM Users)) * 100, 2) AS "percentage"
FROM
    Register as r
LEFT JOIN
    Users as u
    ON r.user_id = u.user_id
GROUP BY
    r.contest_id
ORDER BY
    "percentage" DESC,
    r.contest_id ASC;
