using System;

namespace PELLnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number:");
            string x = Console.ReadLine();
            n = Convert.ToInt32(x);
            if (n <= 2)
                Console.WriteLine(n);
            int a = 1;
            int b = 2;
            int c;
            Console.WriteLine("0");
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 3; i <= n; i++)
            {
                c = 2 * b + a;
                a = b;
                b = c;
                Console.WriteLine(b);
            }
            
        }
    }
}
