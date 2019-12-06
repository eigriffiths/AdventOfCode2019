using System;
using System.Linq;

namespace AoC2019.Days.Day02 {
    
    public class Day02Sol 
    {
        public void Part01()
        {
            // opcodes: 01 - adds, 02 - multiplies, 99 - halt

            var input = System.IO.File.ReadAllText("Days//Day02//input.txt").Split(',');
            //var opcodes = input.Select(int.Parse).ToArray();
            int[] opcodes = new int[] {1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50};
            var opcodePos = 0;

            for (int i = opcodes[opcodePos]; i != 99; opcodePos += 4)
            {
                switch (i)
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
                    default:
                        Console.WriteLine("ended");
                        break;
                }
            }
        }
    }
}