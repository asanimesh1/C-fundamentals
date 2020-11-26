using System;

namespace GradeBook
{
  
  class Program
  {
    static void Main (string[]args)
    {
        var numbers = new [] {33.3,22.7,88.5};
        var op=0.0;
        foreach(var num in numbers ){
            op+=num;
        }
        Console.WriteLine($"Sum is = {op}");
    }
  }
  
}
