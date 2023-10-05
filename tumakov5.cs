using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov5
{
    internal class Program
    {
        static int Max(int a, int b)
        {
            int result;
            if (a == b)
            {
                Console.WriteLine("числа равны, зай, переделай, пожалуйста");
            }
            if (a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }
        static int Swap(int e, int u)
        {
            int swap = e;
            e = u;
            u = swap;
            Console.WriteLine($"отныне первое число {e}, а второе число {u}");
            return 0;
        }  
            static bool Fact(ref uint v)
            {
                try
                {
                    checked 
                    {
                        uint t = 1;
                        for (uint i = 1; i <= v; i++)
                        {
                            t *= i;
                        }
                        v = t;
                    }
                }
                catch (OverflowException) 
                {
                    return false;
                }
                return true;
            }
        static uint Factorial(uint n)
        {
            try
            {
                if (n == 1 || n == 0)
                {
                    return 1;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("простите, вы ввели не тот формат");
            }
            return n * Factorial(n - 1);
        }
        static uint NOD(uint q, uint w)
        {
            if (q == 0 || w == 0)
            {
                Console.WriteLine("плохо");
            }
            while (q != w)
            {
                if (q > w)
                {
                    q -= w;
                }
                else
                {
                    w -= q;
                }
            }
            return q;
        }
        static uint NOD(uint l, uint j, uint g)
        {
            if (l == 0 || j == 0 || g == 0)
            {
                Console.WriteLine("грустно");
            }
            return NOD(NOD(l, j), g);
        }
        static uint Fib(uint h)
        {
                uint[] fib = new uint[100];
                if (h <= 1)
                    return 1;
                else if (fib[h] != 0)
                    return fib[h];
                fib[h] = Fib(h - 2) + Fib(h - 1);
                return fib[h];
         }
            static void Main(string[] args)
            {
                Console.WriteLine("упражнение 5.1");
            try
            {
                Console.WriteLine("введите первое число");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("введите второе число");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"максимальное число {Max(a, b)}");

                Console.WriteLine("упражнение 5.2");
                Console.WriteLine("введите первое число");
                int e = int.Parse(Console.ReadLine());
                Console.WriteLine("введите второе число");
                int u = int.Parse(Console.ReadLine());
                Console.WriteLine($"{Swap(e, u)}");

                Console.WriteLine("упражнение 5.3");
                Console.WriteLine("введите число");
                uint v = uint.Parse(Console.ReadLine());
                if (Fact(ref v))
                {
                   Console.WriteLine("факториал = " + v);
                }
                else
                {
                   Console.WriteLine("false");
                }

                Console.WriteLine("упражнение 5.4");
                Console.WriteLine("введите число");
                uint n = uint.Parse(Console.ReadLine());
                Console.WriteLine($"{Factorial(n)}");

                Console.WriteLine("домашнее задание 5.1");
                Console.WriteLine("введите первое число");
                uint q = uint.Parse(Console.ReadLine());
                Console.WriteLine("введите второе число");
                uint w = uint.Parse(Console.ReadLine());
                Console.WriteLine($"{NOD(q, w)}");

                Console.WriteLine("домашнее задание 5.1 с тремя числами");
                Console.WriteLine("введите первое число");
                uint l = uint.Parse(Console.ReadLine());
                Console.WriteLine("введите второе число");
                uint j = uint.Parse(Console.ReadLine());
                Console.WriteLine("введите третье число");
                uint g = uint.Parse(Console.ReadLine());
                Console.WriteLine($"{NOD(l, j, g)}");

                Console.WriteLine("домашнее задание 5.2");
                Console.WriteLine("введите число");
                uint h = uint.Parse(Console.ReadLine());
                Console.WriteLine($"{Fib(h)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("введён не подходящий формат");
            }
                Console.ReadKey();
            }
        }
    }