using System.Collections.Generic;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpList;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>() { 1, 2, 3, 4 };
        numbers.Add(1);
        numbers.AddRange(new int[3] { 5, 6, 7 });

        foreach (var number in numbers)
            Console.WriteLine(number);

        Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
        Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

        Console.WriteLine("count: " + numbers.Count);

        for (var i = 0; i < numbers.Count; i++)
        foreach (var number in numbers)
        {
            if (number == 1)
                    numbers.Remove(numbers[i]);

        }
        foreach (var number in numbers)
            Console.WriteLine(number);

        numbers.Clear();
        Console.WriteLine("Count: " + numbers.Count);
    
    }
}

