using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        
        /* String array loop */
        Console.WriteLine("Enter some text: ");
        string enteredText = Console.ReadLine();
        string[] userText = enteredText.Split(' '); //Using the string.Split method to split on spaces
        foreach (string word in userText)   //foreach loop itterates through userText outputting each word on a newline
        {
            Console.WriteLine(word);
        }
        Console.ReadLine();

        /* infinite loop (uncomment to execute) */
        //while (true) 
        //{
        //    Console.WriteLine("true");
        //}

        /* Loop using < operator */
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();

        /* Loop using <= operator */
        for (int j = 0; j <= 10; j++)
        {
            Console.WriteLine(j);
        }
        Console.ReadLine();

        /* Unique string list search loop */
        List<string> stringList = new List<string> { "This", "is", "unique", "text", "for", "the", "Tech", "Academy" };
        Console.WriteLine("Enter text to search list: ");
        string searchKeyword = Console.ReadLine();
        for (int i = 0; i < stringList.Count; i++)                          //Using int i = 0, while i < length of the list stringList, increment i by 1
        {
            if (stringList[i].ToLower() == searchKeyword.ToLower())         //Compare stringList at index i to searchKeyword, ToLower method used to be case insensitive
            {
                Console.WriteLine("Index: " + i);                           //Keyword found, and index printed
                break;
            } else
            {
                if (i == (stringList.Count - 1))
                {
                    Console.WriteLine("Text not found.");                   //Keyword not found within list, throw "text not found"
                }
            }
        }
        Console.ReadLine();

        /* Duplicate string list search loop */
        List<string> duplicateList = new List<string> { "This", "is", "the", "duplicate", "text", "for", "the", "Tech", "Academy" };
        List<string> duplicatedList = new List<string>();                                           //Create list containing duplicate text values
        Console.WriteLine("Enter text to search list: ");
        string searchKey = Console.ReadLine();
        for (int i = 0; i < duplicateList.Count; i++)
        {
            if (duplicateList[i].ToLower() == searchKey.ToLower())                                  //comparison between list index value and searchKey using .ToLower() method, so case insensitive
            {
                Console.WriteLine("Index: " + i);
                duplicatedList.Add(duplicateList[i].ToLower());
            }
            else
            {
                if (i == (duplicateList.Count - 1) && !duplicateList.Contains(searchKey.ToLower())) //check list containing duplicated values for searchKey && last index before printing "text not found"
                {
                    Console.WriteLine("Text not found."); 
                }
            }
        }
        Console.ReadLine();

        /* Foreach duplicate string list search loop */
        List<string> exampleList = new List<string> { "This", "is", "the", "duplicate", "text", "for", "the", "Tech", "Academy" };
        List<string> duplicatedText = new List<string>();       //This new List will contain text that has already appeared.
        List<string> notDuplicatedText = new List<string>();    //This new List will contain text that has not already appeared.
        foreach (string s in exampleList)
        {
            Console.WriteLine(s);
            if (!notDuplicatedText.Contains(s))                  //if this text is not already within this new List, add to list
            {
                notDuplicatedText.Add(s);                        //Add text to notDuplicated list
                Console.WriteLine("This text has not appeared before");
            } else                                               //Text was already within the new list, so adding text to duplicate list and printing "has appeared"
            {
                duplicatedText.Add(s);
                Console.WriteLine("This text has appeared before.");
            }
        }
        Console.ReadLine();

    }
}
