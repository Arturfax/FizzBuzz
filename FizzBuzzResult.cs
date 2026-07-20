namespace FizzBuzzApp
{
    public class FizzBuzzResult
    {
        public string OutputString { get; set; } = "";

        public int FizzCount { get; set; }

        public int BuzzCount { get; set; }

        public int FizzBuzzCount { get; set; }

        public int Count
        {
            get
            {
                return FizzCount + BuzzCount + FizzBuzzCount;
            }
        }
    }
}