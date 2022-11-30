string[] CreateStringArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} value: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

string[] ThreeSymbolsArray(string[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            k++;
        }
    string[] resultarray = new string[k];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            resultarray[j] = array[i];
            j++;
        }
    return resultarray;
}

void ShowArray(string[] array)
{
    Console.Write("Array is: ");

    for (int i = 0; i < array.Length; i++)
        if (i != array.Length - 1)
        Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    Console.Write("   <]:-o) \n");
}

Console.WriteLine("Input the number of rows: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateStringArray(sizeArray);
ShowArray(myArray);
string[] finalarray = ThreeSymbolsArray(myArray);
ShowArray(finalarray);