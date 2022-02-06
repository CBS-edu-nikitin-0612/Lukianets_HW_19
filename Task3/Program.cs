using System;

namespace Task3
{
    enum Position
    {
        Trainee = 20,
        Junior = 40,
        Middle = 40,
        Senior = 44
    }

    internal class Accountant
    {
        public static bool AskForBonus(Position worker, int hours)
        {
            if (hours > (int)worker && Enum.IsDefined(typeof(Position), worker))
            {
                int bonus = hours * 100 / (int)worker - 100;
                Console.WriteLine($"Bonus should be: {bonus}%");
                return true;
            }
            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Accountant.AskForBonus(Position.Trainee, 22);
        }
    }
}
