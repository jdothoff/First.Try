// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

int dateOfBirth = 1979;
int currentYear =2024;
int age = currentYear - dateOfBirth;
System.Console.WriteLine("My age is " + age);

System.Console.WriteLine("Please enter your name.");
string? nameOfUser = Console.ReadLine();
if (nameOfUser == "Patrick") System.Console.WriteLine("Hello, Patrick");
else System.Console.WriteLine("Hello Stranger");

System.Console.WriteLine("What is 1 +1?");
string? result = Console.ReadLine();
int resultn = Int32.Parse(result);
if (resultn == 2) System.Console.WriteLine("Well Done.");
else System.Console.WriteLine("Sorry, Wrong Answer.");


string word = "Hi";
System.Console.WriteLine(word.Length);


int size = 5; 
for (int i=1; i<= size; i++)
{
     for (int j=size; j >= i; --j )
     {
        System.Console.Write("*");
     }
    
    System.Console.WriteLine();
}



