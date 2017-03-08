using System;
using static System.Console;

namespace FibonacciFun {

  class Program {
    public static void Main() {
      //declare variables to store sequence
      double a = 0;
      double b = 1;
      double c = 0;
      double goldenRatio;
      var userInput = 0;

      //take input from user and store in variable
      WriteLine("Enter a number between 0 and 2147483647");
      try {
        userInput = int.Parse(ReadLine());
      }
      catch (Exception) {
        Write("\nSomething went wrong, please try again\n");
        Main();
      }


      //output for start of sequence
      WriteLine(a);
      WriteLine(b);

      while (c <= userInput) {
        goldenRatio = b / a;
        c = a + b;
        if (c <= userInput) WriteLine(c + "=" + goldenRatio);
        else break;

        a = b;
        b = c;
      }

      
      ReadKey(true);

    }
  }
}
