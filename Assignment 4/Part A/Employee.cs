using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Author: Anthony. Bauld 
/// Date: November 18th, 2021
/// Purpose: The purpose of the software is to re-write the original program by elimating code, and using the IComparable interface while retaining the look and feel of the original.
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>

namespace Lab4A
{
    /// <summary>
    /// Store's the data for a single employee object.
    /// </summary>
    class Employee : IComparable
    {
        private String name;            // The Employee's name
        private int number;             // The Employee's number
        private decimal rate;           // The Employee's hourly rate
        private double hours;           // The Employee's hourly pay
        private decimal gross;          // The Employee's gross based on hours * rate

        /// <summary>
        /// Constructor for the Employee's class, sets the default values.
        /// </summary>
        /// <param name="name">A String for the Employee's name.</param>
        /// <param name="number">A int for the Employee's number.</param>
        /// <param name="rate">A decimal for the Employee's hourly rate.</param>
        /// <param name="hours">A double for the Employee's hourly pay.</param>
        /// 

        public Employee(String name, int number, decimal rate, double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
        }
        public int CompareTo(object numberSort)
        {
            int value = number - ((Employee)numberSort).number;
            return value;
        }


        /// <summary> 
        /// Replaces the format with a String representation of a corresponding object in a specified Array.
        /// </summary>
        /// <returns>The formatted String.</returns>
        public override String ToString()
        {
            return String.Format($"{name,-15}{number,-10}${rate,-10}{hours,-50}");
        }
    }
}
