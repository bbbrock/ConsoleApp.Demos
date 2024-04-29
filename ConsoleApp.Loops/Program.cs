// See https://aka.ms/new-console-template for more information

Console.WriteLine("***** Simple for Loop *****");
// Simple for loop demo
// Print Hello, World! 10 times

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

// Ask user how many times they wish to print hello world and print accordingly

/*
Console.Write("How many times would you like to print Hello, World!?: ");
int loopIterations = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < loopIterations; i++)
{
    Console.WriteLine($"Hello, World! - {i + 1}");
}
*/
Console.WriteLine("***** End Simple for Loop *****");

// while loop
Console.WriteLine("***** Simple while Loop *****");

//int counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine($"Hello, World! - {counter++}");
//}

int sum = 0;
int input = 0;
while (input != -1)
{
    sum += input; 
    Console.Write("Please enter a number to add to the running sum [-1 to quit]: ");
    input = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The sum of your entered numbers is {0}.", sum);

Console.WriteLine("***** End Simple while Loop *****");

Console.WriteLine("***** Simple do while Loop *****");

sum = 0;
input = 0;
do
{
    sum += input;
    Console.Write("Please enter a number to add to the running sum [-1 to quit]: ");
    input = Convert.ToInt32(Console.ReadLine());
} while (input != -1);
Console.WriteLine("The sum of your entered numbers is {0}.", sum);

Console.WriteLine("***** End Simple do while Loop *****");
