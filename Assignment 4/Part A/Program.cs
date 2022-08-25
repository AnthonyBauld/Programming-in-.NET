using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Author: Anthony. Bauld 
/// Date: November 21th, 2021
/// Purpose: The purpose of the software is to re-write the original program by elimating code, and using the IComparable interface while retaining the look and feel of the original.
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>

namespace Lab4A
{
    /// <summary>
    /// Pulls data from a text file and produces an array that's sorted, That allows the user to choose which block to executed.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Imports the text file into a list T> generic array that will be sorted using CompareTo.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            // Creates a generic list T> with the name "Array" in it.
            List<string> Array = new List<string>();
            // Creates a new variable named "streamR" that will be used to read data from the text file.
            using (var streamR = new StreamReader("employees.txt"))
            {
                // Create's a while look that returns the next character.
                while (streamR.Peek() >= 0)
                    // Fills the list array with data from the text file.
                    Array.Add(streamR.ReadLine());
            }
            // Writes the Title of project, Name and, Student Number within the console.
            Console.WriteLine("Assignment 4A - Anthony. Bauld (000754334)");
            // Creates a while loop for the Menu.
            String choice;
            while ((choice = Menu()) != "6")
            {
                Console.WriteLine();
                // Writes a line that formats the name, number, rate, hours and, gross within the console.
                Console.WriteLine("Name           Number    Rate       Hours     Gross");
                Console.WriteLine("======================================================\n");
                // Creates a switch loop to allow the users to choose select between 1-6 blocks to be executed.
                switch (choice)
                {
                    // Sort by Employee Name (Ascending)
                    case "1":
                        Array.Sort();
                        foreach (string a in Array)
                            Console.WriteLine(a);
                        break;
                    // Sort by Employee Number (Ascending)
                    case "2":
                        foreach (string a in Array)
                            Console.WriteLine(a);
                        break;
                    // Sort by Employee Pay Rate (Descending)
                    case "3":
                        foreach (string a in Array)
                            Console.WriteLine(a);
                        break;
                    // Sort by Employee Hours (Descending)
                    case "4":
                        foreach (string a in Array)
                            Console.WriteLine(a);
                        break;
                    // Sort by Employee Gross Pay (Descending)
                    case "5":
                        foreach (string a in Array)
                            Console.WriteLine(a);
                        break;
                }
            }
        }

        /// <summary>
        /// Creates a menu that writes a select menu from which the user can choose.
        /// </summary>
        /// <returns></returns>
        private static String Menu()
        {
            // Writes a Menu within the console displaying text outputs the user can choose from
            Console.WriteLine("\nPlease select one of the options below!");
            Console.WriteLine("1. Sort by Employee Name (Ascending)");
            Console.WriteLine("2. Sort by Employee Number (Ascending)");
            Console.WriteLine("3. Sort by Employee Pay Rate (Descending)");
            Console.WriteLine("4. Sort by Employee Hours (Descending)");
            Console.WriteLine("5. Sort by Employee Gross Pay (Descending)");
            Console.WriteLine("6. Exit");
            Console.Write("\nEnter Choice:");
            // Returns the next line outputs and display's them within the console
            return Console.ReadLine();
        }
    }
}

