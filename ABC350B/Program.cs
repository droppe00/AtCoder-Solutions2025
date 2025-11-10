namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            // 単純に三マスが0,1だったら足し算する、しないの話
            string input = Console.ReadLine();

            int count = input.Count(c => c == '1');

            Console.WriteLine(count);
        }
    }
}