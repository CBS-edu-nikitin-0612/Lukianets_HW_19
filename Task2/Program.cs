using System;

namespace Task2
{

    internal static class StatClass
    {
        public static void Print(string stroka, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you string: ");
            string inputStr = Console.ReadLine();

            Array arr = Enum.GetValues(typeof(ConsoleColor));
            Console.WriteLine("\nChose color number:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"\t{arr.GetValue(i):D}. {arr.GetValue(i)}\n");

            int color = Int32.Parse(Console.ReadLine());
            StatClass.Print(inputStr, color);

        }
    }
}
