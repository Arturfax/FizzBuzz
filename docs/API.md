# API Documentation

## Target Framework

The application and test project target .NET 8 (`net8.0`).

## `FizzBuzzApp.FizzBuzzDetector`

Processes input text by counting words from left to right. Non-word characters are preserved in place.

### `FizzBuzzResult getOverlappings(string input)`

Transforms the supplied text using these rules:

- Every third word is replaced with `Fizz`.
- Every fifth word is replaced with `Buzz`.
- A word that is both the third and fifth match is replaced with `FizzBuzz`.
- Punctuation, whitespace, line breaks, and symbols are preserved.
- Apostrophes inside a word, such as `It's`, are treated as part of that word.

Parameters:

- `input`: Text to process. It must be between 7 and 100 characters, inclusive.

Returns:

- `FizzBuzzResult`: The transformed output and replacement counts.

Exceptions:

- `ArgumentNullException`: Thrown when `input` is `null`.
- `ArgumentException`: Thrown when `input` is shorter than 7 characters or longer than 100 characters.

## `FizzBuzzApp.FizzBuzzResult`

Represents the transformation output and count summary.

Properties:

- `OutputString`: The transformed text.
- `FizzCount`: Number of `Fizz` replacements.
- `BuzzCount`: Number of `Buzz` replacements.
- `FizzBuzzCount`: Number of `FizzBuzz` replacements.
- `Count`: Total number of replacements.
