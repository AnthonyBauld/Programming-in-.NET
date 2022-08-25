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
/// Date: October 4th, 2021
/// Purpose: The program's goal is to construct a hairdressing form that allows the user to enter several input options and receive a calculation.
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>

namespace Lab2B
{
    public partial class Form1 : Form
    {
        // This function creates a HairdresserPrice variable.
        private double HairdresserPrice { get; set; }
        // This function creates a TotalService variable.
        private double TotalService { get; set; }
        // This function creates a FinalDiscount variable.
        private double FinalDiscount { get; set; }
        // This function creates a TotalPrice variable.
        private double TotalPrice { get; set; }
        // This function creates a DiscountMath variable.
        private double DiscountMath { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a form that allows the user to check radiobuttons, checkboxs to find out the pricing of a certain combination of options and produces the calulation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalulateButton_Click(object sender, EventArgs e)
        {
            // Creates an if statement that, if JaneSamelyButton is checked return HairDressesPrice = 30.
            if (JaneSamleyButton.Checked)
            {
                HairdresserPrice = 30;
            }
            // Creates an else if statement that, if PatJohnsonButton is checked return HairDressesPrice = 45.
            else if (PatJohnsonButton.Checked)
            {
                HairdresserPrice = 45;
            }
            // Creates an else if statement that, if RonChambersButton is checked return HairDressesPrice = 40.
            else if (RonChambersButton.Checked)
            {
                HairdresserPrice = 40;
            }
            // Creates an else if statement that, if SuePallonButton is checked return HairDressesPrice = 50.
            else if (SuePallonButton.Checked)
            {
                HairdresserPrice = 50;
            }
            // Creates an else if statement that, if LauraRenkinsButton is checked return HairDressesPrice = 55.
            else if (LauraRenkinsButton.Checked)
            {
                HairdresserPrice = 55;
            }

            // This function creates a ClientDiscount variable and set it to 0.
            double ClientDiscount = 0;
            // Creates a if statement that, if AdultButton is checked return ClientDiscount = 0.00.
            if (AdultButton.Checked)
            {
                ClientDiscount = 0.00;
            }
            // Creates a else if statement that, if ChildButton is checked return ClientDiscount = 0.10.
            else if (ChildButton.Checked)
            {
                ClientDiscount = 0.10;
            }
            // Creates a else if statement that, if StudentButton is checked return ClientDiscount = 0.05.
            else if (StudentButton.Checked)
            {
                ClientDiscount = 0.05;
            }
            // Creates a else if statement that, if SeniorButton is checked return ClientDiscount = 0.15.
            else if (SeniorButton.Checked)
            {
                ClientDiscount = 0.15;
            }

            // This function creates a CutCheckBoxPrice variable and set it to 0.
            double CutCheckBoxPrice = 0;
            // This function creates a ColorCheckBoxPrice variable and set it to 0.
            double ColorCheckBoxPrice = 0;
            // This function creates a HighlightCheckBoxPrice variable and set it to 0.
            double HighlightCheckBoxPrice = 0;
            // This function creates a ExtentionCheckBoxPrice variable and set it to 0.
            double ExtentionCheckBoxPrice = 0;
            // Creates a if statement that, if CutCheckBox is checked return CutCheckBoxPrice = 30.
            if (CutCheckBox.Checked == true)
            {
                CutCheckBoxPrice = 30;
            }
            // Creates a if statement that, if CutCheckBox is checked return ColorCheckBoxPrice = 40.
            if (ColorCheckBox.Checked)
            {
                ColorCheckBoxPrice = 40;
            }
            // Creates a if statement that, if CutCheckBox is checked return HighlightCheckBoxPrice = 50.
            if (HighlightCheckBox.Checked == true)
            {
                HighlightCheckBoxPrice = 50;
            }
            // Creates a if statement that, if CutCheckBox is checked return ExtentionCheckBoxPrice = 200.
            if (ExtensionsCheckBox.Checked == true)
            {
                ExtentionCheckBoxPrice = 200;
            }
            // If none of the CutCheckBox, ColorCheckBox, HighlightCheckBox, ExtensionsCheckBox == true return a error message.
            else
            {
                MessageBox.Show("An error has occurred; please continue by \nselecting one of the services.");
            }
            // Add's CutCheckBoxPrice + ColorCheckBoxPrice + HighlightCheckBoxPrice + ExtentionCheckBoxPrice to deteremine the total service discount.
            TotalService = CutCheckBoxPrice + ColorCheckBoxPrice + HighlightCheckBoxPrice + ExtentionCheckBoxPrice;

            // This function creates a ClientVisitDiscount variable and set it to 0.
            double ClientVisitDiscount = 0;
            // This function converts ClientTextBox into a double variable called ClientVisits.
            double ClientVisits = double.Parse(ClientTextBox.Text);
            // Creates an if statement that if ClientVisits is between 1-3 return ClientVisitDiscount = 0.00.
            if (ClientVisits >= 1 && ClientVisits <= 3)
            {
                ClientVisitDiscount = 0.00;
            }
            // Creates an else if statement that if ClientVisits is between 4-8 return ClientVisitDiscount = 0.05.
            else if (ClientVisits >= 4 && ClientVisits <= 8)
            {
                ClientVisitDiscount = 0.05;
            }
            // Creates an else if statement that if ClientVisits is between 9-13 return ClientVisitDiscount = 0.10.
            else if (ClientVisits >= 9 && ClientVisits <= 13)
            {
                ClientVisitDiscount = 0.10;
            }
            // Creates an else if statement that if ClientVisits is above 14 return ClientVisitDiscount = 0.15.
            else if (ClientVisits >= 14)
            {
                ClientVisitDiscount = 0.15;
            }

            // To acquire DiscountMath, combine the discounts for Visiting and Clients.
            DiscountMath = ClientVisitDiscount + ClientDiscount;
            // Takes the base HairDresser, adds TotalService, then multiplies by DiscountMath to get the FinalDiscount.
            FinalDiscount = (HairdresserPrice + TotalService) * DiscountMath;
            // Take HairDresserPrice, add Total Service, then remove FinalDiscount to get the final price that will be displayed to the user.
            TotalPrice = (HairdresserPrice + TotalService) - FinalDiscount;
            // Sets the TotalPrice to a decimal value of 0.00.
            TotalPriceLabel.Text = "$" + TotalPrice.ToString("0.00");
        }

        /// <summary>
        /// Creates a button that closes the programme when pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // When the exit button is pressed close the application.
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// Creates a button that clears the current forms that have been filled in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // When the clear button is pressed clear the TotalPriceLabel.
            TotalPriceLabel.Text = "";
            // When the clear button is pressed clear the ClientTextBox.
            ClientTextBox.Text = "";
            // When the clear button is pressed clear the CutCheckBox to unchecked.
            CutCheckBox.Checked = false;
            // When the clear button is pressed clear the CutCheckBox to unchecked.
            ColorCheckBox.Checked = false;
            // When the clear button is pressed clear the CutCheckBox to unchecked.
            HighlightCheckBox.Checked = false;
            // When the clear button is pressed clear the CutCheckBox to unchecked.
            ExtensionsCheckBox.Checked = false;
            // When the clear button is return JaneSamleyButton to it's original state.
            JaneSamleyButton.Checked = true;
            // When the clear button is return JaneSamleyButton to it's original state.
            AdultButton.Checked = true;
        }

        private void CutCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
