using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde te saite?");
            char userGrade = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userGrade == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userGrade == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userGrade == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userGrade == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
            else if (userGrade == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if (userGrade == 'F')
            {
                Console.WriteLine("Puudulik.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
