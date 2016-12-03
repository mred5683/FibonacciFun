using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FibonacciFun
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables to store sequence
            var a = 0;
            var b = 1;
            var c = 0;

            //take input from user and store in variable
            WriteLine("Enter a number");
            var userInput = int.Parse(ReadLine());

            //output for start of sequence
            WriteLine(a);
            WriteLine(b);

            while (c <= userInput)
            {
                c = a + b;
                if (c <= userInput)
                {
                    WriteLine(c);
                }
                else
                {
                    break;
                }
                a = b;
                b = c;
            }

            a = 0;
            b = 1;
            c = 0;

            while (c <= userInput)
            {
                c = a + b;

                if (c == userInput)
                {
                    goto IsFib;
                }

                a = b;
                b = c;
            }
            if (c != userInput)
            {
                goto IsNotFib;
            }

            IsFib:
                WriteLine("True");
                goto Finish;
            IsNotFib:
                WriteLine("False");
            Finish:
                WriteLine("Sequence Complete!!!");
        }
    }
}
