namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a number: ");
                double number = double.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new Exception("Cannot calculate square root of a negative number.");
                }

                double squareRoot = Math.Sqrt(number);
                Console.WriteLine($"The square root of {number} is: {squareRoot}");
            }
            catch (FormatException)
            {
                Console.WriteLine(" Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
