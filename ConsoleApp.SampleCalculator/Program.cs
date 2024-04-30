// See https://aka.ms/new-console-template for more information

// Welcome message
Console.WriteLine("Welcome to the sample calculator!");

// Create an infinite loop that we'll break out of manually in code.
while (true)
{
    try
    {
        PrintMenu();

        Console.Write("Please enter your selection [1-6]: ");
        int selection = Convert.ToInt32(Console.ReadLine());

        // If user enters a -1, break out of the main body loop.
        if (selection == -1) break;

        // Prompt for user input
        Console.Write("Please enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Decide which operation is needed based on selected option
        int answer = 0;
        string operation = string.Empty;
        switch (selection)
        {
            case 1:
                answer = AddNumbers(num1, num2);
                operation = "+";
                break;
            case 2:
                answer = SubtractNumbers( num1, num2);
                operation = "-";
                break;
            case 3:
                answer = ProductNumbers( num1, num2);
                operation = "*";
                break;
            case 4:
                answer = QuotientNumbers(num1, num2);
                operation = "/";
                break;
            case 5:
                answer = ModulusNumbers(num1, num2);
                operation = "%";
                break;
            case 6:
                answer = FibonaciNumbers(num1, num2);
                operation = "fib";
                break;
            default:
                throw new Exception("Invalid menu item selected.");
        }

        // Print output
        Console.WriteLine($"The answer: {num1} {operation} {num2} = {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("You can not divide a number by 0. Please try again.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("\nPlease press Enter to continue");
        Console.ReadLine();
        Console.Clear();
    }
}

Console.WriteLine("Thank you for using the Sample Calculator.");

int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}

int SubtractNumbers(int num1, int num2)
{
    return num1 - num2;
}

int ProductNumbers(int num1, int num2)
{
    return num1 * num2;
}

int ModulusNumbers(int num1, int num2)
{
    return num1 % num2;
}

int QuotientNumbers(int num1, int num2)
{
    return num1 / num2;
}

int FibonaciNumbers(int num1, int num2)
{
    int answer = 0;
    for (int i = num1; i <= num2; i++)
    {
        answer += i;
    }
    return answer;
}

void PrintMenu()
{
    // Show calculator options
    Console.Clear();
    Console.WriteLine("Please select the operation you would like to perform. (-1 to exit)");
    Console.WriteLine($"1: Addition");
    Console.WriteLine($"2: Subtraction");
    Console.WriteLine($"3: Multiplication");
    Console.WriteLine($"4: Division");
    Console.WriteLine($"5: Modulus (Remainder)");
    Console.WriteLine($"6: Fibonacci sequence");
    Console.WriteLine("");
}

