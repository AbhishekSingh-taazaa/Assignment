using System;

namespace TwoJoggersKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Kata.NumberOfLaps(8,4);

            Console.WriteLine(Kata.NumberOfLaps(5,3));
            Console.WriteLine(Kata.NumberOfLaps(4, 6));
            Console.WriteLine(Kata.NumberOfLaps(0, 0));
        }
    }
}
