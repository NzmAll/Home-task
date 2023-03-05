namespace HomeTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Firma :");
            string first_firm = Console.ReadLine();

            Console.Write("Ayaqqabı sayı :");
            float first_count_of_shoe = float.Parse(Console.ReadLine());

            Console.Write("Birinin qiyməti ($) :");
            float first_price_of_one = float.Parse(Console.ReadLine());

            float all_price = first_count_of_shoe * first_price_of_one;

            Console.WriteLine("Hamısının birlikdə qiyməti($):" + all_price);
            Console.WriteLine(" ");


            Console.Write("Firma :");
            string second_firm = Console.ReadLine();

            Console.Write("Ayaqqabı sayı :");
            float second_count_of_shoe = float.Parse(Console.ReadLine());

            Console.Write("Birinin qiyməti ($) :");
            float second_price_of_one = float.Parse(Console.ReadLine());

            float second_all_price = second_count_of_shoe * second_price_of_one;

            Console.WriteLine("Hamısının birlikdə qiyməti($):" + second_all_price);
            Console.WriteLine(" ");


            Console.Write("Firma :");
            string third_shoe = Console.ReadLine();

            Console.Write("Ayaqqabı sayı :");
            float third_count_of_shoe = float.Parse(Console.ReadLine());

            Console.Write("Birinin qiyməti ($) :");
            float third_price_of_one = float.Parse(Console.ReadLine());

            float third_all_price = third_count_of_shoe * third_price_of_one;

            Console.WriteLine("Hamısının birlikdə qiyməti($):" + third_all_price);
            Console.WriteLine(" ");
        }
    }
}