-- Write your PostgreSQL query statement below
WITH sub AS (
    SELECT t.teacher_id, t.subject_id, COUNT(t.teacher_id) as cnt
    FROM Teacher as t
    GROUP BY t.teacher_id, t.subject_id
)

SELECT sub.teacher_id, COUNT(sub.cnt) as cnt
FROM sub
GROUP BY sub.teacher_id