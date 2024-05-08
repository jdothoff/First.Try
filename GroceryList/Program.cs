// See https://aka.ms/new-console-template for more information

using System;

namespace grocery;


class Program
{
    static void Main(string[] args)
    {
        string itemsInList = "";
        bool addOther = true;
        string answer = "";
        List<string> groceryList = new List<string>(); //use the .....to shorten


        System.Console.WriteLine("Grocery List Menu");
        do
        {

            System.Console.WriteLine("Your item you want to add: ");
            itemsInList = Console.ReadLine();

            groceryList.Add(itemsInList);

            System.Console.WriteLine("Do you want to enter another item Yes or No:");
            answer = System.Console.ReadLine();
            if (answer.StringEquals("Yes"))
            //if (String.Equals(answer, "Yes", StringComparison.OrdinalIgnoreCase))
            //if (answer == "Yes")
            {
                addOther = true;
            }
            else  if (answer.StringEquals("No")) //if (String.Equals(answer, "No", StringComparison.OrdinalIgnoreCase))
            {
                addOther = false;
            }



        } while (addOther == true);
        System.Console.WriteLine("Items in bag are: " + groceryList[0]);  //we are putting it there because we are impacting that variable

        foreach (string item in groceryList)
        {

            System.Console.Write(item + " ");
        }



    }
}

public static class StringComparisonUtil
{
    /// <summary>
    /// Extension method to compare to strings and return true or false
    /// </summary>
    /// <param name="source"></param>
    /// <param name="stringToCompare"></param>
    /// <returns></returns>
    public static bool StringEquals(this string source, string stringToCompare)
    {
        return string.Equals(source, stringToCompare, StringComparison.OrdinalIgnoreCase);
    }
}