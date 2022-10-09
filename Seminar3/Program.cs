/*
// Определение четверти оси координат.
int FindQuart(double x, double y)
{
    int quart = 0;

    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    
    return quart;
}

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The point a({x},{y}) is on the {FindQuart(x,y)} quart");
*/

/*
//1) Напишите программу, которая по заданному номеру четверти, показывает диапазон возможным координат точек в этой четверти (x и y)

void FindDiapozon(int quart)
{
    if(quart == 1) Console.WriteLine ("x > 0 && y > 0");
    if(quart == 2) Console.WriteLine ("x < 0 && y > 0");
    if(quart == 3) Console.WriteLine ("x < 0 && y < 0");
    if(quart == 4) Console.WriteLine ("x > 0 && y < 0");
}

Console.Write("Input quart: ");
int a = Convert.ToInt32(Console.ReadLine());
FindDiapozon(a);
*/

/*
//2) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
double Distance(double xa, double xb, double ya, double yb)
{
    return Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb-ya),2));
}

Console.WriteLine("Input xa-coordinate: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xa-coordinate: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xa-coordinate: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xa-coordinate: ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distance(xa, xb, ya, yb));
*/


//3) Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N (3= 1 4 9)
void WriteQ(int n)
{
    int count = 1;
    while(count <= n)
    {
        Console.WriteLine(Math.Pow(count,2));
        count++;
    }
}
Console.WriteLine("Input n number");
int n = Convert.ToInt32(Console.ReadLine());
WriteQ(n);
