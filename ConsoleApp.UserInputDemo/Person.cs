namespace ConsoleApp.UserInputDemo
{
    public class Person
    {
        public const int RETIREMENT_AGE = 65;

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public decimal Salary { get; set; }
        public char Gender { get; set; }
        public bool IsWorking { get; set; }

        private readonly int _age;

        public Person(DateOnly dob)
        {
            _age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.Month < dob.Month)
            {
                _age--;
            }
            else if (DateTime.Now.Month == dob.Month && DateTime.Now.Day < dob.Day) 
            {
                _age--;
            }
            DateOfBirth = dob;
        }

        public int GetNumberOfWorkingYearsRemaining()
        {
            return RETIREMENT_AGE - _age;
        }

        public int GetEstimatedRetirementDate()
        {
            return DateTime.Now.AddYears(GetNumberOfWorkingYearsRemaining()).Year;
        }

        public int GetAge()
        {
            return _age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public static int GetRetirementAge()
        {
            return RETIREMENT_AGE;
        }

    }
}
