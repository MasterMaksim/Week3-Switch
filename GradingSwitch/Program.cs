﻿using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde te saite?");
            char userGrade = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userGrade)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");
                    break;
                case 'E':
                    Console.WriteLine("Kasin!");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik.");
                    break;
                default:
                    Console.WriteLine("Vale väärtus!");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
