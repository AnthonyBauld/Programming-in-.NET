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
    class Sphere : Shape
    {
        // This function creates a radius variable.
        private int Radius;

        /// <summary>
        /// Constructor for the Square class, sets the default values.
        /// </summary>
        /// <param name="Type">A String for the shapes's name.</param>
        /// <param name="Radius">A int for the shapes radius.</param>
        /// 
        public Sphere(String Type, int Radius)
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
        /// Calulates the area for sphere.
        /// </summary>
        /// <returns>The area of a sphere.</returns>
        public override double CalculateArea()
        {
            return 4 * PI * Radius * Radius;
        }

        /// <summary>
        /// Calulates the volume for sphere.
        /// </summary>
        /// <returns>The volume of a sphere.</returns>
        public override double CalculateVolume()
        {
            return ((4.0 / 3.0 * PI) * (Radius * Radius * Radius));
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
