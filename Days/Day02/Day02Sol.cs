using System;
using System.Linq;

namespace AoC2019.Days.Day02 {
    
    public class Day02Sol 
    {
        public void Part01()
        {
            // opcodes: 01 - adds, 02 - multiplies, 99 - halt

            var input = System.IO.File.ReadAllText("Days//Day02//input.txt").Split(',');
            var data = input.Select(int.Parse).ToArray();

            var opcode = 0;
            var input1Pos = data[opcode + 1];
            var input2Pos = data[opcode + 2];
            var outputPos = data[opcode + 3];

            while(true)
            {
                calc(opcode, input1Pos, input2Pos);
                outputPos += 4;
            }
        }

        public bool calc(int opcode, int input1Pos, int input2Pos)
        {
            switch (opcode)
            {
                case 1:
                    data[outputPos] = input1Pos + input2Pos; return false;
                case 2:
                    data[outputPos] = input1Pos * input2Pos; return false;
                case 99:
                    return true;
            }
        }
    }
}