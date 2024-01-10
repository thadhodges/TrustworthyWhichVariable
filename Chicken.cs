using System;

public class Math
{
    public static void AddSixOddNumbers()
    {
        int sum = 0;
        int count = 0;
        int number = 1;
        
        while (count < 6)
        {
            if (number % 2 != 0)
            {
                sum += number;
                count++;
            }
            number++;
        }
        return sum;
    }
}