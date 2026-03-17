namespace apbd_cw1_git_s34233;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum+=numbers[i];
        }
        double result = (double) sum / numbers.Length;
        return result;
    }

    public static int CalculateMax(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    public static int CalculateMin(int[] numbers)
    {
        int min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

}