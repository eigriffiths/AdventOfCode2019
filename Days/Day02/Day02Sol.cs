using System;
using System.Linq;

namespace AoC2019.Days.Day02 {
    
    public class Day02Sol 
    {
        public void Part01()
        {
            // opcodes: 01 - adds, 02 - multiplies, 99 - halt

            var input = System.IO.File.ReadAllText("Days//Day02//input.txt").Split(',');
            var opcodes = input.Select(int.Parse).ToArray();
            var opcodePos = 0;
            var inputValue = 0;

            while(inputValue != 99)
            {
                var firstValuePos = opcodes[opcodePos + 1];
                var secondValuePos = opcodes[opcodePos + 2];
                var thridValuePos = opcodes[opcodePos + 3];
                inputValue = opcodes[opcodePos];
                firstValuePos = opcodes[firstValuePos];
                secondValuePos = opcodes[secondValuePos];
                thridValuePos = opcodes[thridValuePos];

                switch (inputValue)
                {
                    case 1:
                        opcodes[thridValuePos] = firstValuePos + secondValuePos;
                        break;
                    case 2:
                        opcodes[thridValuePos] = firstValuePos * secondValuePos;
                        break;
                    case 99:
                        Console.WriteLine("99 reached...");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                opcodePos += 4;
            }

            
        }
    }
}