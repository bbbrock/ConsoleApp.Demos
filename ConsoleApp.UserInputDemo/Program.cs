using System.Globalization;

namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string? firstName = string.Empty;
            string lastName = string.Empty;
            DateOnly dob = new DateOnly();
            decimal salary;
            char gender = char.MinValue; // same as setting it to '\0'
            bool working = true;
            char runagain = 'y';

            List<Person> persons = new();

            while (runagain == 'y')
            {

                // Prompt user for input
                Console.Write("Please enter your first name: ");
                firstName = Console.ReadLine();

                Console.Write("Please enter your last name: ");
                lastName = Console.ReadLine();

                //Console.Write("Please enter your date of birth (dd/mm/yyyy): ");
                Console.Write("Please enter your date of birth (mm-dd-yyyy): "); // Easier to type from just the numpad
                string dobString = Console.ReadLine();
                dob = DateOnly.ParseExact(dobString, "MM-dd-yyyy", CultureInfo.InvariantCulture);
                //dob = DateOnly.ParseExact(dobString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.Write("Please enter your salary: ");
                salary = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Please enter your gender [m/f]: ");
                gender = Convert.ToChar(Console.ReadLine());

                Console.Write("Are you working? (true or false): ");
                working = Convert.ToBoolean(Console.ReadLine());

                Person person = new(dob)
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Gender = gender,
                    IsWorking = working,
                    Salary = salary
                };

                // Process the data
                persons.Add(person);

                Console.Write("Would you like to enter another person (y/n): ");
                runagain = Convert.ToChar(Console.ReadLine());
                Console.Clear();
            }

            foreach (var person in persons)
            {
                // Output results to the user
                Console.WriteLine($"\nFull name: {person}");
                Console.WriteLine($"Age: {person.GetAge()}");
                Console.WriteLine($"Your salary is: {person.Salary.ToString("C")}.");
                Console.WriteLine($"You identify as {person.Gender}.");
                Console.WriteLine("Are you still working? You answered {0}.", person.IsWorking);
                Console.WriteLine($"Working years remaining: {person.GetNumberOfWorkingYearsRemaining()}");
                Console.WriteLine($"Estimated retirement year: {person.GetEstimatedRetirementDate()}");
            }

        }
    }
}
