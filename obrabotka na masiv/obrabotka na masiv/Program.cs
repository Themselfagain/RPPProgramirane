using System;
using System.Linq;

namespace obrabotka_na_masiv
{
    public static class OptionsManager
    {

        public static int LessThan100(int[] arr)
        {
            return arr.Count(x => x < 100);
        }
        public static int MaxNum(int[] arr)
        {
            return arr.Max();
        }
        public static int[] ReverseArray(int[] arr)
        { return arr.Reverse().ToArray(); }
        public static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item+",");
            }
        }
       
        public static void EvenPrint(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write(arr[i] + " ");
            }
        }
        public static void CountEven(int[] arr)
        {
            int countEven = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    countEven++;
                }
            }
            Console.WriteLine("Count Even = "+countEven);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(OptionsManager.LessThan100(arr));

            Console.WriteLine("max= "+OptionsManager.MaxNum(arr));
            OptionsManager.EvenPrint(arr);

            OptionsManager.CountEven(arr);
            int even = 0;

            arr = OptionsManager.ReverseArray(arr);

            OptionsManager.Print(arr);

            foreach (var item in arr)
            {
                count++;
            }
            Console.WriteLine("Count = "+count);

        }
    }
}
