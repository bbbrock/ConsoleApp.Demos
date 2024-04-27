namespace ConsoleApp.ConditionsAndDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt for input
            Console.Write("Please enter student's grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            // Decide to print pass or fail based on input
            Console.WriteLine("************** Simple if Results **************");
            if(grade > 50)
            {
                Console.WriteLine("Student has passed.");
            } else
            {
                Console.WriteLine("Student has failed.");
                Console.WriteLine("Please recommend student to student affairs office.");
            }
            Console.WriteLine("************** End Simple if Results **************");

            Console.WriteLine("************** Complex if..else if Results **************");
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid value entered.");
            }
            else if (grade >= 0 && grade < 50)
            {
                Console.WriteLine("Student has failed - F");
            }
            else if (grade >= 50 && grade <= 64)
            {
                Console.WriteLine("C-");
            }
            else if (grade >= 65 && grade <= 74)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 75 && grade <= 84)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 85 && grade <= 100)
            {
                Console.WriteLine("A - Good job");
            }
            Console.WriteLine("************** End Complex if..else if Results **************");

            Console.WriteLine("************** Ternary Results **************");

            string passStatus = grade < 50 ? "Fail" : "Pass";
            Console.WriteLine($"Your student status is: {passStatus}");

            Console.WriteLine("************** End Ternary Results **************");

            Console.Write("Please enter a day of the week [1-7] with Sunday as 1: ");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());

            // Writing out what we're going to do with switch statement using if statements.
            if (dayOfWeek <= 0 ||  dayOfWeek > 7)
            {
                Console.WriteLine("Invalid value entered.");
            }
            else if (dayOfWeek == 1)
            {
                Console.WriteLine("Sunday");
            } else if (dayOfWeek == 2)
            {
                Console.WriteLine("Monday");
            } else if (dayOfWeek == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayOfWeek == 4)
            {
                Console.WriteLine("Wednesday (Hump Day!)");
            }
            else if (dayOfWeek == 5)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayOfWeek == 6)
            {
                Console.WriteLine("Friday (TGIF!!!)");
            }
            else if (dayOfWeek == 7)
            {
                Console.WriteLine("Saturday (Beach Day!!!)");
            }

            Console.WriteLine("************** switch Results **************");
            switch (dayOfWeek)
            {
                case 1: 
                    Console.WriteLine("Sunday");
                    break;
                case 2: 
                    Console.WriteLine("Monday");
                    break;
                case 3: 
                    Console.WriteLine("Tuesday");
                    break;
                case 4: 
                    Console.WriteLine("Wednesday (Hump Day!)");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday (TGIF!!!");
                    break;
                case 7:
                    Console.WriteLine("Saturday (Beach Day!!!)");
                    break;
                default:
                    Console.WriteLine("Some other invalid value entered.");
                    break;
            }

            Console.WriteLine("************** End switch Results **************");

            // Rest of the application            
            Console.WriteLine("Thank you for using this program.");
        }
    }
}