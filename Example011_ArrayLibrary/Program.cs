void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    //Для того, чтобы избежать отображения элемента, не входящего в массив, используется -1 ниже:
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;

    }
    return position;
}

int[] array = new int[10];

FillArray(array);
//принудительно добавим 4ки:
array [4] = 4;
array [6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 6);
Console.WriteLine(pos);
