using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] randomNumbers = Enumerable.Range(1, 52).OrderBy(x => random.Next()).Take(8).ToArray();
        Console.WriteLine("Generated Random Numbers: " + string.Join(", ", randomNumbers));
    }
}
