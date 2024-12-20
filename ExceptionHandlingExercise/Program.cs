using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Objective: Iterate through a character array. Try to parse each character into an integer.
            // If you attempt to parse a letter into an integer, an exception will occur. 
            // Use a try-catch statement to avoid a run-time exception.
            // Below we will set this up.
            // ------------------------------------------------------------------------------



            //TODO START HERE:

            //DONE 1) Create an char[], it must contain 6 numbers and 3 letters - name it arr
            var arr = new char[] { '2', 't', '7', 'r', '8', '3', 'd', '9', '0' };
            
            //DONE 2) Create a list called numbers that will hold integers
            var numbers = new List<int>();

            //DONE 3) Create an string variable with an empty string initializer - name it str
            string str;
            
            //DONE 4) Make a foreach loop to iterate through your character array            
                //DONE 5) Create a try-catch inide of your foreach loop
                    //DONE 6) Inside the try block: 
                        //DONE 7) Set your string variable to each array element in your char[] to .ToString()
                        //DONE 8) Now, using int.Parse, parse your string variable and store in an int variable
                        //DONE 9) Then add each int to your list
            foreach (char c in arr)
            {
                try
                {
                    str = c.ToString();
                    int myChar = int.Parse(str);
                    numbers.Add(myChar);
                }catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{c}'");
                }
            }
            

                
                   //DONE 10) Inside the catch block:
                       //DONE 11) In the scope of your catch you can use the following code:                  
                       // Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                
            
            // Uncomment the code below to see the numbers you successfully added to the numbers list: 
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
