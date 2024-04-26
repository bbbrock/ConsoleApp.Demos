// See https://aka.ms/new-console-template for more information


Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
Console.Write("Please enter the second number: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

int sum = num1 + num2;

int product = num1 * num2;

int quotient = num1 / num2;

int difference = num1 - num2;

int mod = num1 % num2;

Console.WriteLine("*************** Math Results *************");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine("*************** End Math Results *************");
/*
 * Logical operators and operations
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqualTo = num1 != num2;

Console.WriteLine("*************** Logic Results *************");
Console.WriteLine($"{num1} is greater than {num2}: {isGreaterThan}");
Console.WriteLine($"{num1} is less than {num2}: {isLessThan}");
Console.WriteLine($"{num1} is equal to {num2}: {isEqualTo}");
Console.WriteLine($"{num1} is greater than or equal to {num2}: {isGreaterThanOrEqualTo}");
Console.WriteLine($"{num1} is less than or equal to {num2}: {isLessThanOrEqualTo}");
Console.WriteLine($"{num1} is not equal to {num2}: {isNotEqualTo}");
Console.WriteLine("*************** End Logic Results *************");

Console.WriteLine("*************** Assignment Results *************");
Console.WriteLine();
Console.WriteLine($"Num 1: {num1}");
num1 += 5;
Console.WriteLine($"Num 1 increased by 5: {num1}");
num1 -= 3;
Console.WriteLine($"Num 1 reduced by 3: {num1}");
num1 /= 2;
Console.WriteLine($"Num 1 divided by 2: {num1}");
num1 %= 2;
Console.WriteLine($"Num 1 mod 2: {num1}");
num1 *= 10;
Console.WriteLine($"Num 1 multiplied by 10: {num1}");
Console.WriteLine();
Console.WriteLine("*************** End Assignments Results *************");
