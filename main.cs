using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    string[] lines = System.IO.File.ReadAllLines(@"pairs.txt");

    int overlaps = 0;
    string[] pairData = {""};
    foreach(string input in lines) {
      pairData = input.Split(new Char [] {',' , '-' });
      int[] ranges = {Convert.ToInt32(pairData[0]), 
                      Convert.ToInt32(pairData[1]), 
                      Convert.ToInt32(pairData[2]), 
                      Convert.ToInt32(pairData[3])};

      if ((ranges[0] <= ranges[3] && ranges[0] >= ranges[2])|| 
          (ranges[1] >= ranges[2] && ranges[0] <= ranges[3]))
      {
        overlaps++;
        Console.WriteLine("{0}-{1},{2}-{3} overlaps",ranges[0], ranges[1], ranges[2], ranges[3]);
      } else {
        Console.WriteLine("{0}-{1},{2}-{3}",ranges[0], ranges[1], ranges[2], ranges[3]);
      }
    }
    Console.WriteLine("Overlaps: {0}",overlaps);
    
  }
  
}