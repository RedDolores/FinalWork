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

int size = FindSizeNewArray(array);
Console.WriteLine(size);