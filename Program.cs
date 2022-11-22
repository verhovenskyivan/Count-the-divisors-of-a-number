public class Kata
{
    public static int Divisors(int n)
    {
        // todo
        var numberOfDivisors = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                numberOfDivisors++;
            }
        }
        return numberOfDivisors;
    }
}