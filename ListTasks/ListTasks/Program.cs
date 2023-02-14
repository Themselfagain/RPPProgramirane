using System;
using System.Linq;
using System.Collections.Generic;
namespace ListTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            List<string> input = Console.ReadLine().Split("|").ToList();
            input.Reverse();
            for (int i = 0; i < input.Count; i++)
            {
                int[] temp = input[i].Split().Select(int.Parse).ToArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    result.Add(temp[j]);
                }
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
