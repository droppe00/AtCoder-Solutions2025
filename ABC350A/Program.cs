namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整数aの読み込み(1行目)
            int a = int.Parse(Console.ReadLine());

            // 整数bとcの読み込み(2行目：スペース区切り)
            string[] bc = Console.ReadLine().Split();
            int b = int.Parse(bc[0]);
            int c = int.Parse(bc[1]);

            // 文字列sの読み込み(3行目)
            string s = Console.ReadLine();

            // 計算
            int sum = a + b + c;

            // 出力
            Console.WriteLine($"{sum} {s}");
        }
    }
}