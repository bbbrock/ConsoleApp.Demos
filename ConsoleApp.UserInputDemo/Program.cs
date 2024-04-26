namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string? firstName = string.Empty;
            string lastName = string.Empty;
            int age;
            int retirementAge = 65;
            decimal salary;
            char gender = char.MinValue; // same as setting it to '\0'
            bool working = true;

            // Prompt user for input
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your salary: ");
             salary = Convert.ToDecimal(Console.ReadLine()); 

            Console.Write("Please enter your gender [m/f]: ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working? (true or false): ");
            working = Convert.ToBoolean(Console.ReadLine());

            // Process the data
            int workingYearsRemaining = retirementAge - age;

            // Output results to the user
            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
            Console.WriteLine($"Your salary is listed as ${salary}.");
            Console.WriteLine($"You identify as {gender}.");
            Console.WriteLine("Are you still working? You answered {0}.", working);
        }
    }
}
