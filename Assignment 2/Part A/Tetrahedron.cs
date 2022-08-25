using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Anthony. Bauld
/// Date: October 6th, 2021
/// Purpose: The purpose of the program is to output mathematical calulations based on the shape and values the user selects.
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>

namespace Lab2A
{
    class Tetrahedron : Shape
    {
        // This function creates a length variable.
        private int Length;

        /// <summary>
        /// Constructor for the Square class, sets the default values.
        /// </summary>
        /// <param name="Type">A String for the shapes's name.</param>
        /// <param name="Length">A int for the shapes length.</param>
        /// 
        public Tetrahedron(String Type, int Length)
        {
            this.Type = Type;
            this.Length = Length;
        }

        /// <summary>
        /// Writes lines to the console which allows use to input values for length.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the length:");
            Length = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Calulates the area for tetrahedron.
        /// </summary>
        /// <returns>The area of a tetrahedron.</returns>
        public override double CalculateArea()
        {
            return Math.Sqrt(3) * Length * Length;
        }

        /// <summary>
        /// Calulates the volume for tetrahedron.
        /// </summary>
        /// <returns>The volume of a tetrahedron.</returns>
        public override double CalculateVolume()
        {
            return Math.Pow(Length, 3.0) / (6 * Math.Sqrt(2));
        }

        /// <summary>
        /// Creates a formatted ToString which will call the referrences SetData(), CalulateArea() and, CalulateVolume().
        /// </summary>
        /// <returns>The Rectangle outputs will be returned in a prepared string that may be used in Program.</returns>
        public override string ToString()
        {
            return String.Format($"{Type} - Area: {CalculateArea()} Volume: {CalculateVolume()}");
        }
    }
}
