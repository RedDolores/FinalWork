string[] ReadArray()
{
    Console.WriteLine("Введите размер массива: ");
    int sizeOfArray = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[sizeOfArray];
    for (int i = 0; i < sizeOfArray; i++)
    {
        Console.WriteLine($"Введите {i + 1} эллемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;

}

int FindSizeNewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    if (count == 0) Console.WriteLine("В массиве нет элементов, удовлетворяющих условие.");
    return count;
}

string[] FillNewArray(string[] arr, int size)
{
    string[] newArray = new string[size];
    int i = 0;
    foreach (string item in arr)
    {
        if (item.Length <= 3)
        {
            newArray[i] = item;
            i++;
        }
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != string.Empty)
        {
            Console.Write($"{arr[i]} ");
        }
    }

}

string[] firstArray = ReadArray();

int sizeOfSecondArray = FindSizeNewArray(firstArray);

string[] secondArray = FillNewArray(firstArray, sizeOfSecondArray);

PrintArray(secondArray);

