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

/*
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
*/


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
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int n)
{
    return new int[n, n];
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

void FindMinSumRow(int[,] array, int max)
{
    int sumMin = max;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum_tek = 0;
        for (int j = 0; j < array.GetLength(1); j++) sum_tek += array[i, j];
        if (sumMin > sum_tek)
        {
            minRow = i;
            sumMin = sum_tek;
        }
    }
    Console.Write($"Строка с наименьшей суммой элементов: {minRow} строка\t");
}

int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");

int[,] myArray = Create2DArray(size);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
FindMinSumRow(myArray, maxValue * size);
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
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int n, int m)
{
    return new int[n, m];
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


void MatrixMultiplication(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        int[,] array3 = Create2DArray(array1.GetLength(0), array2.GetLength(1));
        for (int i = 0; i < array3.GetLength(0); i++)
        {
            for (int j = 0; j < array3.GetLength(1); j++)
            {
                int mult = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                    {
                        mult += array1[i, k] * array2[k, j];
                    }
                array3[i, j] = mult;
            }
        }
        Print2DArray(array3);
    }
    else Console.WriteLine("Произведения исходных матриц не существует.");
}

int rowsA = InputNum("Введите количество строк матрицы A: ");
int colsA = InputNum("Введите количество столбцов матрицы A: ");
int minValueA = InputNum("Введите минимальное значение диапазона матрицы A: ");
int maxValueA = InputNum("Введите максимальное значение диапазона матрицы A: ");

int rowsB = InputNum("Введите количество строк матрицы B: ");
int colsB = InputNum("Введите количество столбцов матрицы B: ");
int minValueB = InputNum("Введите минимальное значение диапазона матрицы B: ");
int maxValueB = InputNum("Введите максимальное значение диапазона матрицы B: ");

int[,] myArrayA = Create2DArray(rowsA, colsA);
int[,] myArrayB = Create2DArray(rowsB, colsB);

Fill2DArray(myArrayA, minValueA, maxValueA);
Print2DArray(myArrayA);
Fill2DArray(myArrayB, minValueB, maxValueB);
Print2DArray(myArrayB);
MatrixMultiplication(myArrayA, myArrayB);
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
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int n, int m, int z)
{
    return new int[n, m, z];
}

int[] CreateArray2Digit()
{
    return new int[90];
}

void FillArrayDat(int[] array)
{
    for (int i = 0; i < 90; i++) array[i] = i + 10;

    Random rand = new Random();

    for (int i = array.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);
        int tmp = array[j];
        array[j] = array[i];
        array[i] = tmp;
    }
}

void Fill3DArray(int[,,] array, int[] arrayDat)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = arrayDat[count++];
}

void Print3DArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write($"{array[i]}\t");
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }

int size1 = InputNum("Введите первую размерность матрицы: ");
int size2 = InputNum("Введите вторую размерность матрицы: ");
int size3 = InputNum("Введите третью размерность матрицы: ");


int[,,] myArray = Create3DArray(size1, size2, size3);
int[] myArrayDat = CreateArray2Digit();
FillArrayDat(myArrayDat);
//PrintArray(myArrayDat);
Fill3DArray(myArray, myArrayDat);
Print3DArray(myArray);
*/

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int n)
{
   return new int[n, n];
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

void Fill2DArraySpiral(int[,] array, int n)
{
   int pos = 1;
   int count = n;
   int value = -n;
   int sum = -1;

   while (count > 0)
   {
       value = -1 * value / n; //1, -1
       for (int i = 0; i < count; i++)
       {
           sum += value; //0, 1, 2, 3
           array[sum / n, sum % n] = pos++; // 0,0 0,1 0,2 0,3
       }
       value *= n; // 4
       count--; // 3
       for (int i = 0; i < count; i++)
       {
           sum += value; //7, 11, 15
           array[sum / n, sum % n] = pos++; // 1,3 2,3 3,3
       }
   }
}

int size = InputNum("Введите размер массива: ");
int[,] myArray = Create2DArray(size);
Fill2DArraySpiral(myArray, size);
Print2DArray(myArray);
