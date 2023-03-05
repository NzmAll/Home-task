namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("AZN-nin miqdarı:");
            decimal amountAZN = Decimal.Parse(Console.ReadLine());

            Console.Write("1 USD neçə AZN-dir?");
            decimal valueUSD = Decimal.Parse(Console.ReadLine());

            Console.Write("1 EUR neçə AZN-dir?");
            decimal valueEUR = Decimal.Parse(Console.ReadLine());

            Console.Write("1 RUB neçə AZN-dir?");
            decimal valueRUB = Decimal.Parse(Console.ReadLine());

            decimal amountUSD = amountAZN / valueUSD; 
            decimal amountEUR = amountAZN / valueEUR;
            decimal amountRUB = amountAZN / valueRUB;

            Console.WriteLine("USD-nin miqdarı:" + amountUSD);
            Console.WriteLine("EUR-nun miqdarı:" + amountEUR);
            Console.WriteLine("RUB-un miqdarı:" + amountRUB);


        }
    }
}