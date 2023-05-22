namespace Monte_Karlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pi();
            Console.WriteLine("Результат расчёта фигуры " + S1(1000));
        }
        static void Pi()
        {
            double n, k;
            double s, x, y;
            k = 0;
            n = 1000;
            Random r = new Random();
            for (int i = 1; i <= n; i++)
            {
                x = r.NextDouble();
                y = r.NextDouble();
                if (x * x + y * y <= 1)
                {
                    k = k + 1;
                }
            }
            s = 4 * (k / n);
            Console.WriteLine("Результат Пи = " + s);
            Console.WriteLine("Точное Пи=" + Math.PI);
        }
        public static double S1(double n)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = (r.NextDouble() * 20) - 5;
                double y = r.NextDouble();
                if ((y >= 0) && (y <= Math.Sin(x))) k++;
            }
            return (k / n) * 20;
        }
        public static double S2(double n)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = (r.NextDouble() * 10);
                double y = (r.NextDouble() * 10);
                if ((x / 2 <= y) && (x * (8 - x) / 2) >= y) k++;
            }
            return (k / n) * 100;
        }
        public static double S3(double n)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = (r.NextDouble() * 15);
                double y = (r.NextDouble() * 6);
                if (y >= ((x - 6) * (x - 6) / 6) && (y <= 6)) k++;
            }
            return (k / n) * 90;
        }
        public static double S4(double n)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = (r.NextDouble() * 15);
                double y = (r.NextDouble() * 4);
                if ((x / 5 <= y) && (x * (12 - x) / 9) >= y) k++;
            }
            return (k / n) * 60;
        }
        public static double S5(double n)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = (r.NextDouble() * 8);
                double y = (r.NextDouble() * 4);
                if (y >= (8 - x) / 8 && y <= (x * (8 - x) / 4)) k++;
            }
            return (k / n) * 32;
        }
        public static double S6(double n)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = (r.NextDouble() * 3);
                double y = (r.NextDouble() * 1);
                if (y >= (x - 2) * (x - 2) / 2 && y <= Math.Sin(x)) k++;
            }
            return (k / n) * 3;
        }
    }
}