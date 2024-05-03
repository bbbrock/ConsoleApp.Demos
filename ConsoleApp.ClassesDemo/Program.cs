// See https://aka.ms/new-console-template for more information
using ConsoleApp.ClassesDemo.Classes.PersonDemo;
using ConsoleApp.ClassesDemo.Classes.ShapeDemo;

Console.WriteLine("*** Classes and Objects ***");

// Define an object of type Person
Person person; // this will be null by default

Person baby = new()
{
    LastName = "Tucker",
    FirstName = "Brock",
    DateOfBirth = new DateOnly(2024, 5, 1)
};

Console.WriteLine($"{baby.FirstName} {baby.LastName}");
baby.PrintFullName();
baby.PrintInitials();

baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();
Console.WriteLine(taxNumber.ToString());

var person1 = new Person("Dev1", "One", new DateOnly(2000, 5, 1));
person1.PrintFullName();
person1.PrintInitials();
Console.WriteLine($"{person1.FirstName} is {person1.GetAge(2010)} years old.\n");

var person2 = new Person("Developer", "Two", "7431586");
person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();
Console.WriteLine();

Teacher teacher = new();
teacher.LastName = "Tucker";
teacher.FirstName = "Steph";
teacher.DateOfBirth = new DateOnly(1966, 12, 24);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();
Console.WriteLine(teacher.GetTaxNumber().ToString());
teacher.GenerateTeacherIdNumber();
Console.WriteLine(teacher.GetIdNumber().ToString());
Console.WriteLine();

Student student = new();
student.LastName = "Elliott";
student.FirstName = "Amber";
student.DateOfBirth = new DateOnly(1966, 12, 24);

student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();
Console.WriteLine(student.GetTaxNumber().ToString());
student.GenerateStudentIdNumber();
Console.WriteLine(student.GetIdNumber().ToString());

// Polygon polygon =  new Polygon(); // Compiler error
Rectangle rectangle = new Rectangle(10, 20);
var rectangleArea = rectangle.Area();
Console.WriteLine($"Rectangle area: {rectangleArea}");

Square square = new Square(50);
var squareArea = square.Area();
Console.WriteLine($"Square area: {squareArea}");

Triangle triangle = new Triangle(10, 10);
var triangleArea = triangle.Area();
Console.WriteLine($"Triangle area: {triangleArea}");

Cuboid cuboid = new(1, 5, 7);
Console.WriteLine($"Cuboid area is: {cuboid.Area()}");
Console.WriteLine($"Cuboid volume is: {cuboid.Volume()}");
Console.WriteLine($"Cuboid perimeter is: {cuboid.Perimeter()}");

Sphere sphere = new(7);
Console.WriteLine($"Sphere volume is: {sphere.Volume()}");
Console.WriteLine($"Sphere circumference is: {sphere.Circumference()}");


