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
/// Date: October 25th, 2021
/// Purpose: The purpose of the software is to construct a form that allows a user to choose a hairdresser, service type, and calculate the total.
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>

namespace Lab3B
{
    /// <summary>
    /// Creates a form that will be used to calculate the total amount owed after selecting a hairdresser and service.
    /// </summary>
    public partial class Form1 : Form
    {
        // Creates a variable boolean called HairDresserVerify.
        bool HairDresserVerify = true;

        /// <summary>
        /// Creates the form object called Form1.
        /// </summary>
        public Form1()
        {
            // Required method for designer support.
            InitializeComponent();
            // Auto selects the first collection item (prevents the ability to add no hairdressers).
            HairdresserComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// When the ServiceListBox is clicked, an if statement is created that turns the visibility of the service button on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServiceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the service listbox is clicked enables the service button.
            if (ServiceListBox.SelectedIndex >= 0)
            {
                // Sets the user's ability to click the service button to "enabled".
                AddServiceButton.Enabled = true;
            }
        }

        /// <summary>
        /// Creates an add service button that, when clicked, adds a selected service and pricing to the ChargeBoxes (ChargedListBox/PriceListBox).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            // Sets the drop menu to false which prevents the user from selecting a different hair dresser.
            HairdresserComboBox.Enabled = false;
            // Sets the calulate button to become visable to allow the user to calualte the total amount.
            CalulateTotalButton.Enabled = true;
            // Creates an if statement that selects Jane Samely as the hairdresser if HairdresserComboBox equals 0.
            if (HairdresserComboBox.SelectedIndex == 0)
            {
                if (HairDresserVerify == true)
                {
                    // Creates an if statement that runs this code if HairDresserVerify is true.
                    // Creates a double variable JaneSamleyValue and sets the value to 30.
                    double JaneSamleyValue = 30;
                    // Add's the text Jane Samley to the ChargedListBox.
                    ChargedListBox.Items.Add("Jane Samley");
                    // Add's the value of $30 from PatJohnsonValue to the PriceListBox.
                    PriceListBox.Items.Add(JaneSamleyValue.ToString("0.00"));
                    // Sets the HairDresserVerify to false to prevent muiltple selections of hairdressers. 
                    HairDresserVerify = false;
                }
            }
            // Creates an else if statement that selects Pat Johnson as the hairdresser if HairdresserComboBox equals 1.
            else if (HairdresserComboBox.SelectedIndex == 1)
            {
                // Creates an if statement that runs this code if HairDresserVerify is true.
                if (HairDresserVerify == true)
                {
                    // Creates a double variable PatJohnsonValue and sets the value to 45.
                    double PatJohnsonValue = 45;
                    // Add's the text Pat Johnson to the ChargedListBox.
                    ChargedListBox.Items.Add("Pat Johnson");
                    // Add's the value of $45 from PatJohnsonValue to the PriceListBox.
                    PriceListBox.Items.Add(PatJohnsonValue.ToString("0.00"));
                    // Sets the HairDresserVerify to false to prevent muiltple selections of hairdressers. 
                    HairDresserVerify = false;
                }
            }
            // Creates an else if statement that selects Ron Chambers as the hairdresser if HairdresserComboBox equals 2.
            else if (HairdresserComboBox.SelectedIndex == 2)
            {
                // Creates an if statement that runs this code if HairDresserVerify is true.
                if (HairDresserVerify == true)
                {
                    // Creates a double variable RonChambersValue and sets the value to 40.
                    double RonChambersValue = 40;
                    // Add's the text Ron Chambers to the ChargedListBox.
                    ChargedListBox.Items.Add("Ron Chambers");
                    // Add's the value of $40 from RonChambersValue to the PriceListBox.
                    PriceListBox.Items.Add(RonChambersValue.ToString("0.00"));
                    // Sets the HairDresserVerify to false to prevent muiltple selections of hairdressers. 
                    HairDresserVerify = false;
                }
            }
            // Creates an else if statement that selects Sue Pallon as the hairdresser if HairdresserComboBox equals 3.
            else if (HairdresserComboBox.SelectedIndex == 3)
            {
                // Creates an if statement that runs this code if HairDresserVerify is true.
                if (HairDresserVerify == true)
                {
                    // Creates a double variable SuePallonValue and sets the value to 50.
                    double SuePallonValue = 50;
                    // Add's the text Sue Pallon to the ChargedListBox.
                    ChargedListBox.Items.Add("Sue Pallon");
                    // Add's the value of $50 from SuePallonValue to the PriceListBox.
                    PriceListBox.Items.Add(SuePallonValue.ToString("0.00"));
                    // Sets the HairDresserVerify to false to prevent muiltple selections of hairdressers. 
                    HairDresserVerify = false;
                }
            }
            // Creates an else if statement that selects Laura Renkins as the hairdresser if HairdresserComboBox equals 4.
            else if (HairdresserComboBox.SelectedIndex == 4)
            {
                // Creates an if statement that runs this code if HairDresserVerify is true.
                if (HairDresserVerify == true)
                {
                    // Creates a double variable SuePallonValue and sets the value to 55.
                    double LauraRenkinsValue = 55;
                    // Add's the text Laura Renkins to the ChargedListBox.
                    ChargedListBox.Items.Add("Laura Renkins");
                    // Add's the value of $55 from SuePallonValue to the PriceListBox.
                    PriceListBox.Items.Add(LauraRenkinsValue.ToString("0.00"));
                    // Sets the HairDresserVerify to false to prevent muiltple selections of hairdressers. 
                    HairDresserVerify = false;
                }
            }
            // Creates an if statement that selects runs code if ServiceListBox equals 0.
            if (ServiceListBox.SelectedIndex == 0)
            {
                // Creates a variable called CutValue and sets it to 30.
                double CutValue = 30;
                // Add's the text Cut to the ChargedListBox.
                ChargedListBox.Items.Add("Cut");
                // Add's the value of $30 from CutValue to the PriceListBox.
                PriceListBox.Items.Add(CutValue.ToString("0.00"));
            }
            // Creates an if statement that selects runs code if ServiceListBox equals 1.
            if (ServiceListBox.SelectedIndex == 1)
            {
                // Creates a variable called WashValue and sets it to 20.
                double WashValue = 20;
                // Add's the text Wash, blow-dry, and.. to the ChargedListBox.
                ChargedListBox.Items.Add("Wash, blow-dry, and..");
                // Add's the value of $20 from WashValue to the PriceListBox.
                PriceListBox.Items.Add(WashValue.ToString("0.00"));
            }
            // Creates an if statement that selects runs code if ServiceListBox equals 2.
            if (ServiceListBox.SelectedIndex == 2)
            {
                // Creates a variable called ColorValue and sets it to 40.
                double ColorValue = 40;
                // Add's the text Color to the ChargedListBox.
                ChargedListBox.Items.Add("Color");
                // Add's the value of $40 from ColorValue to the PriceListBox.
                PriceListBox.Items.Add(ColorValue.ToString("0.00"));
            }
            // Creates an if statement that selects runs code if ServiceListBox equals 3.
            if (ServiceListBox.SelectedIndex == 3)
            {
                // Creates a variable called HighlightsValue and sets it to 50.
                double HighlightsValue = 50;
                // Add's the text Highlights to the ChargedListBox.
                ChargedListBox.Items.Add("Highlights");
                // Add's the value of $50 from HighlightsValue to the PriceListBox.
                PriceListBox.Items.Add(HighlightsValue.ToString("0.00"));
            }
            // Creates an if statement that selects runs code if ServiceListBox equals 4.
            if (ServiceListBox.SelectedIndex == 4)
            {
                // Creates a variable called ExtensionValue and sets it to 200.
                double ExtensionValue = 200;
                // Add's the text Extentions to the ChargedListBox.
                ChargedListBox.Items.Add("Extentions");
                // Add's the value of $200 from ExtensionValue to the PriceListBox.
                PriceListBox.Items.Add(ExtensionValue.ToString("0.00"));
            }
            // Creates an if statement that selects runs code if ServiceListBox equals 5.
            if (ServiceListBox.SelectedIndex == 5)
            {
                // Creates a variable called UpDoValue and sets it to 60.
                double UpDoValue = 60;
                // Add's the text Up-Do to the ChargedListBox.
                ChargedListBox.Items.Add("Up-Do");
                // Add's the value of $60 from UpDoValue to the PriceListBox.
                PriceListBox.Items.Add(UpDoValue.ToString("0.00"));
            }
        }

