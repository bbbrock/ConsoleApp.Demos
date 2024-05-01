// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Lists ***");

// Declare a List
List<int> grades = new List<int>();
List<string> students = new List<string>();
int grade = 0, gradecount = 0;
string name;
char @continue;

//var grades2 = new List<int>();
//List<int> grades3 = new();

// Add values to list
//grades.Add(45);

//Console.WriteLine("Please enter grades below. (-1 when finished)");
do
{
    Console.Write("Enter student name: ");
    name = Console.ReadLine();
    students.Add(name);

    Console.Write("Enter grade: ");
    grade = Convert.ToInt32(Console.ReadLine());
    if (grade >= 0)
    {
        grades.Add(grade);
    }
    gradecount++;
    Console.Write("Do you wish to continue (y/n): ");
    @continue = Convert.ToChar(Console.ReadLine());
} while (@continue == 'y');

// Print values in list - for
Console.WriteLine("Printing grades via for loop.");
for (int i = 0; i < gradecount; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

// Print values in list - foreach
//Console.WriteLine("Printing grades via foreach loop.");
//foreach (var g in grades)
//{
//    Console.WriteLine(g);
//}
