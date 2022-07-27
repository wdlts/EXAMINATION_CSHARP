int size = 5; // Для экономии времени и во избежание ошибок при вводе размера массива пользователем, изначально задан размер массива 5.

// 1. Метод создания/заполнения массива..
string[] CreateStringArray(int size) 
{
    string[] arraywords = new string[size];

    for (int i = 0; i<size; i++)
    {
        Console.Write($"Input word {i+1}: ");
        arraywords[i] = Console.ReadLine()+"";
    }
    Console.WriteLine();
    return arraywords;
}

// 2. Основная задача. Метод поиска элементов с длиной не более 3 символов.

string[] MainMethodSortReturn(string[] inputArray) // Поиск элементов массива с количеством символов не более 3 и возврат массива из найденных элементов.
{
    string[] outputArray = new string[size];
    int index = 0;
    for (int i = 0; i<size; i++)
        if (inputArray[i].Length<=3)
        {
            outputArray[index] = inputArray[i];
            index += 1;
        }
        Console.WriteLine();
    return outputArray;
}

// 3. Методы вывода массива.

// 3.1 Метод вывода в консоль.

void ShowArray(string[] array) // Вывод созданного массива в консоль.
{
    for (int i = 0; i<size; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

// 3.2 Метод вывода в файл.

string PrintToFile(string[] array)
{
    int length = array.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i++)
    {
        output += ($"{array[i]}"+" ");
    }
    return output;
}

// 4. Вывод данных в терминал и файлы.

string[] inputArray = CreateStringArray(size);
ShowArray(inputArray);
string[] outputArray = MainMethodSortReturn(inputArray);
ShowArray(outputArray);
File.WriteAllText("input.txt", PrintToFile(inputArray));
File.WriteAllText("output.txt", PrintToFile(outputArray));
