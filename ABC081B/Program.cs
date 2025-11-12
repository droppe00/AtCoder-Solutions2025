using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // 各数を2で割れる回数の最小値を求める。
        int minOperations = a.Select(CountDivisibleByTwo).Min();

        Console.WriteLine(minOperations);
    }

    static int CountDivisibleByTwo(int x)
    {
        int count = 0;
        while (x % 2 == 0)
        {
            x /= 2;
            count++;
        }

        return count;
    }
}