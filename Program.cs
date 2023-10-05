using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

enum GrouchinessLevel
{
    ОченьВорчливыйПердун,
    ВорчитТолькоНаБабку,
    ДобрейшийДедок
}

struct Ded
{
    public string name;
    public GrouchinessLevel Grouchiness;
    public string[] GrouchPhrases;
    public int BruisesFromBabka;

    public static byte CountBruises(Ded ded, params string[] swearWords)
    {
        byte bruises = 0;
        foreach (string Grouchphrases in ded.GrouchPhrases)
        {
            foreach (string swearWord in swearWords)
            {
                if (ded.GrouchPhrases.Contains(swearWord))
                {
                    bruises++;
                    break;
                }
            }
        }
        return bruises;
    }
}
class Program
{
    static void PrintArray(int[] numbers)
    {
        foreach (int i in numbers)
        {
            Console.WriteLine("{0} ", i);
        }
    }
    static void Numbers(byte a)
    {
        switch (a)
        {
            case 0:
                Console.WriteLine("#####");
                Console.WriteLine("#   #");
                Console.WriteLine("#   #");
                Console.WriteLine("#   #");
                Console.WriteLine("#   #");
                Console.WriteLine("#####");
                break;

            case 1:
                Console.WriteLine("  ## ");
                Console.WriteLine(" ### ");
                Console.WriteLine("# ## ");
                Console.WriteLine("  ## ");
                Console.WriteLine("#####");
                break;

            case 2:
                Console.WriteLine(" ####");
                Console.WriteLine("#   #");
                Console.WriteLine("  ## ");
                Console.WriteLine(" ##  ");
                Console.WriteLine("##   ");
                Console.WriteLine("#####");
                break;

            case 3:
                Console.WriteLine("#####");
                Console.WriteLine("    #");
                Console.WriteLine("#####");
                Console.WriteLine("    #");
                Console.WriteLine("#####");
                break;

            case 4:
                Console.WriteLine("#   #");
                Console.WriteLine("#   #");
                Console.WriteLine("#####");
                Console.WriteLine("    #");
                Console.WriteLine("    #");
                break;

            case 5:
                Console.WriteLine("#####");
                Console.WriteLine("#    ");
                Console.WriteLine("#####");
                Console.WriteLine("    #");
                Console.WriteLine("#####");
                break;

            case 6:
                Console.WriteLine("#####");
                Console.WriteLine("#    ");
                Console.WriteLine("#####");
                Console.WriteLine("#   #");
                Console.WriteLine("#####");
                break;

            case 7:
                Console.WriteLine("#####");
                Console.WriteLine("   ##");
                Console.WriteLine(" ### ");
                Console.WriteLine(" ##  ");
                Console.WriteLine("##   ");
                break;

            case 8:
                Console.WriteLine("#####");
                Console.WriteLine("#   #");
                Console.WriteLine("#####");
                Console.WriteLine("#   #");
                Console.WriteLine("#####");
                break;

            case 9:
                Console.WriteLine("#####");
                Console.WriteLine("#   #");
                Console.WriteLine("#####");
                Console.WriteLine("    #");
                Console.WriteLine("#####");
                break;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("задание 1");
        int[] ns = new int[20];
        Random rand = new Random();
        for (int i = 0; i < ns.Length; i++)
        {
            ns[i] = rand.Next(1, 100);
        }
        Console.WriteLine("исходный массив:");
        PrintArray(ns);
        try
        {
            Console.WriteLine("введите 2 числа");
            byte in1 = byte.Parse(Console.ReadLine());
            byte in2 = byte.Parse(Console.ReadLine());
            int a;
            a = ns[in1 - 1];
            ns[in1 - 1] = ns[in2 - 1];
            ns[in2 - 1] = a;
            Console.WriteLine("получившийся массив");
            PrintArray(ns);
        }
        catch (FormatException)
        {
            Console.WriteLine("неподходящий формат");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("слишком большой индекс");
        }
        Console.WriteLine("задание 3");
        Console.WriteLine("умоляю, введите число от 0 до 9, пожалуйста");
        try
        {
            byte m = byte.Parse(Console.ReadLine());
            Console.WriteLine("чтобы закрыть введите 'закрыть' или 'exit'");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit" || input.ToLower() == "закрыть")
            {
                Process.GetCurrentProcess().Kill();
            }
            else if (m > 9)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("error");
            }
            else
            {
                Numbers(m);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("неверный формат, будь внимательнее зай");
        }

        Console.WriteLine("задание 4");
        Ded[] deds = new Ded[5];
        deds[0] = new Ded
        {
            name = "карим",
            Grouchiness = GrouchinessLevel.ДобрейшийДедок,
            GrouchPhrases = new[] { "проститутки", "гады" },
            BruisesFromBabka = 0
        };
        deds[1] = new Ded
        {
            name = "илюша",
            Grouchiness = GrouchinessLevel.ВорчитТолькоНаБабку,
            GrouchPhrases = new[] { "дураки", "пилорасы" },
            BruisesFromBabka = 0
        };
        deds[2] = new Ded
        {
            name = "егор",
            Grouchiness = GrouchinessLevel.ДобрейшийДедок,
            GrouchPhrases = new[] { "алкашня", "наркоманы" },
            BruisesFromBabka = 0
        };
        deds[3] = new Ded
        {
            name = "марат",
            Grouchiness = GrouchinessLevel.ОченьВорчливыйПердун,
            GrouchPhrases = new[] { "пизжаболы", "уёьки" },
            BruisesFromBabka = 0
        };
        deds[4] = new Ded
        {
            name = "борис",
            Grouchiness = GrouchinessLevel.ОченьВорчливыйПердун,
            GrouchPhrases = new[] { "наркоманы", "юляди" },
            BruisesFromBabka = 0
        };
        string[] swearWords = { "пилорасы", "юляди", "уёьки", "пизжаболы" };
        for (int i = 0; i < deds.Length; i++)
        {
            int bruises = Ded.CountBruises(deds[i], swearWords);
            deds[i].BruisesFromBabka = bruises;
            Console.WriteLine($"дед {deds[i].name} получил {bruises} от бабки");
        }
        Console.ReadKey();
    }
}