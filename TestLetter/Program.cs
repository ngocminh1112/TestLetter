using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "cabbage";
            //Process
            var cal = new Calculator();

            var result = cal.LetterPoint(s);
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }

        

    }

    public class Calculator
    {
        public int LetterPoint(string s)
        {
            /*
             * Letter                           Value
                A,E, I, O, U, L, N, R, S, T       1
                D, G                               2
                B, C, M, P                         3
                F, H, V, W, Y                      4
                K                                  5
                J, X                               8
                Q, Z                               10

             */
            int result = 0;
            s = s.ToUpper();
            foreach (var c in s)
            {
                switch (c)
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'L':
                    case 'N':
                    case 'R':
                    case 'S':
                    case 'T':
                        result += 1;
                        break;
                    case 'D':
                    case 'G':
                        result += 2;
                        break;
                    case 'B':
                    case 'C':
                    case 'M':
                    case 'P':
                        result += 3;
                        break;
                    case 'F':
                    case 'H':
                    case 'V':
                    case 'W':
                    case 'Y':
                        result += 4;
                        break;
                    case 'K':
                        result += 5;
                        break;
                    case 'J':
                    case 'X':
                        result += 8;
                        break;
                    case 'Q':
                    case 'Z':
                        result += 10;
                        break;

                }

            }
            return result;
        }
    }
}
