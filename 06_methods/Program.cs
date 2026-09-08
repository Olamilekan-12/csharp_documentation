namespace _06_methods;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Methods!");

        decimal decimal1 = GetDecimalFromUser(prompt: "Enter Decimal 1: ");
        decimal decimal2 = GetDecimalFromUser(prompt: "Enter Decimal 2: ");
        decimal decimal3 = GetDecimalFromUser(prompt: "Enter Decimal 3: ");
        decimal result = 0;
        result = decimal1 + decimal2 + decimal3;
        Console.WriteLine($"Result : {result}");
            


        static decimal GetDecimalFromUser(string prompt)
        {
            bool hasEnteredDecimal = false;
            decimal decimalresult = 0;

            while (!hasEnteredDecimal)
            {
                Console.Write(prompt);
                hasEnteredDecimal = decimal.TryParse(Console.ReadLine(), out decimalresult);
            }

            return decimalresult;
        }
    }
}