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
            if (String.Equals(answer, "Yes", StringComparison.OrdinalIgnoreCase))
            //if (answer == "Yes")
            {
                addOther = true;
            }
            else  if (String.Equals(answer, "No", StringComparison.OrdinalIgnoreCase))
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
