int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };
int temp = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length - 1 - i; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            temp = arr[j + 1];
            arr[j + 1] = arr[j];
            arr[j] = temp;
        }
    }
}
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}