// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter integers in a one line separated by commas (',')");
string input = Console.ReadLine();
string[] input_pieces = input.Split(',');
int[] numbers = new int[input_pieces.Length];
for (int i = 0; i< numbers.Length; i++)
{
    numbers[i] = int.Parse(input_pieces[i]);
}
