using System;
using System.Text;

namespace FizzBuzzApp
{
    public class FizzBuzzDetector
    {
        public FizzBuzzResult getOverlappings(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (input.Length < 7 || input.Length > 100)
            {
                throw new ArgumentException(
                    "Input string length must be between 7 and 100 characters.");
            }

            StringBuilder output = new StringBuilder();

            int currentPosition = 0;
            int thirdWordCounter = 0;
            int fifthWordCounter = 0;

            int fizzCount = 0;
            int buzzCount = 0;
            int fizzBuzzCount = 0;

            while (currentPosition < input.Length)
            {
                char currentCharacter = input[currentPosition];

                if (!char.IsLetterOrDigit(currentCharacter))
                {
                    output.Append(currentCharacter);
                    currentPosition++;
                    continue;
                }

                int wordStart = currentPosition;
                currentPosition++;

                while (currentPosition < input.Length)
                {
                    char character = input[currentPosition];

                    if (char.IsLetterOrDigit(character))
                    {
                        currentPosition++;
                    }
                    else if (IsApostrophe(character)
                             && currentPosition + 1 < input.Length
                             && char.IsLetterOrDigit(input[currentPosition + 1]))
                    {
                        currentPosition++;
                    }
                    else
                    {
                        break;
                    }
                }

                int wordLength = currentPosition - wordStart;

                thirdWordCounter++;
                fifthWordCounter++;

                bool isFizz = false;
                bool isBuzz = false;

                if (thirdWordCounter == 3)
                {
                    isFizz = true;
                    thirdWordCounter = 0;
                }

                if (fifthWordCounter == 5)
                {
                    isBuzz = true;
                    fifthWordCounter = 0;
                }

                if (isFizz && isBuzz)
                {
                    output.Append("FizzBuzz");
                    fizzBuzzCount++;
                }
                else if (isFizz)
                {
                    output.Append("Fizz");
                    fizzCount++;
                }
                else if (isBuzz)
                {
                    output.Append("Buzz");
                    buzzCount++;
                }
                else
                {
                    output.Append(input, wordStart, wordLength);
                }
            }

            FizzBuzzResult result = new FizzBuzzResult();

            result.OutputString = output.ToString();
            result.FizzCount = fizzCount;
            result.BuzzCount = buzzCount;
            result.FizzBuzzCount = fizzBuzzCount;

            return result;
        }

        private bool IsApostrophe(char character)
        {
            return character == '\'' || character == '’';
        }
    }
}