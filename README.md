How to recreate the structure of the project:

```
mkdir TDD-CS-FizzBuzz
cd TDD-CS-FizzBuzz

dotnet new sln -n FizzBuzzSolution

dotnet new classlib -n FizzBuzz
dotnet new xunit -n FizzBuzz.Tests

cd FizzBuzz.Tests
dotnet add reference ../FizzBuzz/FizzBuzz.csproj
dotnet add package FluentAssertions
```