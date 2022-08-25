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
    class Circle : Shape
    {
        // This function creates a radius variable.
        private int Radius;

        /// <summary>
        /// Constructor for the Square class, sets the default values.
        /// </summary>
        /// <param name="Type">A String for the shapes's name.</param>
        /// <param name="Radius">A int for the shapes radius.</param>
        /// 
        public Circle(String Type, int Radius)
        {
            this.Type = Type;
            this.Radius = Radius;
        }

        /// <summary>
        /// Writes lines to the console which allows use to input values for radius.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("\nEnter the radius:");
            Radius = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Calulates the area for circle.
        /// </summary>
        /// <returns>The area of a circle.</returns>
        public override double CalculateArea()
        {
            return PI * Radius * 2;
        }

        /// <summary>
        /// Create's a throw NotImplemtedExecption and places default values.
        /// </summary>
        /// <returns>This does not return anything.</returns>
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a formatted ToString which will call the referrences SetData(), CalulateArea().
        /// </summary>
        /// <returns>The Rectangle outputs will be returned in a prepared string that may be used in Program.</returns>
        public override string ToString()
        {
            return String.Format($"{Type} - Area: {CalculateArea()}");
        }
    }
}
