Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i<size; i=i+1)
    {
        Console.Write($"Input word {i+1}: ");
        words[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return words;
}
