using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Author: Anthony. Bauld
/// Date: September 20th, 2021
/// Purpose: The purpose of the program is to write one which reads a text file and allows the user to sort it ascending or descending according to their choice.
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>

namespace Lab1
{
    /// <summary>
    /// Pulls data from a text file and produces an array that's sorted, That allows the user to choose which block to executed.
    /// </summary>
    class Program
    {
        private static Employee[] employees;
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            // Read's the employee.txt file placed in the bin of the program.
            employees = Read("employees.txt");
            // Writes the Title of project, Name and, Student Number within the console.
            Console.WriteLine("Assignment 1 - Anthony. Bauld (000754334)");
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
                    case "1":
                        SortName(employees);
                        foreach (Employee e in employees)
                            Console.WriteLine(e);
                        break;
                    case "2":
                        SortNumber(employees);
                        foreach (Employee e in employees)
                            Console.WriteLine(e);
                        break;
                    case "3":
                        SortRate(employees);
                        foreach (Employee e in employees)
                            Console.WriteLine(e);
                        break;
                    case "4":
                        SortHours(employees);
                        foreach (Employee e in employees)
                            Console.WriteLine(e);
                        break;
                    case "5":
                        SortGross(employees);
                        foreach (Employee e in employees)
                            Console.WriteLine(e);
                        break;
                }
            }
        }

        /// <summary>
        /// 
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

        /// <summary>
        /// Create's a StreamReader that pulls the data from the text file and places them in a object prperties that uses the Parse method.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>The Employee is returned to the Main().</returns>
        public static Employee[] Read(string filename)
        { 
            try
            {
                // Implements a TextReader that reads the employee.txt file.
                StreamReader reader = new StreamReader(filename);
                // Create's an array of Employee with at least 13 elements.
                Employee[] employees = new Employee[13];
                // Create's a int count with a value of 0.
                int count = 0;
                // Create's a while loop that grabs a value that indicates whether the current Stream position is at the end of the Stream.
                while (!reader.EndOfStream)
                {
                    // Reads a line of characters from the current Stream and returns the data as a String.
                    string line = reader.ReadLine();
                    // Splits line into fields using the String.Split method.
                    String[] explode = line.Split(',');
                    // Create's a Employee object with 4 properties (The last 3 properties are converted using the Parse method).
                    Employee e = new Employee(explode[0], int.Parse(explode[1]), decimal.Parse(explode[2]), double.Parse(explode[3]));
                    employees[count++] = e;
                }
                // Return's the array Employee to main.
                return employees;
            }
            // Catch's any exceptions that could be thrown.
            catch (Exception)
            {
                // Writes "File count not be found" if the Stream cannot find the employee.txt file.
                Console.WriteLine("File count not be found");
            }
            // Returns null if there incurs an error.
            return null;
        }

        /// <summary>
        /// Create's a sort for the Employee's name.
        /// </summary>
        /// <param name="employees"></param>
        public static void SortName(Employee[] employees)
        {
            // Create's a constructor for the Employee class and sets the default values.
            _ = new Employee("", 0, 0, 0);
            // Create's a for loop 'e' that gets the total number of elements of the Array.
            for (int e = 0; e < employees.Length - 1; e++)
                // Create's a for loop 'name' that gets the total number of elements of the Array.
                for (int name = 0; name < employees.Length - 1; name++)
                {
                    // Compares GetName() and indicates whether this instance precedes, follows, or appears in the same position in the sort order.
                    if (employees[name].GetName().CompareTo(employees[name + 1].GetName()) > 0)
                    {
                        Employee temp = employees[name];
                        employees[name] = employees[name + 1];
                        employees[name + 1] = temp;
                    }
                }
        }

        /// <summary>
        /// Create's a sort for the Employee's number.
        /// </summary>
        /// <param name="employees"></param>
        public static void SortNumber(Employee[] employees)
        {
            // Create's a constructor for the Employee class and sets the default values.
            _ = new Employee("", 0, 0, 0);
            // Create's a for loop 'e' that gets the total number of elements of the Array. 
            for (int e = 0; e < employees.Length - 1; e++)
                // Create's a for loop 'number' that gets the total number of elements of the Array.
                for (int num = 0; num < employees.Length - 1; num++)
                {
                    // Compares GetNumber() and indicates whether this instance precedes, follows, or appears in the same position in the sort order.
                    if (employees[num].GetNumber().CompareTo(employees[num + 1].GetNumber()) > 0)
                    {
                        Employee temp = employees[num];
                        employees[num] = employees[num + 1];
                        employees[num + 1] = temp;
                    }
                }
        }

        /// <summary>
        /// Create's a sort for the Employee's rate.
        /// </summary>
        /// <param name="employees"></param>
        public static void SortRate(Employee[] employees)
        {
            // Create's a constructor for the Employee class and sets the default values.
            _ = new Employee("", 0, 0, 0);
            // Create's a for loop 'e' that gets the total number of elements of the Array.
            for (int e = 0; e < employees.Length - 1; e++)
                // Create's a for loop 'rate' that gets the total number of elements of the Array.
                for (int rate = 0; rate < employees.Length - 1; rate++)
                {
                    // Compares GetRate() and indicates whether this instance precedes, follows, or appears in the same position in the sort order.
                    if (employees[rate].GetRate().CompareTo(employees[rate + 1].GetRate()) < 0)
                    {
                        Employee temp = employees[rate];
                        employees[rate] = employees[rate + 1];
                        employees[rate + 1] = temp;
                    }
                }
        }

        /// <summary>
        /// Create's a sort for the Employee's hours.
        /// </summary>
        /// <param name="employees"></param>
        public static void SortHours(Employee[] employees)
        {
            // Create's a constructor for the Employee class and sets the default values.
            _ = new Employee("", 0, 0, 0);
            // Create's a for loop 'e' that gets the total number of elements of the Array.
            for (int e = 0; e < employees.Length - 1; e++)
                // Create's a for loop 'hours' that gets the total number of elements of the Array.
                for (int hours = 0; hours < employees.Length - 1; hours++)
                {
                    // Compares GetHours() and indicates whether this instance precedes, follows, or appears in the same position in the sort order.
                    if (employees[hours].GetHours().CompareTo(employees[hours + 1].GetHours()) < 0)
                    {
                        Employee temp = employees[hours];
                        employees[hours] = employees[hours + 1];
                        employees[hours + 1] = temp;
                    }
                }
        }


        /// <summary>
        /// Create's a sort for the Employee's gross.
        /// </summary>
        /// <param name="employees"></param>
        public static void SortGross(Employee[] employees)
        {
            // Create's a constructor for the Employee class and sets the default values.
            _ = new Employee("", 0, 0, 0);
            // Create's a for loop 'e' that gets the total number of elements of the Array.
            for (int e = 0; e < employees.Length - 1; e++)
                // Create's a for loop 'gross' that gets the total number of elements of the Array.
                for (int gross = 0; gross < employees.Length - 1; gross++)
                {
                    // Compares GetGross() and indicates whether this instance precedes, follows, or appears in the same position in the sort order.
                    if (employees[gross].GetGross().CompareTo(employees[gross + 1].GetGross()) < 0)
                    {
                        Employee temp = employees[gross];
                        employees[gross] = employees[gross + 1];
                        employees[gross + 1] = temp;
                    }
                }
        }
    }
}
