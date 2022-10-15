/*
int GetSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++)
        sum += current;

    return sum;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);

Console.WriteLine($"Sum of elements from 1 to {num} is {s}");
*/

/*
//Задача 1. Напишите программу торая принимае на вход число и выдает количество цифр в этом числе.
int NumbersOfDigit(int num)
{
    int div = 10;
    int current = 1;
    
    for(int n = num; n > 10; current++)
    {
        n = num / div;
        div *= 10;
    }
    return current;
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = NumbersOfDigit(num);
Console.WriteLine(res);
*/


/*
//Задача 2. Напишите программу которая принимает на вход число N и выдает произведение числел от 1 до N.
int GetFactoral(int n)
{
    int Factoral = 1;

    for(int cur = 1; cur <= n; cur++)
        Factoral *= cur;

    return Factoral;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int fact = GetFactoral(num);

Console.WriteLine(fact);
*/


//Задача 4. 
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    
    return newArray;
}
//
void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 1;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);