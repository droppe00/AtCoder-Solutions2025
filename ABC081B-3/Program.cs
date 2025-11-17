using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Nの読み込み(1行目)
        int n = int.Parse(Console.ReadLine());

        // 配列Aの読み込み
        // 2行目の入力を読み込み→ スペース区切りで一個ずつ配列に入れていく。
        string[] inputs = Console.ReadLine().Split();
        // aというInt型の配列を作成。配列のは長さn。
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(inputs[i]); // inputs[n]をint.ParseでInt型に変換。最終的には色々計算するからね。
        }

        // 各数値が2で割れる回数を計算
        int[] counts = new int[n];
        for (int i = 0; i < n; i++)
        {
            counts[i] = CountDivisibleByTwo(a[i]);
        }

        // 配列Countsの最小値をMinで。
        int minOperations = counts.Min();

        // 最小値の出力
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