// See https://aka.ms/new-console-template for more information
//Console.WriteLine("--- DateTime Manipulation ---");

// Empty DateTime
//DateTime dateTime = new DateTime();

// Create a DateTime from date and time
//var dateOfBirth = new DateTime(1975, 7, 24);
//Console.WriteLine($"My Dob is: {dateOfBirth}");

//var exactDateOfBirth = new DateTime(1975, 7, 24, 15, 30, 15, DateTimeKind.Local);
//Console.WriteLine($"My Dob is: {exactDateOfBirth}");

//Console.WriteLine($"Day of Week: {exactDateOfBirth.DayOfWeek}");
//Console.WriteLine($"Day of Year: {exactDateOfBirth.DayOfYear}");
//Console.WriteLine($"Time of Day: {exactDateOfBirth.TimeOfDay}");
//Console.WriteLine($"Tick: {exactDateOfBirth.Ticks}");
//Console.WriteLine($"Kind: {exactDateOfBirth.Kind}");

// Create a DateTime from current timestamp
using System.Globalization;

DateTime now = DateTime.Now;
//Console.WriteLine($"Time is now: {now}");

// Create a DateTime from a String
//Console.Write("What is your DOB: ");
//string dob = Console.ReadLine();

//var userDob = DateTime.Parse( dob );
//Console.WriteLine($"Day of Week: {userDob.DayOfWeek}");
//Console.WriteLine($"Day of Year: {userDob.DayOfYear}");
//Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
//Console.WriteLine($"Tick: {userDob.Ticks}");
//Console.WriteLine($"Kind: {userDob.Kind}");

//// Change Format DateTime
//Console.WriteLine($"Formatted  Date: {userDob.ToString("dd/MM/yyyy")}");
//Console.WriteLine($"Formatted  Date: {userDob.ToString("MMM dd, yyyy")}");
//Console.WriteLine($"Formatted  Date: {userDob.ToString("dd-MMM-yyyy")}");
//Console.WriteLine($"Formatted  Date: {userDob:dddd, MMMM dd, yyyy}");

//// Add additional time
//Console.WriteLine($"One hour from now is: {now.AddHours(1)}");
//Console.WriteLine($"One day from now is: {now.AddDays(1)}");
//Console.WriteLine($"One day ago from now is: {now.AddDays(-1)}");

//// Ticks from DateTime

//Console.WriteLine("--- DateTime Offset manipulation ---");

// UTC 
//var utcNow = DateTime.UtcNow;
//Console.WriteLine($"Now Date Time is: {now}");
//Console.WriteLine($"Now UTC Date Time is: {utcNow}");

//// DateTimeOffSet and TimeZone Info
//var tz = TimeZoneInfo.Local.GetUtcOffset( utcNow );
//Console.WriteLine($"User Time Zone: {tz}");

//var dto = new DateTimeOffset(now, tz);
//Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
//Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}");

//var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("IST");
//var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
//Console.WriteLine($"Action was completed in India at {indiaDateTime}");

Console.WriteLine("--- Date only and Time only manipulation ---");

// DateOnly
//var dateOnly = new DateOnly(1999, 12, 31);
//var nextDay = dateOnly.AddDays(1);
//var previousDay = dateOnly.AddDays(-1);
//var decadeLater = dateOnly.AddYears(10);
//var lastMonth = dateOnly.AddMonths(-1);

//Console.WriteLine($"The Date: {dateOnly}");
//Console.WriteLine($"The Next Date: {nextDay}");
//Console.WriteLine($"The Previous Date: {previousDay}");
//Console.WriteLine($"A Decade Later: {decadeLater}");
//Console.WriteLine($"Last Month: {lastMonth}");

//var dateOnlyFromDateTime = DateOnly.FromDateTime( now );
//Console.WriteLine($"Date Only From DateTime: {dateOnlyFromDateTime}");

//Console.WriteLine("What is your DOB (dd MMM yyyy): ");
//string dobDateOnly = Console.ReadLine();

//var theDateOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy", CultureInfo.InvariantCulture);
//Console.WriteLine($"The Date Only: {theDateOnly}");

// TimeOnly
var timeNow = TimeOnly.FromDateTime( now );
Console.WriteLine($"Time Only: {timeNow}");
Console.WriteLine($"Time Only: {timeNow:H:mm:ss}");

// Date Comparisons
var date1 = new DateTime(1975, 7, 24);
var date2 = DateTime.Now;

Console.WriteLine($"Is '{nameof(date1)}' equal? {date1 == date2}");
Console.WriteLine($"Is '{nameof(date1)}' equal? {date1.Equals(date2)}");
Console.WriteLine($"Is '{nameof(date1)}' after? {date1 > date2}");
Console.WriteLine($"Is '{nameof(date1)}' before? {date1 < date2}");
Console.WriteLine($"Years: {date2.Year - date1.Year}");
