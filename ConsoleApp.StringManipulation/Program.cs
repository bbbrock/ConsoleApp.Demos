// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- String Manipulation ---");

// Initialize with a regular string literal.
string s1 = "This is a literal string.";
String s2 = "This is a literal string.";
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine(s2);

// Declare without initializing. (possible null exception)
string s3;
//Console.WriteLine(s3);

// Initialize to null. (possible null exception)
string? s4 = null;
Console.WriteLine(s4);

// Initialize as an empty string.
string s5 = string.Empty; // ""
string s6 = " ";
Console.WriteLine(s5);
Console.WriteLine(s6);

// Escape sequences and characters.
string sentence = "She said, \"I have your phone\" \r\nThis is the next line.";
Console.WriteLine(sentence);

// Verbatim string literal.
string oldPath = "C:\\Program Files\\ProgramFolder\\";
string newPath = @"C:\Program Files\ProgramFolder\";
Console.WriteLine(oldPath);
Console.WriteLine(newPath);

// Use a const string to prevent modification to a string.
const string path = "C:\\Program Files\\ProgramFolder\\";
//path = "new value"; // Illegal operation against a constant
Console.WriteLine(path);

// Raw string literals
string rawLiteral = """ This is a literal " string. c:\home\something, "I have your phone" """; // Note triple quotation marks
string rawLiteral2 = """
    She said, "I have your phone"
    THis is another line
    And another one
    """;
Console.WriteLine(rawLiteral);
Console.WriteLine(rawLiteral2);

// Review concatenation and interpolation
s1 += s2;
string newString = $"{s1} {s2} Some random literal text";
string newString1 = s1 + $"{s1} {s2} Some random literal text";
string newString2 = String.Format("Literal string {0} {1}", s1, s2);
Console.WriteLine(newString);
Console.WriteLine(newString1);
Console.WriteLine(newString2);

/* String manipulation methods and properties. Sometimes it just assessment*/

// Null or empty checks
// find the length of a string
Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
// Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}"); //  Will cause Null Exception
// Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");
/*if (!string.IsNullOrEmpty(s3))
{
Console.WriteLine($"{nameof(s3)} has a length of {s3.Length}");
}*/
if (!string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
}
if (!string.IsNullOrEmpty(s5))
{
    Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
}

// Substrings
string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)}: {subString}");
subString = s1.Substring(5, 5);
Console.WriteLine($"{nameof(subString)}: {subString}");

// Splitting strings
var splitStrings = s2.Split(' '); // In this example, we're splitting on spaces ' '.
for (int i = 0; i < splitStrings.Length; i++)
{
    Console.WriteLine($"{splitStrings[i]}");
}

// Replace
string replacements1 = s1.Replace('s', 'v');
Console.WriteLine($"{nameof(replacements1)}: {replacements1}");
string replacements2 = s1.Replace("string", "chicken");
Console.WriteLine($"{nameof(replacements2)}: {replacements2}");

// Convert to string
string salary = 4834.ToString();
int value = 123456;
string strValue = value.ToString();

// Changing Formatting
Console.WriteLine($"{nameof(salary)}: {salary:C}"); // Capital C refers to currency in C#. Works in interpolation
Console.WriteLine(nameof(salary) + ": " + value.ToString("C"));

// String comparison
