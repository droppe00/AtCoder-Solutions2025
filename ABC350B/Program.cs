namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int count = input.Count(c => c == '1');

            Console.WriteLine(count);
        }
    }
}