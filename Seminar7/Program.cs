/*
//Задача 1.
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
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/


/*
//Задача 2.
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
            array[i,j] = i + j;
    
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
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

/*
//Задача 3.
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
}

void Quad2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2)
    {
        for(int j = 0; j < array.GetLength(1); j+=2)
            array[i,j] = array[j,j] * array[i,j];

        Console.WriteLine();
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Quad2dArray(myArray);
Show2dArray(myArray);
*/


//Задача 4.
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
}

int SumInHead(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sum = sum + array[i,i];
    }
    return sum;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int res = SumInHead(myArray);
Console.WriteLine($"{res}");