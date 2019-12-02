using System;

namespace AoC2019.Day01
{
    public class Day01Sol
    {
        public void Part01()
        {
            var input = System.IO.File.ReadLines("Day01\\input.txt");
            var totalFuel = 0;

            foreach (var mass in input)
            {
                var fuel = int.Parse(mass) / 3 - 2;
                totalFuel = totalFuel + fuel;
            }
            Console.WriteLine("Total fuel requirement: " + totalFuel);
        }

        public void Part02()
        {
            
        }
    }
}
