# FizzBuzz

FizzBuzz is a .NET console application that replaces every third word with `Fizz`, every fifth word with `Buzz`, and every word matching both positions with `FizzBuzz`.

## Project Structure

```text
FizzBuzz.sln
src/FizzBuzzApp/FizzBuzzApp.csproj
src/FizzBuzzApp/Program.cs
src/FizzBuzzApp/FizzBuzzDetector.cs
src/FizzBuzzApp/FizzBuzzResult.cs
tests/FizzBuzzApp.Tests/FizzBuzzApp.Tests.csproj
tests/FizzBuzzApp.Tests/FizzBuzzDetectorTests.cs
docs/API.md
```

## Requirements

- .NET 8 SDK

Both the application and test project target `net8.0`.

## Dependencies

The application has no external runtime dependencies.

The test project uses:

- `Microsoft.NET.Test.Sdk` 17.8.0
- `MSTest.TestAdapter` 3.1.1
- `MSTest.TestFramework` 3.1.1

## Build

```bash
dotnet restore FizzBuzz.sln
dotnet build FizzBuzz.sln
```

## Run

```bash
dotnet run --project src/FizzBuzzApp/FizzBuzzApp.csproj
```

## Test

```bash
dotnet test FizzBuzz.sln
```

## API Documentation

The public API is documented in [docs/API.md](docs/API.md). XML documentation generation is also enabled for the application project.
