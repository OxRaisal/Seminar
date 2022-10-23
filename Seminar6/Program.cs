/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int [] CreateRandomArray()
{
    Console.Write("Imput a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(min, max +1);
    return newArray;
}

void ReverseArray(int[] array)
{
    for(int i = 0, last = array.Length -1; i < last; i++, last--)
    {
        int temp = array[i];
        array[i] = array[last];
        array[last] = temp;
    }
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/


//Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник с сторонами

bool ExistanceTriangle(double a, double b, double c)
{
    return a < b +c && b < a + c && c < a + b;
}

Console.Write("Введите размер стороны А >: ");
double sideA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите размер стороны В >: ");
double sideB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите размер стороны С >: ");
double sideC = Convert.ToDouble(Console.ReadLine());
bool resTask1 = ExistanceTriangle(sideA, sideB, sideC);
if (resTask1) Console.Write("Треугольник существует!");
else Console.Write("Треугольник не существует!");
bool check = a == b;


/*
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int [] MakeRandomIntArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение для генерации: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение для генерации: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(min, max +1);
    return newArray;
}

void PrintInArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] Copy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
      Copy[i] = array[i];
    return Copy;
}

int[] arrTask2 = MakeRandomIntArray();
Console.Write("Первый массив: ");
PrintInArray(arrTask2);
int[] copyArrTask2 = CopyArray(arrTask2);
PrintInArray(arrTask2);
*/

/*
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи a и b.

int[] Fibonacci(int n, int a, int b)
{
    int[] fibArray = new int[n];
    fibArray[0] = a;
    fibArray[1] = b;

    for (int i = 2; i < fibArray.Length; i++)
        fibArray[i] = fibArray[i-1] + fibArray[i-2];
    
    return fibArray;
}

void PrintInArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Введите размер ряда Фибоначчи >: ");
int fibN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число ряда Фибоначчи >: ");
int fibA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ряда Фибоначчи >: ");
int fibB = Convert.ToInt32(Console.ReadLine());

int[] arrTask3 = Fibonacci(fibN, fibA, fibB);
PrintInArray(arrTask3);
*/