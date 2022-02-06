using System;
using System.Globalization;

namespace AdditionalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your bithdate dd/mm/yyyy ");
            DateTime bd = DateTime.Parse(Console.ReadLine());
            DateTime nextBD;
            if (bd.DayOfYear > DateTime.Now.DayOfYear)
                nextBD = new DateTime(DateTime.Now.Year, bd.Month, bd.Day);
            else
                nextBD = new DateTime(DateTime.Now.Year + 1, bd.Month, bd.Day);
            TimeSpan left = nextBD - DateTime.Now;
            Console.WriteLine($"{left.Days} left to your BD");
        }
    }
}
