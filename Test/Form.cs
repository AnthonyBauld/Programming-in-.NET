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
/// Date: November 4th, 2021
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>

namespace MidtermQ3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WeatherListBox.DataSource = File.ReadAllLines("Weather.txt"); 

        }

        private void AddData_Click(object sender, EventArgs e)
        {
            if (dataTextBox.Text != "")
            {
                WeatherListBox.Items.Add(dataTextBox.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
