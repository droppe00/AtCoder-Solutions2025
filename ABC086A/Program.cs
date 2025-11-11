class Program
    {
    static void Main(string[] args)
    {
        // 整数aとbの読み込み(1行目：スペース区切り)
        string[] ab = Console.ReadLine().Split();
        int a = int.Parse(ab[0]);
        int b = int.Parse(ab[1]);

        // 計算
        int product = a * b;

        // 計算結果を2で割って、偶数・奇数のチェック
        if (product % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
    }