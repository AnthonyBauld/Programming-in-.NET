using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Author: Anthony. Bauld
/// Date: November 21st, 2021
/// Purpose: The program's goal is to open a.HTML file and determine whether or not it is balanced by determining whether or not it contains the necessary block begins and endings.
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>

namespace Lab4B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // The check tag button will not be shown if the file is not loaded into the form.
            checkTagsToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Opens a file explorer window where you may choose a.HTML file to be imported into an array and displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creates a string variable called "inputFile".
            String inputFile = "";
            // When selecting a file to input, creates a filter that only shows.html files and all files.
            openFile.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
            // This is the name of the panel that allows you to choose a file.
            openFile.Title = "Open File";
            // Execute the following if statement if the file dialogue is equal to okay.
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // The variable "inputFile" is used to set the name of the open file.
                inputFile = openFile.FileName;
                // When the file is loaded into the form, the labelText is set to the file's original title to indicate that it has been loaded.
                labelText.Text = "Loaded: " + Path.GetFileName(inputFile);
                // The check tag button is now visible if the file has been loaded into the form.
                checkTagsToolStripMenuItem.Enabled = true;
            }
            // If the statement above is wrong, the else statement is executed.
            else
            {
                // If the file isn't selected correctly or the user picks cancel, a message box appears.
                MessageBox.Show("You have not selected a file.");
            }
        }

        /// <summary>
        /// Within the htmlListBox, it checks the tags in the.HTML file and displays if they are correct or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This method creates a StreamReader to read the file.
            StreamReader data = new StreamReader(openFile.FileName);
            // Creates a generic stack T> array that will be used to find and show the current HTML code blocks.
            Stack<string> Tags = new Stack<string>();
            // Creates a string variable called "inputFile".
            String TagLine;
            // Creates a while loop in which the string "TagLine" is set to the data, which reads the lines in the file.
            while ((TagLine = data.ReadLine()) != null)
            {
                // Creates an if statement that searches the data file for the block <html>.
                if (TagLine.Contains("<html>"))
                {
                    // The word <html> is pushed, and it will be utilised in the display output.
                    Tags.Push("<html>");
                    // If the data file contains the block <html>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the opening tag: " + Tags.Pop());
                }
                // Creates an else if statement that searches the data file for the block </html>.
                else if (TagLine.Contains("</html>"))
                {
                    // The word </html> is pushed, and it will be utilised in the display output.
                    Tags.Push("</html>");
                    // If the data file contains the block </html>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the closing tag: " + Tags.Pop());
                }
                // Creates an if statement that searches the data file for the block <body>.
                if (TagLine.Contains("body>"))
                {
                    // The word <body> is pushed, and it will be utilised in the display output.
                    Tags.Push("</body>");
                    // If the data file contains the block <body>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the opening tag: " + Tags.Pop());
                }
                // Creates an else if statement that searches the data file for the block </body>.
                else if (TagLine.Contains("</body>"))
                {
                    // The word </body> is pushed, and it will be utilised in the display output.
                    Tags.Push("</body>");
                    // If the data file contains the block </body>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the closing tag: " + Tags.Pop());
                }
                // Creates an if statement that searches the data file for the block <title>.
                if (TagLine.Contains("title>"))
                {
                    // The word <title> is pushed, and it will be utilised in the display output.
                    Tags.Push("</title>");
                    // If the data file contains the block <title>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the opening tag: " + Tags.Pop());
                }
                // Creates an else if statement that searches the data file for the block </title>.
                else if (TagLine.Contains("</title>"))
                {
                    // The word </title> is pushed, and it will be utilised in the display output.
                    Tags.Push("</title>");
                    // If the data file contains the block </title>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the closing tag: " + Tags.Pop());
                }
                // Creates an if statement that searches the data file for the block <h1>.
                if (TagLine.Contains("h1>"))
                {
                    // The word <h1> is pushed, and it will be utilised in the display output.
                    Tags.Push("</h1>");
                    // If the data file contains the block <h1>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the opening tag: " + Tags.Pop());
                }
                // Creates an else if statement that searches the data file for the block </h1>.
                else if (TagLine.Contains("</h1>"))
                {
                    // The word </h1> is pushed, and it will be utilised in the display output.
                    Tags.Push("</h1>");
                    // If the data file contains the block </h1>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the closing tag: " + Tags.Pop());
                }
                // Creates an if statement that searches the data file for the block <p>.
                if (TagLine.Contains("<p>"))
                {
                    // The word <p> is pushed, and it will be utilised in the display output.
                    Tags.Push("</p>");
                    // If the data file contains the block <p>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the opening tag: " + Tags.Pop());
                }
                // Creates an else if statement that searches the data file for the block </p>.
                else if (TagLine.Contains("</p>"))
                {
                    // The word </p> is pushed, and it will be utilised in the display output.
                    Tags.Push("</p>");
                    // If the data file contains the block </p>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the closing tag: " + Tags.Pop());
                }
                // Creates an if statement that searches the data file for the block <br>.
                if (TagLine.Contains("<br>"))
                {
                    // The word <br> is pushed, and it will be utilised in the display output.
                    Tags.Push("</br>");
                    // If the data file contains the block <br>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the opening tag: " + Tags.Pop());
                }
                // Creates an else if statement that searches the data file for the block </br>.
                else if (TagLine.Contains("</br>"))
                {
                    // The word </br> is pushed, and it will be utilised in the display output.
                    Tags.Push("</br>");
                    // If the data file contains the block </br>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the closing tag: " + Tags.Pop());
                }
                // Creates an if statement that searches the data file for the block <hr>.
                if (TagLine.Contains("<hr>"))
                {
                    // The word <hr> is pushed, and it will be utilised in the display output.
                    Tags.Push("</hr>");
                    // If the data file contains the block <hr>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the opening tag: " + Tags.Pop());
                }
                // Creates an else if statement that searches the data file for the block </hr>.
                else if (TagLine.Contains("</hr>"))
                {
                    // The word </hr> is pushed, and it will be utilised in the display output.
                    Tags.Push("</hr>");
                    // If the data file contains the block </hr>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the closing tag: " + Tags.Pop());
                }
                // Creates an if statement that searches the data file for the block <table>.
                if (TagLine.Contains("<table>"))
                {
                    // The word <table> is pushed, and it will be utilised in the display output.
                    Tags.Push("</table>");
                    // If the data file contains the block <table>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the opening tag: " + Tags.Pop());
                }
                // Creates an else if statement that searches the data file for the block </table>.
                else if (TagLine.Contains("</table>"))
                {
                    // The word </table> is pushed, and it will be utilised in the display output.
                    Tags.Push("</table>");
                    // If the data file contains the block </table>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the closing tag: " + Tags.Pop());
                }
                // Creates an if statement that searches the data file for the block <tr>.
                if (TagLine.Contains("<tr>"))
                {
                    // The word <tr> is pushed, and it will be utilised in the display output.
                    Tags.Push("</tr>");
                    // If the data file contains the block <tr>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the opening tag: " + Tags.Pop());
                }
                // Creates an else if statement that searches the data file for the block </tr>.
                else if (TagLine.Contains("</tr>"))
                {
                    // The word </tr> is pushed, and it will be utilised in the display output.
                    Tags.Push("</tr>");
                    // If the data file contains the block </tr>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the closing tag: " + Tags.Pop());
                }
                // Creates an if statement that searches the data file for the block <td>.
                if (TagLine.Contains("<td>"))
                {
                    // The word <td> is pushed, and it will be utilised in the display output.
                    Tags.Push("</td>");
                    // If the data file contains the block <td>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the opening tag: " + Tags.Pop());
                }
                // Creates an else if statement that searches the data file for the block </td>.
                else if (TagLine.Contains("</td>"))
                {
                    // The word </td> is pushed, and it will be utilised in the display output.
                    Tags.Push("</td>");
                    // If the data file contains the block </td>, the item is added to the htmlListBox.
                    htmlListBox.Items.Add("Found the closing tag: " + Tags.Pop());
                }
            }
        }

        /// <summary>
        /// Exit's the program when the user clicks this button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the current application.
            Application.Exit();
        }
    }
}
