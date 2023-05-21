namespace montekarlo
{
internal class Program
{
static void Main(string[] args)
{
while (true)
{
Console.WriteLine("1. Вычисление значения числа ПИ методом Монте-Карло \n2. Вычисление площади фигуры методом Монте-Карло\n3. ПРАКТИКА");
Console.Write("Ответ: ");
int answer = Convert.ToInt32(Console.ReadLine());
double s=0;
int n;
//aaa
switch (answer)
{
case 1:
Console.WriteLine("Введите число повторений -> ");
Console.WriteLine("Ответ: 1000000");
//n = Convert.ToInt32(Console.ReadLine());
n=1000000;
s = Circle(n);
Console.WriteLine("Результат pi = " + s);
Console.WriteLine("Точно pi = " + Math.PI);
break;
case 2:
Console.WriteLine("Введите число повторений -> ");
Console.WriteLine("Ответ: 1000000");
//n = Convert.ToInt32(Console.ReadLine());
n=1000000;
Console.Write("Введите ширину базового прямоугольника -> ");
double b = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите высоту базового прямоугольника -> ");
double a = Convert.ToSingle(Console.ReadLine());
s = Rectangle(n,a, b);
Console.WriteLine("Результат s = " + s);
break;
case 3:
Console.WriteLine("Введите число повторений -> ");
Console.WriteLine("Ответ: 1000000");
//n = Convert.ToInt32(Console.ReadLine());
n=1000000;
Working1(n);
Working2(n);
Working3(n);
Working4(n);
Working5(n);
Working6(n);
break;
}
Console.WriteLine("Повтор дейсвий? (1 - да | 2 - нет)");
if (Convert.ToInt32(Console.ReadLine()) == 2)
{
break;
}
}
}
static double Circle(int n)
{
Random rnd = new Random();
double k=0;
for (int i = 0; i < n; i++)
{
double x = (rnd.NextDouble()*4)-2;
double y = (rnd.NextDouble() * 4) - 2;
if (x * x + y * y <= 4)
{
k++;
}
}
return 4 * (k / n);
}
static double Rectangle(int n, double a, double b)
{
Random rnd = new Random();
double k = 0;
for (int i = 0; i < n; i++)
{
double x = (rnd.NextDouble()*9);
double y = (rnd.NextDouble()*5);
if ((x / 3 <= y) && (y <= (x * (10 - x) )/ 5))
{
k++;
}
}
return (k / n)*45;
}
static void Working1(int n)
{
Random rnd = new Random();
double k = 0;
for (int i = 0; i < n; i++)
{
double x = (rnd.NextDouble()*20)-5;
double y = rnd.NextDouble();
if (y<=Math.Sin(x) && y>=0)
{
k++;
}
}
double s = (k / n)*20;
Console.WriteLine("Решение 1. S = "+s);
}
static void Working2(int n)
{
Random rnd = new Random();
double k = 0;
for (int i = 0; i < n; i++)
{
double x = (rnd.NextDouble() * 10);
double y = (rnd.NextDouble() * 10);
if (y<=(x*(8-x))/2 && y>=x/2)
{
k++;
}
}
double s = (k / n)*100;
Console.WriteLine("Решение 2. S = "+s);
}
static void Working3(int n)
{
Random rnd = new Random();
double k = 0;
for (int i = 0; i < n; i++)
{
double x = (rnd.NextDouble() * 15);
double y = (rnd.NextDouble() * 6);
if (y>=Math.Pow((x-6),2)/6 && y<=6)
{
k++;
}
}
double s = (k / n)*90;
Console.WriteLine("Решение 3. S = "+s);
}
static void Working4(int n)
{
Random rnd = new Random();
double k = 0;
for (int i = 0; i < n; i++)
{
double x = (rnd.NextDouble() * 15);
double y = (rnd.NextDouble() * 4);
if (y<=(x*(12-x))/9 && y>=x/5)
{
k++;
}
}
double s = (k / n)*60;
Console.WriteLine("Решение 4. S = "+s);
}
static void Working5(int n)
{
Random rnd = new Random();
double k = 0;
for (int i = 0; i < n; i++)
{
double x = (rnd.NextDouble() * 8);
double y = (rnd.NextDouble() * 4);
if (y<=(x*(8-x))/4 && y>=(8-x)/8)
{
k++;
}
}
double s = (k / n)*32;
Console.WriteLine("Решение 5. S = "+s);
}
static void Working6(int n)
{
Random rnd = new Random();
double k = 0;
for (int i = 0; i < n; i++)
{
double x = (rnd.NextDouble() * 3);
double y = (rnd.NextDouble() * 1);
if (y<=Math.Sin(x) && y>=Math.Pow((x-2),2)/2)
{
k++;
}
}
double s = (k / n)*3;
Console.WriteLine("Решение 6. S = "+s);
}
}
}
