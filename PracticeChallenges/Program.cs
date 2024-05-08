// See https://aka.ms/new-console-template for more information







using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
using Microsoft.VisualBasic;

class Program
 {
     static void Main(string[] args)
     {
        //  int num,rev,sum = 0,temp;
        //  //int - integar or a number
        //  //num- variable name 
        //  //rev() Function
        //  //temp is a variable name used to swap numbers and they need to hold a temp value
        //  Console.Write("enter the number");
        //  num = int.Parse(Console.ReadLine());
        //  temp = num;
        //  while(num>0)
        //  {
        //     rev = num %10;
        //     sum = (sum*10) + rev;
        //     num = num/10;
        //  }
        //  if (temp == sum)
        //  System.Console.Write("yay");
        //  else
        //  System.Console.WriteLine("oops");



//       string _inputstr, _reverstr = string.Empty;   
//       Console.Write("Enter a string : ");

//       _inputstr =Console.ReadLine();

//       if (_inputstr != null)
//       {
//         for (int i= _inputstr.Length -1; i>=0; i--)
//         {
//             _reverstr += _inputstr[i].ToString();
//         }
//         if (_reverstr == _inputstr)
//         {
//             System.Console.WriteLine("this is a Palindrome");
//         }
//         else
//         {
//             System.Console.WriteLine("not a palindrome");
//         }
//       }
//     Console.ReadLine();



// string str1 = "apple";
// string str2 = "apples";
// bool areEqual = str1 == str2;

// if (areEqual)
//     {
//     System.Console.WriteLine("True");
//     }
// else
//     {
//     System.Console.WriteLine("False");
//     }


//  Publicc static int CharToInt(char c);
// {
//     c = char.ToLower(c);
//     return c - 'a' + 1;
// }


// char charValue = '5';
// int intValue = (int)charValue - '0';

// System.Console.WriteLine(intValue);

string originalString = "Hello, World!";
string reversedString = new string (originalString.Reverse().ToArray());
System.Console.WriteLine($"Original:{originalString}");
System.Console.WriteLine($"Reverse: {reversedString}");



//Number9 

int result1 = ReverseAndAdd(123);
Console.WriteLine(result1);

//the number on line 176 the number is wrong - replace 1112220 with the right number 
//so test case 3 will fail

}

    public static int ReverseAndAdd(int inputNumber)
    {
        int reverseNum = 0; //= int.Parse(new string(inputNumber.ToString().Reverse().ToArray()));
        
        // call ToString on the inputNumber to have the string representation of the integer name inputNumber
        string stringRepresentationOfNumber = inputNumber.ToString();
        // reverse the string above using .NET Framework method Reverse which can be called on any string
        // also call ToArray using .NET Toarray on type string to convert it an array, in thise case characterArray
        char[] charArray = stringRepresentationOfNumber.Reverse().ToArray();
        // set initial int reverseNum to converted integer of the string value
        // initialize new string object with the char array
        reverseNum = int.Parse(new string(charArray));

        return inputNumber + reverseNum;

    }

string letters = "abcde"

string numbers =
ConvertLettersToNumbers(letters);
System.Console.WriteLine(numbers);

static string ConvertLettersToNumbers (string letters)
{
int number = letter - 'a' + 1;

result += number.ToString("D2");
}

return result;
 }
 


 }
 
 
 




           
                
           
     
  
   
       
   

