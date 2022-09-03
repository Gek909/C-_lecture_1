int[] array = { 12, 42, 37, 44, 85, 46, 44, 71, 48 };

int n = array.Length;
int find = 44;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}