using System;
using System.Collections.Generic;

namespace Sum_of_Unique_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                var data = Console.ReadLine().Split(' ');
                if (n <= 0)
                {
                    Console.WriteLine("INVALID");
                }
                else
                {
                    int[] arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = int.Parse(data[i]);
                    }
                    var result = Sum(arr);
                    Console.WriteLine($"Example {test}: {result}");
                }
            }
        }

        static int Sum(int[] arr)
        {
            Dictionary<int,int> count = new Dictionary<int, int>();
            foreach(var num in arr)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                    count[num] = 1;  
            }
            int sum = 0;    
            foreach(var pair in count)
            {
                if (pair.Value == 1)
                {
                    sum += pair.Key;
                }
            }
            return sum;
        }
    }
}