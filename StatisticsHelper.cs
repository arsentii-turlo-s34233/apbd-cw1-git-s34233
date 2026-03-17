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
}