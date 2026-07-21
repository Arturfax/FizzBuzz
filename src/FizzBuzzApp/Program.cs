using System;

namespace FizzBuzzApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input =
                "Mary had a little lamb\n" +
                "Little lamb, little lamb\n" +
                "Mary had a little lamb\n" +
                "It's fleece was white as snow";

            FizzBuzzDetector detector = new FizzBuzzDetector();

            try
            {
                FizzBuzzResult result = detector.getOverlappings(input);

                Console.WriteLine("Output string:");
                Console.WriteLine(result.OutputString);

                Console.WriteLine();
                Console.WriteLine("Fizz count: " + result.FizzCount);
                Console.WriteLine("Buzz count: " + result.BuzzCount);
                Console.WriteLine("FizzBuzz count: " + result.FizzBuzzCount);
                Console.WriteLine("Count: " + result.Count);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
