// See https://aka.ms/new-console-template for more information
// Define a class
using ConsoleApp.ClassesDemo.Utils;
using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;
public partial class Person
{
    // Properties/Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    private string _taxNumber;
    protected string _idNumber = "N/A";

    public Person()
    {

    }

    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxNumber;
    }

    public void PrintFullName()
    {
        var type = GetType().Name;
        Console.WriteLine($"{type} name: {FirstName} {LastName}");
    }

    public void PrintInitials()
    {
        var type = GetType().Name;
        Console.WriteLine($"{type} initials: {FirstName[0]}{LastName[0]}");
    }

    public void GenerateTaxNumber()
    {
        if (string.IsNullOrEmpty(_taxNumber))
        {
            _taxNumber = PersonHelper.GenerateIdNumber();
        } else
        {
            Console.WriteLine($"Tax number already exists for {FirstName} {LastName}.");
        }
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    public string GetIdNumber()
    {
        return _idNumber;
    }
}

