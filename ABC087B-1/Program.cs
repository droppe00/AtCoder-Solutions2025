using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 入力の受け取り
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int X = int.Parse(Console.ReadLine());

        int count = 0;

        // 500円玉の枚数でループ(0からA枚まで)
        for (int a = 0; a <= A; a++)
        {
            for (int b = 0; b <= B; b++)
            {
                for (int c = 0; c <= C; c++)
                {
                    // 合計金額を計算
                    int total = (500 * a) + (100 * b) + (50 * c);

                    if (total == X)
                    {
                        count++;
                    }
                }
            }
        }

        // 結果を出力
        Console.WriteLine(count);
    }
}