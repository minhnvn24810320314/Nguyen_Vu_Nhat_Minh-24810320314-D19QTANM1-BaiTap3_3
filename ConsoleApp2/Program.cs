using System;
using System.Text;

namespace BaiTap3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("KIỂM TRA SỐ NGUYÊN TỐ, SỐ HOÀN HẢO VÀ DÃY FIBONACCI");

            Console.Write("Nhập số nguyên dương N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(n))
            {
                Console.WriteLine($"{n} là Số nguyên tố!");
            }
            else
            {
                Console.WriteLine($"{n} KHÔNG là Số nguyên tố.");
            }

            if (IsPerfectNumber(n))
            {
                Console.WriteLine($"{n} là Số hoàn hảo!");
            }
            else
            {
                Console.WriteLine($"{n} KHÔNG là Số hoàn hảo.");
            }

            PrintFibonacci(n);

            Console.ReadLine();
        }

        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static bool IsPerfectNumber(int n)
        {
            if (n <= 0) return false;
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum == n;
        }

        static void PrintFibonacci(int n)
        {
            if (n <= 0) return;

            Console.Write($"Dãy Fibonacci {n} số: ");

            long a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    Console.Write(a);
                }
                else
                {
                    Console.Write(a + ", ");
                }

                long next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine();
        }
    }
}
