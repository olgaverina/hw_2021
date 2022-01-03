using static System.Console;

int[] CreateArray(int len)
{
    return new int[len];
}

int[] array = CreateArray(10);

int[] FillArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
        arr[i] = new Random().Next(-20, 20);
    return arr;
}
array = FillArray(array);

string PrintArray(int[] arr)
{
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++)
        res += $"{arr[i]} ";
    return res;
}

WriteLine(PrintArray(array));

int Count_Even(int[] arr)
{
    int length = arr.Length;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
}

int[] even_array = CreateArray(Count_Even(array));

void Remove_Odd(int[] arr, int[] even_arr)
{
    int length = arr.Length;
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            even_arr[j] = arr[i];
            j++;
        }     
    }               
}
Remove_Odd(array, even_array);
WriteLine(PrintArray(even_array));