        /// <summary>
        /// When you press the calculate button, the total cost from the hairdresser and services will be calculated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalulateTotalButton_Click(object sender, EventArgs e)
        {
            // Creates a double variable FinalePrice and sets the value to 0.
            double FinalPrice = 0;
            // Creates a for loop that uses i to count the items in PriceListBox.
            for (int i = 0; i < PriceListBox.Items.Count; i++)
            {
                // Creates a variable called FinalPrice, which is used to convert the items in the PriceListBox to a double count using i.
                FinalPrice = FinalPrice + Convert.ToDouble(PriceListBox.Items[i]);
            }
            // Formats the outputted TotalPrice using a ToSting() method.
            TotalPrice.Text = FinalPrice.ToString("$" + "0.00");
        }

        /// <summary>
        /// The application will be reset to its original state when the reset button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Makes the service button not visable.
            AddServiceButton.Enabled = false;
            // Clears the selected item in ServiceListBox.
            ServiceListBox.SelectedItem = null;
            // Makes the Calulate total button not visable.
            CalulateTotalButton.Enabled = false;
            // Enables the selection of the hairdressers.
            HairdresserComboBox.Enabled = true;
            // Sets the default postion to Jane Samley.
            HairdresserComboBox.SelectedIndex = 0;
            // Sets the default variable value to true.
            HairDresserVerify = true;
            // Clears the items displayed within the ChargedListBox.
            ChargedListBox.Items.Clear();
            // Clears the prices displayed with the PriceListBox.
            PriceListBox.Items.Clear();
            // Clears the TotalPrice text that was outputted.
            TotalPrice.Text = "";
        }

        /// <summary>
        /// When the exit button is pressed, the software is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Closes the application.
            System.Windows.Forms.Application.Exit();
        }
    }
}
