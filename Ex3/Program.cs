/*
Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// функция получения положительного числа
// функция получения числа
// функция получения массива
// функция печати двумерного массива
// функция печати одномерного массива
// функция получения среднего арифметического каждого столбца

// функция получения положительного числа
int GetPositiveNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или число меньше 1, попробуй еще разочек:");
        }
    }
    return result;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число!");
        }
    }
    return result;
}

// функция получения массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}


// функция печати двумерного массива
void PrintTwoDimensionalArray(int[,] array)
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

// функция печати одномерного массива
void PrintOneDimensionalArray(double[] array)
{
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// функция получения среднего арифметического каждого столбца
double[] GetAveargeOfColumns(int[,] array)
{
    double [] averageValueOfColumns = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            averageValueOfColumns[j] += Math.Round(array[i,j]/Convert.ToDouble(array.GetLength(0)), 1);
        }
    }
    return averageValueOfColumns;
}

int m = GetPositiveNumber("Введите m: ");
int n = GetPositiveNumber("Введите n: ");
int minValue = GetNumber("Введите мин значение массива: ");
int maxValue = GetNumber("Введите мин значение массива: ");
int [,] array = GetArray(m, n, minValue, maxValue);
Console.WriteLine();
PrintTwoDimensionalArray(array);
Console.WriteLine();
double[] averageValueOfColumns = GetAveargeOfColumns(array);
PrintOneDimensionalArray(averageValueOfColumns);