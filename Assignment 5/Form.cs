using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Author: Anthony. Bauld 
/// Date: December 10th, 2021
/// Purpose: The purpose of the software is to create a fauct that fills when you move the trackbar.
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>
/// 
namespace Lab5A
{
    public partial class Form1 : Form
    {
        // Create's a white variable pen that will be the colour "white".
        private Pen white = new Pen(Color.White);
        // Create's a black variable pen that will be the colour "black".
        private Pen black = new Pen(Color.Black);
        // Create's a graphics variable called "g".
        private Graphics g;
        // Create's a graphic variable called "rg".
        private Graphics rg;
        // Create's a solid brush variable called "b".
        private SolidBrush b;
        // Creates a "color" variable with the color lightskyblue as the value.
        private Color c = Color.LightSkyBlue;

        public Form1()
        {
            InitializeComponent();
            // Create's a painteventhandler that controls the paint within "frmMain_Paint".
            this.Paint += new PaintEventHandler(frmMain_Paint);
            // Create's a maximum value for the trackbar to display.
            trackBar2.Maximum = 130;
            //Create's a minimum value for the trackbar to display.
            trackBar2.Minimum = 1;
        }

        /// <summary>
        /// When the close button is clicked the program will exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            // When the close button is pressed, the application is exited.
            Application.Exit();
        }

        /// <summary>
        /// When the program is executed it will create a (bucket) that will be filled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            // Set's a variable g to create a graphic paint event. 
            g = e.Graphics;
            // Variable b is set to a new solid brush with the colour from variable c.
            b = new SolidBrush(c);
            // Create's a new rectagnle called "rectangle1" at the postion (75, 275, 225, 150).
            Rectangle Rectangle1 = new Rectangle(75, 275, 225, 150);
            // Draw's the variable rectangle1 with the color white.
            g.DrawRectangle(white, Rectangle1);
            // Create's a new rectagnle called "rectangle2" at the postion (75, 275, 225, 5).
            Rectangle Rectangle2 = new Rectangle(75, 275, 225, 5);
            // Draw's the variable rectangle2 with the color black.
            g.DrawRectangle(black, Rectangle2);
        }

        /// <summary>
        /// When the color button is clicked a color dialog will open and allow the user to select a color for the (water).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorButton_Click(object sender, EventArgs e)
        {
            // Set's the colordialog to the variable "c".
            colorDialog.Color = c;     
            // Open's the colordialog using the showdialog() function.
            colorDialog.ShowDialog();   
            // Set's the variable c to what the user selects within the colordialog.
            c = colorDialog.Color;               
        }

        /// <summary>
        /// Create's a trackbar that will allow the user to fill the bucket with water.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            // Set's the variable g to creategraphics() function to allow drawing.
            g = this.CreateGraphics();
            // Set's the variable rg to creategraphics() function to allow drawing.
            rg = this.CreateGraphics();
            // Change's the variable rg using the translatetransform() function to change the placement of the drawing.
            rg.TranslateTransform(0, Height);
            // Change's the sacling operation of the rg variable using the scaletransform() function.
            rg.ScaleTransform(1, -1);
            // Create's a rectangle that's filled with the location (93, 175, 23, 250).
            g.FillRectangle(b, 93, 175, 23, 250);
            // Create's a rectangle that's filled with the location (93, 175, 23) while using the trackbar value to fill based on how far the bar is moved.
            rg.FillRectangle(b, 76, 59, 224, trackBar2.Value);
        }
    }
}
