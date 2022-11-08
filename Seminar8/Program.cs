/*

int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible  value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j =0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0) - 1; i++)
            for(int j = i +1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
    }
    else
        Console.WriteLine("It`s impossible!!!!");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ChangeArray(myArray);
Show2dArray(myArray);
*/

/*
//Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и посл строку массива.

int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible  value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j =0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void RowsColumsChangeArray(int[,] array)
{

    for(int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
RowsColumsChangeArray(myArray);
Show2dArray(myArray);
*/


//Задача 2. Из двумерного массива целых чисел удалить строку и столбец,
//на пересечении которых расположен наименьший элемент.

int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible  value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j =0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FindMinInArray(int[,] array)
{
    int min = array[0, 0];
    int iMin = 0;
    int jMin = 0;

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < min)
            {
                iMin = i;
                jMin = j;
                min = array[i,j];
            }
        }
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

        for(int i = 0, m = 0; i < array.GetLength(0); i++, m++)
        {
            if(i == iMin)
            {
                m--;
                continue;
            }

            for(int j = 0, n = 0; j < array.GetLength(1); j++, n++)
            {
                if(j == jMin)
                {
                    n--;
                    continue;
                }
                newArray[m,n] = array[i,j];
            }
        }
    return newArray;
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[,] newArray = FindMinInArray(myArray);
Show2dArray(newArray);

