int[] a = {5,2,3,4,8,8,9,12};
InsertSort(a);
System.Console.WriteLine(LinearSearch(a, 12));

void InsertSort(int[] array)
{
    int index_clone, value_clone;

    for (int i = 0; i < array.Length; i++)
    {
        index_clone = i;
        value_clone = array[i];

        while (index_clone > 0 && array[index_clone - 1] > value_clone)
        {
            array[index_clone] = array[index_clone - 1];
            index_clone--; 
        }
        array[index_clone] = value_clone;
    }
}

int LinearSearch(int[] array, int k)
{
    for (int i = 0; i < array.Length && array[i] <= k; i++)
    {
        if(k == array[i])
            return i;
    }
    return -1;
}