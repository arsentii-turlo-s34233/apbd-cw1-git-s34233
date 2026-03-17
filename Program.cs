// See https://aka.ms/new-console-template for more information

using apbd_cw1_git_s34233;

try
{
    Console.WriteLine("Enter integers in a one line separated by commas (',')");
    string input = Console.ReadLine();
    string[] input_pieces = input.Split(',');
    int[] numbers = new int[input_pieces.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(input_pieces[i]);
    }
    StatisticsHelper.CalculateAverage(numbers);
    //StatisticsHelper.CalculateMax(numbers);
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
    Console.WriteLine("Example of correct input: 1, 2, 3, 4");
}
