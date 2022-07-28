// 0. Начальный массив строк. Задан на старте программы, без пользовательского ввода во избежание пользовательских ошибок.

string[] NewArray = new string [] { "Sunday", "Mon", "Tuesday", "Wed", "Thursday", "Fri", "-2", ":-)" };

// 1. Метод подсчета элементов массива.

int CountElements(string[] inputArray)
{
    int result = 0;
    int length = inputArray.Length;
    for (int i=0; i<length; i++)
    {
        if (inputArray[i].Length <= 3) result++;
    }
    return result;
}


// 2. Основная задача. Метод поиска элементов с длиной не более 3 символов.

string[] MainMethodSortReturn(string[] inArray)
{
    int inArrayLength = CountElements(inArray);
    string[] outArray = new string[inArrayLength];
    int index = 0;
    int i;
    int length = inArray.Length;
    for (i = 0; i<length; i++)
        if (inArray[i].Length<=3)
        {
            outArray[index] = inArray[i];
            index += 1;
        }
    Console.WriteLine();
    return outArray;
}

// 3. Метод печати. 

string PrintArray(string[] array)
{
    int length = array.Length;
    string output = String.Empty;
    
    for (int i = 0; i < length; i++)
    {
        output = output + array[i]+" ";
    }
    int arrayLength = output.Length;
    return output;
}

// 4. Вывод данных в терминал.

string[] inputArray = NewArray;
string input = PrintArray(inputArray);
Console.WriteLine(input);

string[] outputArray = MainMethodSortReturn(inputArray);
string output = PrintArray(outputArray);
Console.WriteLine(output);

