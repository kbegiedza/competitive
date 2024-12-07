-- PostreSQL
SELECT st.student_id, st.student_name, su.subject_name, COUNT(e.student_id) as "attended_exams"
FROM Students as st
CROSS JOIN Subjects as su
LEFT JOIN Examinations as e
    ON e.student_id = st.student_id
    AND e.subject_name = su.subject_name
GROUP BY st.student_id, su.subject_name, st.student_name, e.student_id
ORDER BY st.student_id, st.student_name
