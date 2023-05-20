namespace Monte_Karlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, k;
            double s, x, y;
            k = 0;
            n = 1000;
            Random r = new Random();
            for (int i = 1; i <= n; i++)
            {
                x = r.NextDouble() * 4 - 2;
                y = r.NextDouble() * 4 - 2;
                if (x * x + y * y <= 4)
                {
                    k = k + 1;
                }
            }
            s = 4 * (k / n);
            Console.WriteLine("Результат Пи = " + s);
            Console.WriteLine("Точное Пи=" + Math.PI);
        }
    }
}