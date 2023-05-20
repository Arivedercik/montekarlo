namespace montekarlo
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Вычисление значения числа π методом Монте-Карло \n2. Вычисление площади фигуры методом Монте-Карло");
                int answer = Convert.ToInt32(Console.ReadLine());
                double s;
                int n;
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Введите число повторений -> ");
                        n = Convert.ToInt32(Console.ReadLine());
                        s = Circle(n);
                        Console.WriteLine("Результат pi = " + s);
                        Console.WriteLine("Точно pi = " + Math.PI);
                        break;
                    case 2:
                        Console.WriteLine("Введите число повторений -> ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите ширину базового прямоугольника -> ");
                        double b = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Введите высоту базового прямоугольника -> ");
                        double a = Convert.ToSingle(Console.ReadLine());
                        s = Rectangle(n,a, b);
                        Console.WriteLine("Результат s = " + s);
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
            double k=0;
            for (int i = 1; i < n; i++)
            {
                Random rnd = new Random();
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
            for (int i = 1; i < n; i++)
            {
                double x = (rnd.NextDouble() * 4) - 2;
                double y = (rnd.NextDouble() * 4) - 2;
                if ((x / 3 < y) && (y < x * (10 - x) / 5))
                {
                    k++;
                }
            }
            return (a * b * k) / n;
        }
    }
}