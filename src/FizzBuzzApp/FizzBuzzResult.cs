namespace FizzBuzzApp
{
    /// <summary>
    /// Contains the transformed FizzBuzz text and counts for each replacement type.
    /// </summary>
    public class FizzBuzzResult
    {
        /// <summary>
        /// Gets or sets the text after Fizz, Buzz, and FizzBuzz replacements are applied.
        /// </summary>
        public string OutputString { get; set; } = "";

        /// <summary>
        /// Gets or sets the number of words replaced with Fizz.
        /// </summary>
        public int FizzCount { get; set; }

        /// <summary>
        /// Gets or sets the number of words replaced with Buzz.
        /// </summary>
        public int BuzzCount { get; set; }

        /// <summary>
        /// Gets or sets the number of words replaced with FizzBuzz.
        /// </summary>
        public int FizzBuzzCount { get; set; }

        /// <summary>
        /// Gets the total number of replacements.
        /// </summary>
        public int Count
        {
            get
            {
                return FizzCount + BuzzCount + FizzBuzzCount;
            }
        }
    }
}
