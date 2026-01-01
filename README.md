# GradingSystemBool
A begginer project using C# to calculate a letter grade using a number grade using booleans

## How to run
1. Make sure you have the [.NET sdk](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-10.0.101-windows-x64-installer) installed
2. Clone the repository 
```
> git clone https://github.com/yousif51811/GradingSystem.git
```
3. Run the Program
``` 
> Dotnet run
```
4. Enjoy!

## How it works
### 1. Checks if the grade is a passing grade
```
bool passed = numberGrade >= 60;
```
### 2. Checks your letter grade using booleans
Booleans arent the most effective or clean method for this but this is specifically for educational purposes
```
bool A = numberGrade >=90;
bool B = numberGrade >=80 && numberGrade < 90;
bool C = numberGrade >=70 && numberGrade < 80;
bool D = numberGrade >=60 && numberGrade < 70;
bool F = numberGrade < 60;
```
### 3. Convert the grade to a string (for printing)
```
string lettergrade = 
    A ? "an A" :
    B ? "a B" :
    C ? "a C" :
    D ? "a D" :
    F ? "an F" :
    "?";
```
### 3. Check for other potential inconsistencies or Errors
```
if (lettergrade == "?" || numberGrade > 100)
{
    throw new Exception("Invalid");
}
```
### 4. Prints wether you passed or not
```
if (passed) {
    Console.WriteLine("You passed!");
}
else if (!passed)
{
    Console.WriteLine("You failed :(");
}
```
### 5. Print your result
```
Console.WriteLine($"You got {lettergrade}");
```
### 6. Catch any errors
```
try {
    // Program Code...
}
catch {
    Console.WriteLine("Invalid Grade!");
}
```
-----
### Made with ❤️ by yousif51811
