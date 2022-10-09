/*
//Задача 1
int FindBiggestDigit(int num)
{
    int max;

    int ed = num % 10;
    int dec = num / 10;

    if(ed > dec)
        max = ed;
    else
        max = dec;

    return max;
}

int number = new Random().Next(10, 100);
int biggestDigit = FindBiggestDigit(number);

Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

/*
//Задача 2. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
int TwoDigitNumber(int num)
{
    int result;

    int ed = num % 10;
    int dec = num / 100;

    result = dec * 10 + ed;

    return result;
}

int number = new Random().Next(100, 1000);
int digitNumber = TwoDigitNumber(number);

Console.WriteLine($"The biggest digit of {number} is {digitNumber}");
*/


//Задача 3. Напишите программу, которая принимает н вход число ипроверяет, кратно ли оно одновременно a и b.
bool MultipleNumber(int number, int a, int b)
{
    bool result;

    if (number % a == 0 && number % b == 0)
    {
        result = true;
    }
    else
    {
        result = false;
    }
    return result;
}

Console.Write("Imput a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput first divisior number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second divisior number: ");
int b = Convert.ToInt32(Console.ReadLine());

bool res = MultipleNumber(number, a, b);
Console.WriteLine(res);
