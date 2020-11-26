using System;
using System.Collections.Generic;

namespace GradeBook
{
  
  class Program
  {
    static void Main (string[]args)
    {
        var numbers = new List<double>();
        numbers.Add(90.4);
        numbers.Add(43.3);
        numbers.Add(67.8);
        numbers.Add(43.3);
        var op=0.0;
        foreach(var num in numbers ){
            op+=num;
        }
        Console.WriteLine($"Sum is = {op}");
        Console.WriteLine($"Average is={op/numbers.Count}");
    }
  }
  
}
