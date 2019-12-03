using System;

namespace AoC2019.Days.Day02 {
    
    public class Day02Sol 
    {
        public void Part01()
        {
            // opcodes: 01 - adds, 02 - multiplies, 99 - halt

            string[] input = System.IO.File.ReadAllLines("Days//Day02//input.txt");
            foreach (string line in input)
            {
                string[] col = line.Split(',');
            }

            switch (1)
            {
                case 1:
                // Replace
                    Console.WriteLine("opcode 1");
                    break;
                case 2:
                // Replace
                    Console.WriteLine("opcode 2");
                    break;
                case 99:
                    break;
            }
        }
    }
}