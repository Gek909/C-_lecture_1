// 1 тип - Ничего не принимают и не возвращают

void Method1()
{
    Console.WriteLine("Автор ...");
}
// - отключил Method1();



// 2 тип - принимают, но не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Method21("Текст", 4);
// ИЛИ Method21(count: 4, msg: "Текст",);


//3 тип - возвращают, но не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// 4 тип - принимают и возвращают.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
// 
//     while (i < count)
//     {
//         result = result+text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
//string res = Method4(10, "asdf");
//Console.WriteLine(res);





// таблица умножения:
//for (int i = 2; i <= 10; i++)
//{
//    for (int j = 2; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} x {j} = {i * j}");
//    }
//    Console.WriteLine();
//}




//Замена символов в тексте:

//string text = "- Я думаю, - сказал  князь улыбаясь, - что, "
//+"ежели  бы  вас послали вместо нашего милого Винценгероде,"
//+ "вы бы взяли приступом согласие прусского короля. "
//+ "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
// s[3] // r

//string Replace(string text, char oldValue, char newValue)
//{
//    string result = String.Empty;
//
//    int length = text.Length;
//    for (int i = 0; i < length; i++)
//    {
//        if (text[i] == oldValue) result = result + $"{newValue}";
//        else result = result + $"{text[i]}";
//    }
//
//    return result;
//}
//
//string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(newText, 'к','К');
//Console.WriteLine(newText);




// Сортировка в массиве:

int[] array = { 1, 3, 6, 2, 6, 7, 3, 1, 6, };

// вывод массива на экран:
// 1 способ:

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}


PrintArray(array);
SelectionSort(array);

PrintArray(array);