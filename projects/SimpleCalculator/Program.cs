namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<====== Simple Calculator ==========>");
            Console.WriteLine("Enter the whole number");
            int number1 = 0;
            number1  = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the whole number");
            int number2 = 0;
            number2 = int.Parse(Console.ReadLine());

            int total = number1 + number2;
            Console.WriteLine("The sum of" + number1 + " + " + number2 + " is " + total);
            Console.ReadKey();
        }
    }
}
