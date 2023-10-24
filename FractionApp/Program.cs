namespace FractionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new(5, 10);
            Fraction fraction2 = new(10, 20);

            Console.WriteLine($"5|10 * 10|20 = {fraction1 * fraction2}");
            Console.WriteLine($"5|10 / 10|20 = {fraction1 / fraction2}");
            Console.WriteLine($"5|10 + 10|20 = {fraction1 + fraction2}");
            Console.WriteLine($"5|10 - 10|20 = {fraction1 - fraction2}");
            Console.WriteLine($"5|10 == 10|20 = {fraction1.Equals(fraction2)}");

            Console.ReadKey();
        }
    }
}