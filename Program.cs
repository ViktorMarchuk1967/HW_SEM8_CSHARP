/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortRowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int max_num = array[i, 0];
        for (int k = 1; k < array.GetLength(1); k++)
        {
            max_num = array[i, k-1];
            for (int j = k; j < array.GetLength(1); j++)
                if (array[i, j] > max_num)
                {
                    max_num = array[i, j];
                    array[i, j] = array[i, k-1];
                    array[i, k-1] = max_num;
                    
                }

        }
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
SortRowArray(myArray);
Print2DArray(myArray);



/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/




/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/





/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/





/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
/*
int[,] Create2DArray(int rows, int cols)
{
   return new int[rows, cols];
}

void Print2DArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
       for (int j = 0; j < array.GetLength(1); j++)
           Console.Write($"{array[i, j]}\t");
       Console.WriteLine();
   }
}

int[,] Spiral(int n)
{
   int[,] result = new int[n, n];

   int pos = 1;
   int count = n;
   int value = -n;
   int sum = -1;

   while (count > 0)
   {
       value = -1 * value / n;
       for (int i = 0; i < count; i++)
       {
           sum += value;
           result[sum / n, sum % n] = pos++;
       }
       value *= n;
       count--;
       for (int i = 0; i < count; i++)
       {
           sum += value;
           result[sum / n, sum % n] = pos++;
       }
   }

   return result;
}

int[,] myArray = Spiral(4);
Print2DArray(myArray);
*/