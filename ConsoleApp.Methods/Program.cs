// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Methods ***");

// void methods - completes a task without returning a value
//void PrintName()
//{
//    // Method code
//    Console.WriteLine("Brock");
//}

//// value returning methods - returns a value after an operation
//int GetFiveYearsAgo()
//{
//    return DateTime.Now.AddYears(-5).Year;
//}

//// methods with parameters
//void PrintNameWithParams(string name)
//{
//    // Method code
//    Console.WriteLine($"Your name is {name}");
//}

//int GetYearDifferenceAgoWithParams(int year)
//{
//    return DateTime.Now.Year - year;
//}

//// methods with optional parameters
//int GetFutureOrPastYear(int numberOfYears = 0)
//{
//    var year = DateTime.Now.AddYears(numberOfYears).Year;
//    return year;
//}

// methods with nullable parameters
void PrintNameNullableParam(string? name, int? count)
{
    //if (string.IsNullOrWhiteSpace(name)) { name = "Default Name"; }
    //if (!count.HasValue) { count = 1; }
    name ??= "Default Name";
    count ??= 1;
    for (int i = 0; i < count; i++) { Console.WriteLine(name) ; }
}


/* Function Calls */
//PrintName();
//int fiveYearsAgo = GetFiveYearsAgo();
//Console.WriteLine("Five years ago was " + fiveYearsAgo);

//Console.Write("Enter your name: ");
//string name = Console.ReadLine();
//PrintNameWithParams(name);

//Console.Write("Enter a year: ");
//int year = Convert.ToInt32(Console.ReadLine());
//int yearsAgo = GetYearDifferenceAgoWithParams(year);
//Console.WriteLine($"It has been {yearsAgo} years since 2015");

//Console.Write("Enter number of years in the future or past: ");
//int numberOfYears = Convert.ToInt32(Console.ReadLine());

//var pastYear1 = GetFutureOrPastYear(numberOfYears);
//Console.WriteLine($"The year is {pastYear1}");

PrintNameNullableParam(null, null);
PrintNameNullableParam("Brock", 5);
