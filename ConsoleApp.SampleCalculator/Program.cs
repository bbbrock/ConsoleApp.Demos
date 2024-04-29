// See https://aka.ms/new-console-template for more information

// Welcome message
Console.WriteLine("Welcome to the sample calculator!");

// Create an infinite loop that we'll break out of manually in code.
while (true)
{
    // Show calculator options
    Console.WriteLine("Please select the operation you would like to perform. (-1 to exit)");
    Console.WriteLine($"1: Addition");
    Console.WriteLine($"2: Subtraction");
    Console.WriteLine($"3: Multiplication");
    Console.WriteLine($"4: Division");
    Console.WriteLine($"5: Modulus (Remainder)");
    Console.WriteLine($"6: Fibonacci sequence");
    Console.WriteLine("");
    Console.Write("Please enter your selection [1-5]: ");
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
            answer = num1 + num2;
            operation = "+";
            break;
        case 2:
            answer = num1 - num2;
            operation = "-";
            break;
        case 3:
            answer = num1 * num2;
            operation = "*";
            break;
        case 4:
            answer = num1 / num2;
            operation = "/";
            break;
        case 5:
            answer = num1 % num2;
            operation = "%";
            break;
        case 6:
            for (int i = num1; i <= num2; i++)
            {
                answer += i;
            }
            operation = "fib";
            break;
        default:
            Console.WriteLine("You have entered an invalid selection.");
            break;
    }

    // Print output
    Console.WriteLine($"The answer: {num1} {operation} {num2} = {answer}");
    Console.WriteLine();
    Console.WriteLine("Please press Enter to continue");
    Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("Thank you for using the Sample Calculator.");