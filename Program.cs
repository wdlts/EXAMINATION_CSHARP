int size = 5; // Для экономии времени и во избежание ошибок при вводе размера массива пользователем, изначально задан размер массива 5.

string[] CreateStringArray(int size) //Создание массива.
{
    string[] arraywords = new string[size];

    for (int i = 0; i<size; i=i+1)
    {
        Console.Write($"Input word {i+1}: ");
        arraywords[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return arraywords;
}

string[] MainMethodSortReturn(string[] array) // Поиск и возврат элементов массива с количеством символов не более 3.
{
    
    
    for (int i = 0; i<size; i= i+1)
        if (array[i].Length<=3)
        {
            Console.Write (array[i] + " ");
            
        }
        Console.WriteLine();
        return array;
            
}

void ShowArray(string[] array) // Вывод созданного массива.
{
    for (int i = 0; i<size; i=i+1)
        Console.Write (array[i] + " ");
    Console.WriteLine();
}

string[] array = CreateStringArray();
ShowArray(array);
MainMethodSortReturn(array);