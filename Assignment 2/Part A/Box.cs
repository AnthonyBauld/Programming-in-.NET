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
    class Box : Shape
    {
        // This function creates a length variable.
        private int Length;
        // This function creates a width variable.
        private int Width;
        // This function creates a height variable.
        private int Height;

        /// <summary>
        /// Constructor for the Square class, sets the default values.
        /// </summary>
        /// <param name="Type">A String for the shapes's name.</param>
        /// <param name="Length">A int for the shapes length.</param>
        /// <param name="Width">A int for the shapes Width.</param>
        /// <param name="Height">A int for the shapes Height.</param>
        /// 
        public Box(String Type, int Length, int Width, int Height)
        {
            this.Type = Type;
            this.Length = Length;
            this.Width = Width;
            this.Height = Height;
        }

        /// <summary>
        /// Writes lines to the console which allows use to input values for length, width and, height.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the length:");
            Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width:");
            Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            Height = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Calulates the area for box.
        /// </summary>
        /// <returns>The area of a box.</returns>
        public override double CalculateArea()
        {
            return (2 * (Length * Width) + (2 * (Length * Height)) + (2* (Width * Height)));
        }

        /// <summary>
        /// Calulates the volume for box.
        /// </summary>
        /// <returns>The volume of a box.</returns>
        public override double CalculateVolume()
        {
            return Length * Width * Height;
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
