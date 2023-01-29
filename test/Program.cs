string[] array = new string[] {"gjr", "egslk", "24:)", "$5"};


int FindSizeNewArray (string[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] FillNewArray (string[] arr, int size)
{
    string[] newArray = new string[size];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            newArray[i] = arr[i];
        }
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}



int size = FindSizeNewArray(array);
Console.WriteLine(size);
PrintArray(array);