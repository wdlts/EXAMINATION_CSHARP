int size = 5; // Для экономии времени и во избежание ошибок при вводе размера массива пользователем, изначально задан размер массива 5.

string[] CreateStringArray() //Создание массива.
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

string[] MainMethodSortReturn(string[] array) // Поиск и возврат элементов массива с количеством символов не более 3.
{
    for (int i = 0; i<array.Length; i= i+1)
        if (array[i].Length<=3)
        {
            Console.Write (array[i] + " ");
        }
        Console.WriteLine();
        return array;
            
}