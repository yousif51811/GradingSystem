using System;

namespace GradingSystem
{
    class MainClass
    {
        static void Main()
        {
            while(true)
            {
                try
                {
                    
                    Console.Write("Enter A Grade: ");
                    double numberGrade = Convert.ToDouble(Console.ReadLine());
                    bool passed = numberGrade >= 60;
                    bool A = numberGrade >=90;
                    bool B = numberGrade >=80 && numberGrade < 90;
                    bool C = numberGrade >=70 && numberGrade < 80;
                    bool D = numberGrade >=60 && numberGrade < 70;
                    bool F = numberGrade < 60;
                    string lettergrade = 
                        A ? "an A" :
                        B ? "a B" :
                        C ? "a C" :
                        D ? "a D" :
                        F ? "an F" :
                        "?";
                    // Handle Extra possible errors
                    if (lettergrade == "?" || numberGrade > 100)
                    {
                        throw new Exception("Invalid");
                    }
                    
                    if (passed) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You passed!");
                        Console.ResetColor();
                    }
                    else if (!passed)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You failed :(");
                        Console.ResetColor();
                    }
                    Console.WriteLine($"You got {lettergrade}");
                    break;
                }
                catch
                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Grade!");
                        Console.ResetColor();
                }
            }
        }
    }
}