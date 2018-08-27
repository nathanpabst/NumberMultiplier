using System;
using System.Collections.Generic;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        //create a console application that, given a comma separated list of strings, prints the result of multiplying the values together.
        //Example: "1, 2, 3" --> 6
        {
            Console.WriteLine("Please enter a string of numbers separated by commas");
            string input = Console.ReadLine();
            //Split method creates an array of numbers based on the comma delimiter and stores the values in inputArray.
            string[] inputArray = input.Split(',');
            int results = 1;

            Console.WriteLine("Would you like to multiply or square these values? ( m / s )");
            var mathType = Console.ReadLine();

            if (mathType == "m") /*multiply*/
            {
                foreach (string num in inputArray)
                {
                    //int.Parse changes string values to numbers
                    var toNum = int.Parse(num);
                    results *= toNum;
                }
                Console.WriteLine(results);
                Console.WriteLine("Press enter to exit.");
                Console.ReadLine();
            
            }
            else if (mathType == "s") /*square*/
            {
                //List, using System.Collections.Generic, creates a list of values
                var output = new List<int> { };
                foreach (string num in inputArray)
                {
                    var toNum = int.Parse(num);
                    toNum *= toNum;
                    //Add() adds the output values to the list
                    output.Add(toNum);
                }
                //string.Join() adds a comma between each of the output values
                Console.WriteLine(string.Join(',', output));
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }

        }
    }
}
