// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Arrays ***");

// Ask how many students and grades are to be entered.
Console.Write("Please indicate the number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

// Declare fixed size array
int[] grades = new int[numberOfGrades];  // 5 space addresses/indexes - 0, 1, 2, 3, 4
string[] studentNames = new string[numberOfGrades];


// Add values to fixed size array
//grades[0] = 45;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;

//for (int i = 0; i < grades.Length; i++)
//{
//    Console.Write($"Enter Grade {i + 1}: ");
//    grades[i] = Convert.ToInt32(Console.ReadLine());
//}

//// Print values in fixed size array
//Console.WriteLine("The grades you have entered are: ");
//for (int i = 0;i < grades.Length; i++)
//{
//    Console.WriteLine(grades[i]);
//}

// Declare variable sized array

// Add values to variable sized array
for (int i = 0; i < numberOfGrades; i++)
{
    Console.Write("Enter student name: ");
    studentNames[i] = Console.ReadLine();

    Console.Write($"Enter {studentNames[i]}'s grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values in variable sized array
Console.WriteLine("The names you have entered are: ");
for (int i = 0; i < numberOfGrades; i++)
{
    Console.WriteLine($"{studentNames[i]} grade: {grades[i]}");
}


