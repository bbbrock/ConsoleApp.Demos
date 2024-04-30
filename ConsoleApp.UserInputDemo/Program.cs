using System.Globalization;

namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int retirementAge = 65;

            // Declare variables
            string? firstName = string.Empty;
            string lastName = string.Empty;
            int age;
            DateOnly dob = new DateOnly();
            decimal salary;
            char gender = char.MinValue; // same as setting it to '\0'
            bool working = true;

            // Prompt user for input
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Please enter your date of birth (dd/mm/yyyy): ");
            string dobString = Console.ReadLine();
            dob = DateOnly.ParseExact(dobString,"dd/MM/yyyy", CultureInfo.InvariantCulture);
            age = DateTime.Now.Year - dob.Year;
            Console.WriteLine($"Age: {age}");
            if (DateTime.Now.Month < dob.Month)
            {
                age--;
            } 
            else if (DateTime.Now.Month == dob.Month && DateTime.Now.Day > dob.Day)
            {
                age--;
            }


            Console.Write("Please enter your salary: ");
             salary = Convert.ToDecimal(Console.ReadLine()); 

            Console.Write("Please enter your gender [m/f]: ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working? (true or false): ");
            working = Convert.ToBoolean(Console.ReadLine());

            // Process the data
            int workingYearsRemaining = retirementAge - age;
            var estimatedRetirementYear = DateTime.Now.AddYears(workingYearsRemaining);

            // Output results to the user
            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Your salary is: ${salary.ToString("C")}.");
            Console.WriteLine($"You identify as {gender}.");
            Console.WriteLine("Are you still working? You answered {0}.", working);
            Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
            Console.WriteLine($"Estimated retirement year: {estimatedRetirementYear.Year}");
        }
    }
}
