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
    class Program
    {
        /// <summary>
        /// Creates a program that pulls data from a shape array list and outputs mathematical calculations based on user input using object hierarchy.
        /// </summary>
        /// <param name="args">Creates a count, an array list, and a switch that lets the user to choose the case(Menu) to input values for.</param>
        static void Main(string[] args)
        {
            // Creates a count to see how many Rectangle instances the user entered.
            int MenuCountRectangle = 0;
            // Creates a count to see how many Square instances the user entered.
            int MenuCountSquare = 0;
            // Creates a count to see how many Box instances the user entered.
            int MenuCountBox = 0;
            // Creates a count to see how many Cube instances the user entered.
            int MenuCountCube = 0;
            // Creates a count to see how many Ellipse instances the user entered.
            int MenuCountEllipse = 0;
            // Creates a count to see how many Circle instances the user entered.
            int MenuCountCircle = 0;
            // Creates a count to see how many Cylinder instances the user entered.
            int MenuCountCylinder = 0;
            // Creates a count to see how many Sphere instances the user entered.
            int MenuCountSphere = 0;
            // Creates a count to see how many Triangle instances the user entered.
            int MenuCountTriangle = 0;
            // Creates a count to see how many Tetrahedron instances the user entered.
            int MenuCountTetrahedron = 0;

            // Create's a constructor for Rectangle and sets the default values.
            var Rectangle = new Rectangle("Rectangle", 0, 0);
            // Create's a constructor for Square and sets the default values.
            var Square = new Square("Square", 0);
            // Create's a constructor for Box and sets the default values.
            var Box = new Box("Box", 0, 0, 0);
            // Create's a constructor for Cube and sets the default values.
            var Cube = new Cube("Cube", 0);
            // Create's a constructor for Ellipse and sets the default values.
            var Ellipse = new Ellipse("Ellipse", 0, 0);
            // Create's a constructor for Circle and sets the default values.
            var Circle = new Circle("Circle", 0);
            // Create's a constructor for Cylinder and sets the default values.
            var Cylinder = new Cylinder("Cylinder", 0, 0);
            // Create's a constructor for Sphere and sets the default values.
            var Sphere = new Sphere("Sphere", 0);
            // Create's a constructor for Triangle and sets the default values.
            var Triangle = new Triangle("Triangle", 0, 0);
            // Create's a constructor for Tetrahedron and sets the default values.
            var Tetrahedron = new Tetrahedron("Tetrahedron", 0);

            // Creates a polymorphism list in which the shapes are stored.
            _ = new List<Shape>
            {
                Rectangle,
                Square,
                Box,
                Cube,
                Circle,
                Cylinder,
                Sphere,
                Triangle,
                Tetrahedron
            };

            // Makes a string that may be invoked from the Menu.
            String choice;
            // Creates a while loop for the Menu.
            while ((choice = Menu()) != "21")   
                // Creates a switch loop that allows users to select from A through J,
                // as well as list and exit the program displaying the store shapes.
                switch (choice)
                {
                    // Allows the user to select the shape corresponding with the letters A.
                    case "A":
                        Rectangle.SetData();
                        MenuCountRectangle++;
                        break;
                    // Allows the user to select the shape corresponding with the letters a.
                    case "a":
                        Rectangle.SetData();
                        MenuCountRectangle++;
                        break;
                    // Allows the user to select the shape corresponding with the letters B.
                    case "B":
                        Square.SetData();
                        MenuCountSquare++;
                        break;
                    // Allows the user to select the shape corresponding with the letters b.
                    case "b":
                        Square.SetData();
                        MenuCountSquare++;
                        break;
                    // Allows the user to select the shape corresponding with the letters C.
                    case "C":
                        Box.SetData();
                        MenuCountBox++;
                        break;
                    // Allows the user to select the shape corresponding with the letters c.
                    case "c":
                        Box.SetData();
                        MenuCountBox++;
                        break;
                    // Allows the user to select the shape corresponding with the letters D.
                    case "D":
                        Cube.SetData();
                        MenuCountCube++;
                        break;
                    // Allows the user to select the shape corresponding with the letters d.
                    case "d":
                        Cube.SetData();
                        MenuCountCube++;
                        break;
                    // Allows the user to select the shape corresponding with the letters E.
                    case "E":
                        Ellipse.SetData();
                        MenuCountEllipse++;
                        break;
                    // Allows the user to select the shape corresponding with the letters e.
                    case "e":
                        Ellipse.SetData();
                        MenuCountEllipse++;
                        break;
                    // Allows the user to select the shape corresponding with the letters F.
                    case "F":
                        Circle.SetData();
                        MenuCountCircle++;
                        break;
                    // Allows the user to select the shape corresponding with the letters f.
                    case "f":
                        Circle.SetData();
                        MenuCountCircle++;
                        break;
                    // Allows the user to select the shape corresponding with the letters G.
                    case "G":
                        Cylinder.SetData();
                        MenuCountCylinder++;
                        break;
                    // Allows the user to select the shape corresponding with the letters g.
                    case "g":
                        Cylinder.SetData();
                        MenuCountCylinder++;
                        break;
                    // Allows the user to select the shape corresponding with the letters H.
                    case "H":
                        Sphere.SetData();
                        MenuCountSphere++;
                        break;
                    // Allows the user to select the shape corresponding with the letters h.
                    case "h":
                        Sphere.SetData();
                        MenuCountSphere++;
                        break;
                    // Allows the user to select the shape corresponding with the letters I.
                    case "I":
                        Triangle.SetData();
                        MenuCountTriangle++;
                        break;
                    // Allows the user to select the shape corresponding with the letters i.
                    case "i":
                        Triangle.SetData();
                        MenuCountTriangle++;
                        break;
                    // Allows the user to select the shape corresponding with the letters J.
                    case "J":
                        Tetrahedron.SetData();
                        MenuCountTetrahedron++;
                        break;
                    // Allows the user to select the shape corresponding with the letters j.
                    case "j":
                        Tetrahedron.SetData();
                        MenuCountTetrahedron++;
                        break;
                    // Allows the user to list all stored shapes and exits the program.
                    case "0":
                        // Creates a for loop that checks the count for the Rectangle shape and prints the number of inputs.
                        for(int count = 0; count != MenuCountRectangle; count++)
                        { 
                            Console.WriteLine(Rectangle.ToString());
                        }
                        // Creates a for loop that checks the count for the Square shape and prints the number of inputs.
                        for(int count = 0; count != MenuCountSquare; count++)
                        {
                            Console.WriteLine(Square.ToString());
                        }
                        // Creates a for loop that checks the count for the Box shape and prints the number of inputs.
                        for (int count = 0; count != MenuCountBox; count++)
                        {
                            Console.WriteLine(Box.ToString());
                        }
                        // Creates a for loop that checks the count for the Cube shape and prints the number of inputs.
                        for (int count = 0; count != MenuCountCube; count++)
                        {
                            Console.WriteLine(Cube.ToString());
                        }
                        // Creates a for loop that checks the count for the Ellipse shape and prints the number of inputs.
                        for (int count = 0; count != MenuCountEllipse; count++)
                        {
                            Console.WriteLine(Ellipse.ToString());
                        }
                        // Creates a for loop that checks the count for the Circle shape and prints the number of inputs.
                        for (int count = 0; count != MenuCountCircle; count++)
                        {
                            Console.WriteLine(Circle.ToString());
                        }
                        // Creates a for loop that checks the count for the Cylinder shape and prints the number of inputs.
                        for (int count = 0; count != MenuCountCylinder; count++)
                        {
                            Console.WriteLine(Cylinder.ToString());
                        }
                        // Creates a for loop that checks the count for the Sphere shape and prints the number of inputs.
                        for (int count = 0; count != MenuCountSphere; count++)
                        {
                            Console.WriteLine(Sphere.ToString());
                        }
                        // Creates a for loop that checks the count for the Triangle shape and prints the number of inputs.
                        for (int count = 0; count != MenuCountTriangle; count++)
                        {
                            Console.WriteLine(Triangle.ToString());
                        }
                        // Creates a for loop that checks the count for the Tetrahedron shape and prints the number of inputs.
                        for (int count = 0; count != MenuCountTetrahedron; count++)
                        {
                            Console.WriteLine(Tetrahedron.ToString());
                        }
                        // Return and exit the program.
                        return;
                }
        }

        /// <summary>
        /// Creates a menu that outputs text to a console which a user can select from.
        /// </summary>
        /// <returns>Returns the text from the console outputs.</returns>
        private static String Menu()
        {
            // Writes a Menu within the console displaying text outputs the user can choose from.
            // The color cyan is used to change the color of the title console output.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Anthony. Bauld - Lab2A");
            // The color white is used to change the color of the menu console output.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("A - Rectangle     E - Ellipse     I - Triangle");
            Console.WriteLine("B - Square        F - Circle      J - Tetrahedron");
            Console.WriteLine("C - Box           G - Cylinder");
            Console.WriteLine("D - Cube          H - Sphere");
            Console.WriteLine("\n0 - List all shapes and Exit. ");
            Console.Write("\nEnter Choice: ");
            // Returns the next line outputs and display's them within the console
            return Console.ReadLine();
        }
    }
}
