-- Write your PostgreSQL query statement below
WITH invalid_tweets as (
    SELECT tweet_id, content
    FROM Tweets
    WHERE
        LENGTH(content) > 15
)

SELECT tweet_id
FROM invalid_tweets;