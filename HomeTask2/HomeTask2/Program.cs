namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Azərbaycan dövlətinin illik büdcəsi:");
            decimal annual_budget = decimal.Parse(Console.ReadLine());

            decimal remaining_budget;

            Console.Write("Müdafiə Nazirliyinə xərclənənən məbləğ:");
            decimal ministry_of_defence = decimal.Parse(Console.ReadLine());
            ministry_of_defence = annual_budget * 20 / 100;

            Console.Write("Yüksək Texnologiyalar Nazirliyinə xərclənənən məbləğ:");
            decimal ministry_of_high_technologies = decimal.Parse(Console.ReadLine());
            ministry_of_high_technologies = annual_budget * 10 / 100;

            remaining_budget = annual_budget - (ministry_of_defence + ministry_of_high_technologies);

            Console.WriteLine("Yerdə qalan büdcə:" + remaining_budget);



        }
    }
}