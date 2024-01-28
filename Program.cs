using System.Globalization;

void Task1()
{
    Console.Clear();
    Console.WriteLine("Задача 1:");

    char[,] chars = { { 'h', 'e', 'l', 'l', 'o' }, { 'w', 'o', 'r', 'l', 'd' } };

    Console.WriteLine("Исходный массив:");
    string str = "";
    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            Console.Write($"{chars[i, j]}\t");
            str += chars[i, j];
        }
        Console.WriteLine();
    }
    Console.WriteLine("Полученная строка - " + str);
    Console.WriteLine("Нажите любую кнопку");
    Console.ReadLine();
}

void Task2()
{
    Console.Clear();
    Console.WriteLine("Задача 2:");
    string str = "HeLLo WorLD";
    Console.WriteLine($"Исходная строка - {str}");
    string newStr = str.ToLower();
    Console.WriteLine($"Полученная строка - {newStr}");
    Console.WriteLine("Нажите любую кнопку");
    Console.ReadLine();
}

bool IsPalindrome(string str)
{
    bool flag = true;
    str = str.Replace(" ", "").ToLower();

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
        {
            flag = false;
        }
    }
    return flag;
}

void PrintResultTask3(string input, bool flag)
{
    if (flag)
    {
        Console.WriteLine($"\"{input}\" является палиндромом");
    }
    else
    {
        Console.WriteLine($"\"{input}\" не является палиндромом");
    }
}
void Task3()
{
    Console.Clear();
    Console.WriteLine("Задача 3:");
    string input = "А роза упала на лапу Азора";
    bool flag = IsPalindrome(input);

    PrintResultTask3(input, flag);

    input = "Это явно не палиндром";
    flag = IsPalindrome(input);

    PrintResultTask3(input, flag);

    Console.WriteLine("Нажите любую кнопку");
    Console.ReadLine();
}

void Task4()
{
    Console.Clear();
    Console.WriteLine("Задача 4:");
    string str = "мама мыла раму сама";
    Console.WriteLine($"Исходная строка - {str}");

    string [] stringArray = str.Split(" ");
    Array.Reverse(stringArray);

    string newStr = string.Join(" ", stringArray);

    Console.WriteLine($"Полученная строка - {newStr}");
    Console.WriteLine("Нажите любую кнопку");
    Console.ReadLine();
}

Task1();
Task2();
Task3();
Task4();