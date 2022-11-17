/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);
    Console.Write(n + " ");
}

ShowNums(5);
*/

/*
void PrintDigits(int n)
{
    if(n > 1) PrintDigits(n - 1);
    Console.WriteLine(n + " ");
}
*/

/*
int SumOfDigits(int num)
{
    if(num != 0) return SumOfDigits(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine(SumOfDigits(1234));
*/

/*
void PrintNums(int m, int n)

{
    if(m > n)
     {
        Console.Write(m + " ");
        PrintNums(m -1, n);
    }
    if(n > m) 
    {
        PrintNums(m, n - 1);
        Console.Write(n + " ");
    }
    if(m == n) Console.Write(m + " ");
}

int m = 5;
int n = 1;
PrintNums(m,n);
*/


double PowerAB(double a, double b)
{
    if(b < 0) return 1 / a * PowerAB(a, b +1);
    if(b > 0) return a*PowerAB(a, b -1);
    else return 1;
}

Console.WriteLine(PowerAB(2,-3));
