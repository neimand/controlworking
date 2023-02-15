// Задание: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] myArray = new string[] {"hello", "2", "world", ":-)"};
PrintArray(myArray);
Console.WriteLine("----------------------");
string[] myArray2 = NewArray(myArray);
PrintArray(myArray2);



//-------------Методы--------------
string[] NewArray(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] resultArray = new string[count];
    count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            resultArray[count] = array[i];
            count++;
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}

