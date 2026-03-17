// See https://aka.ms/new-console-template for more information

using apbd_cw1_git_s34233;
//New Comment
try
{
//<<<<<<< HEAD
    Console.WriteLine("Write integers in a one line separated by commas (',')");
//=======
    Console.WriteLine("Type integers in a one line separated by commas (',')");
//>>>>>>> feature-conflict
    string input = Console.ReadLine();
    string[] input_pieces = input.Split(',');
    int[] numbers = new int[input_pieces.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(input_pieces[i]);
    }
    StatisticsHelper.CalculateAverage(numbers);
    //StatisticsHelper.CalculateMax(numbers);
    StatisticsHelper.CalculateMin(numbers);
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
    Console.WriteLine("Example of correct input: 1, 2, 3, 4");
}
