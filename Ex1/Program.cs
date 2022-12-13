/*
Задача 47. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

// функция получения числа
// функция инициализации массива
// функция печати массива

// функция получения числа
int GetNumber(string message)
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
            Console.WriteLine("Ввели не число, или число меньше 1, попробуйте снова: ");
        }
    }
    return result;
}

// функция инициализации массива
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double [,] array = new double [m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(minValue + rnd.NextDouble() * (maxValue - minValue), 1);
        }
    }
    return array;
}

// функция печати массива
void PrintArray(double [,] array)
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

int m = GetNumber("Введите m: ");
int n = GetNumber("Введите n: ");
int minValue = GetNumber("Введте минимальное значение элемента: ");
int maxValue = GetNumber("Введиме максимальное значение элемента: ");
double [,] array = GetArray(m, n, minValue, maxValue);
Console.WriteLine();
PrintArray(array);

