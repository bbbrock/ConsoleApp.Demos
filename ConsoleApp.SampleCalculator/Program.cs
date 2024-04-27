// See https://aka.ms/new-console-template for more information

// Welcome message
Console.WriteLine("Welcome to the sample calculator!");

// Prompt for user input
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show calculator options
Console.WriteLine("Please select the operation you would like to perform.");
Console.WriteLine($"1: Addition - {num1} + {num2}");
Console.WriteLine($"2: Subtraction - {num1} - {num2}");
Console.WriteLine($"3: Multiplication - {num1} * {num2}");
Console.WriteLine($"4: Division - {num1} / {num2}");
Console.WriteLine($"5: Modulus (Remainder) - {num1} % {num2}");
Console.WriteLine("");
Console.Write("Please enter your selection [1-5]: ");
int selection = Convert.ToInt32(Console.ReadLine());

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
    default: 
        Console.WriteLine("You have entered an invalid selection."); 
        break;
}
// Print output
Console.WriteLine($"{num1} {operation} {num2} = {answer}");
