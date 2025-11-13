using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Nの読み込み
        int n = int.Parse(Console.ReadLine());

        // 配列Aの読み込み
        string[] inputs = Console.ReadLine().Split();
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(inputs[i]);
        }

        // 各数値が2で割れる回数を計算
        int[] counts = new int[n];
        for (int i = 0; i < n; i++)
        {
            counts[i] = CountDivisibleByTwo(a[i]);
        }

        // 最小値を求める
        int minOperations = FindMin(counts);

        // 結果を出力
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

    static int FindMin(int[] array)
    {
        if (array.Length == 0)
            return 0;

        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
}