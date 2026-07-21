using System;
using FizzBuzzApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzApp.Tests
{
    [TestClass]
    public class FizzBuzzDetectorTests
    {
        [TestMethod]
        public void ExampleInputReturnsExpectedResult()
        {
            string input =
                "Mary had a little lamb\n" +
                "Little lamb, little lamb\n" +
                "Mary had a little lamb\n" +
                "It's fleece was white as snow";

            string expected =
                "Mary had Fizz little Buzz\n" +
                "Fizz lamb, little Fizz\n" +
                "Buzz had Fizz little lamb\n" +
                "FizzBuzz fleece was Fizz as Buzz";

            FizzBuzzDetector detector = new FizzBuzzDetector();

            FizzBuzzResult result = detector.getOverlappings(input);

            Assert.AreEqual(expected, result.OutputString);
            Assert.AreEqual(9, result.Count);
        }

        [TestMethod]
        public void ThirdWordIsReplacedWithFizz()
        {
            FizzBuzzDetector detector = new FizzBuzzDetector();

            FizzBuzzResult result =
                detector.getOverlappings("one two three");

            Assert.AreEqual("one two Fizz", result.OutputString);
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void FifthWordIsReplacedWithBuzz()
        {
            FizzBuzzDetector detector = new FizzBuzzDetector();

            FizzBuzzResult result =
                detector.getOverlappings("one two three four five");

            Assert.AreEqual(
                "one two Fizz four Buzz",
                result.OutputString);

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void PunctuationIsPreserved()
        {
            FizzBuzzDetector detector = new FizzBuzzDetector();

            FizzBuzzResult result =
                detector.getOverlappings("one, two! three? four; five.");

            Assert.AreEqual(
                "one, two! Fizz? four; Buzz.",
                result.OutputString);
        }

        [TestMethod]
        public void SymbolsAreNotCountedAsWords()
        {
            FizzBuzzDetector detector = new FizzBuzzDetector();

            FizzBuzzResult result =
                detector.getOverlappings("one --- two three four five");

            Assert.AreEqual(
                "one --- two Fizz four Buzz",
                result.OutputString);
        }

        [TestMethod]
        public void NullInputThrowsException()
        {
            FizzBuzzDetector detector = new FizzBuzzDetector();

            Assert.ThrowsException<ArgumentNullException>(
                () => detector.getOverlappings(null!));
        }

        [TestMethod]
        public void TooShortInputThrowsException()
        {
            FizzBuzzDetector detector = new FizzBuzzDetector();

            Assert.ThrowsException<ArgumentException>(
                () => detector.getOverlappings("short"));
        }
    }
}
