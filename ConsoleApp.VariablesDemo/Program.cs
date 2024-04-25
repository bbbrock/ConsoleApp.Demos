namespace ConsoleApp.VariablesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Different datatypes
            /*
                text - string
                integers - int
                decimal - double, float, decimal
                logical - bool
            */

            // Strings
            string name = "Brock Tucker";

            Console.WriteLine(name);
            Console.WriteLine("I am " + name); // String concatenation
            Console.WriteLine($"They call me {name}"); // String interpolation
            Console.WriteLine("I was given the name {0}", name); // Formatted  string

            // Integers
            int age = 48;
            int retirementYearsLeft = 17;
            int retirementAge = age + retirementYearsLeft;
            Console.WriteLine("My age is: " + age);
            Console.WriteLine("My retirement age is: " + retirementAge);

            // Logical
            bool isRetired = false;
            Console.WriteLine("Am I retired? " +  isRetired);
        }
    }
}
