/*
Задача 50. 
Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

// функция получения положительного числа
// функция получения числа
// функция получения массива
// функция печати массива
// функция получения значения требуемого элемента

// функция получения положительного числа
int GetPositiveNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или введенное число меньше 1, попробуйте еще разок: ");
        }
    }
    return result;
}

// функция получения числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели совсем не число, попробуйте еще разок: ");
        }
    }
    return result;
}

// функция получения массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int [,] array = new int [m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.Next(minValue, maxValue);
        }
    } 
    return array;
}

// функция печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

// функция получения значения требуемого элемента
void GetElementValue(int[,] array, int i, int j)
{
    if (i <= array.GetLength(0) && j <= array.GetLength(1))
    {
        Console.WriteLine($"Элемент существует и равен {array[i-1,j-1]}.");
    }
    else
    {
        Console.WriteLine("Такого элемента нету");
    }
}

int m = GetPositiveNumber("Введите m: ");
int n = GetPositiveNumber("Введите n: ");
int minValue = GetNumber("Введите минимальное значение массива: ");
int maxValue = GetNumber("Введите максимальное значение массива: ");
int i = GetPositiveNumber("Введите i: ");
int j = GetPositiveNumber("Введите j: ");
int[,] array = GetArray(m, n, minValue, maxValue);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
GetElementValue(array, i, j);