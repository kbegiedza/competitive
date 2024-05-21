/**
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        if(n == 1)
        {
            return 1;
        }

        var low = 1;
        var high = n;
        var number = 0;

        while(true)
        {
            number = low + (high - low) / 2;
            var guessResult = guess(number);

            if(guessResult == -1)
            {
                high = number - 1;
            }
            else if(guessResult == 1)
            {
                low = number + 1;
            }
            else
            {
                return number;
            }
        }

        return number;
    }
}