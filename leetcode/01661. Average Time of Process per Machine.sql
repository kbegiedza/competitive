SELECT sub.machine_id, ROUND((SUM(processing_time) / COUNT(sub.machine_id))::numeric, 3) AS processing_time
FROM (
    SELECT a.machine_id, a.process_id, (b.timestamp - a.timestamp) AS processing_time
    FROM Activity AS a
    JOIN Activity AS b
        ON a.machine_id = b.machine_id
    WHERE
        a.process_id = b.process_id
        AND a.activity_type = 'start'
        AND b.activity_type = 'end'
) AS sub
GROUP BY sub.machine_id
ORDER BY processing_time
