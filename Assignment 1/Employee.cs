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
    /// Store's the data for a single employee object.
    /// </summary>
    class Employee
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

        /// <summary>
        /// The name of the Employee is retrieved.
        /// </summary>
        /// <returns>The Employee's name.</returns>
        public String GetName()
        {
            return name;
        }

        /// <summary>
        /// The number of the Employee is retrieved.
        /// </summary>
        /// <returns>The Employee's number.</returns>
        public int GetNumber()
        {
            return number;
        }

        /// <summary>
        /// The hourly rate of the Employee is retrieved.
        /// </summary>
        /// <returns>The Employee's rate.</returns>
        public decimal GetRate()
        {
            return rate;
        }

        /// <summary>
        /// The hourly pay of the Employee is retrieved.
        /// </summary>
        /// <returns>The Employee's hourly.</returns>
        public double GetHours()
        {
            return hours;
        }

        /// <summary>
        /// The gross based on overtime and normal pay is retrieved.
        /// </summary>
        /// <returns>The Employee's gross.</returns>
        public decimal GetGross()
        {
            // Create's a demical store value for OverTimePay.
            decimal OverTimePay;
            // Create's a demical store value for grossPay.
            decimal grossPay;
            // Create's a double store value for OverTime.
            double OverTime;

            if (hours > 40)
            {
                // Calulates the overtime from hours.
                OverTime = hours - 40;
                // Overtime compensation is calculated by multiplying rate * 1.5 * OverTime.
                OverTimePay = (decimal)(Convert.ToDouble(rate) * 1.5 * OverTime);
                // The regular gross pay is calculated by multiplying the rate by the number of hours worked - OverTime.
                grossPay = (decimal)(Convert.ToDouble(rate) * (hours - OverTime));
                // Gross is calulated by adding grossPay + OverTimePay.
                gross = grossPay + OverTimePay;
                // Rounding gross to a .00 decimal placement.
                gross = Math.Round(gross, 2, MidpointRounding.ToEven);
                // Returns the calulated gross.
                return gross;
            }
            else
            {
                // The regular gross is calculated by multiplying hours * rate.
                gross = (decimal)(hours) * rate;
                // Rounding gross to a .00 decimal placement.
                gross = Math.Round(gross, 2, MidpointRounding.ToEven);
                // Returns the calulated gross.
                return gross;
            }
        }

        /// <summary> 
        /// Replaces the format with a String representation of a corresponding object in a specified Array.
        /// </summary>
        /// <returns>The formatted String.</returns>
        public override String ToString()
        {
            return String.Format($"{name,-15}{number,-10}${rate,-10}{hours,-10}${GetGross(),-10}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hours"></param>
        public void SetHours(double hours)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void SetName(String name)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        public void SetNumber(int number)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rate"></param>
        public void SetRate(decimal rate)
        {

        }
    }
}
