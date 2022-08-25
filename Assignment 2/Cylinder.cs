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
    class Cylinder : Shape
    {
        // This function creates a radius variable.
        private int Radius;
        // This function creates a height variable.
        private int Height;

        /// <summary>
        /// Constructor for the Square class, sets the default values.
        /// </summary>
        /// <param name="Type">A String for the shapes's name.</param>
        /// <param name="Radius">A int for the shapes radius.</param>
        /// <param name="Radius">A int for the shapes height.</param>
        /// 
        public Cylinder(String Type, int Radius, int Height)
        {
            this.Type = Type;
            this.Radius = Radius;
            this.Height = Height;
        }

        /// <summary>
        /// Writes lines to the console which allows use to input values for radius and height.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("\nEnter the radius:");
            Radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the height:");
            Height = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Calulates the area for cylinder.
        /// </summary>
        /// <returns>The area of a cylinder.</returns>
        public override double CalculateArea()
        {
            return (2 * PI * Radius * Height) + 2 * PI * (Radius * Radius);
        }

        /// <summary>
        /// Calulates the volume for cylinder.
        /// </summary>
        /// <returns>The volume of a cylinder.</returns>
        public override double CalculateVolume()
        {
            return Height * PI * Radius * 2;
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
