using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Nickolas Gettel
// Date: 6/4/2022
// Purpose:
// This Windows Forms app is meant to accept five user submitted temperature values
// that range from -30 to 130 degrees. This app will display the total average 
// of all temperatures currently entered. Once the user has submitted the final
// temp, the app will determine and display one of three separate responses.
// 1) Getting Warmer - All of the temperatures increased with each value.
// 2) Getting Cooler - All of the temperatures decreased with each value.
// 3) It's a mixed bag - Values were up and down, and did not trend in one particular direction.
// The UI consists of a textbox to submit the temp values, a listbox to view all values submitted,
// and a final text box to display the average sum of the temp values. Final trend response
// will be displayed in a label in the middle of the form once a total of 5 temp values
// have been entered. Each temp trend response will have a cooresponding text color.
// Getting warmer will be red, Getting Cooler will be light blue, and It's a mixed bag will be white.

namespace NickolasGettelHomework03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate sum of temperatures listed in listbox and display average in averageSumTextBox
        private void CalculateAndDisplayListBoxSum()
        {
            float tempSum = 0;
            int itemCount = tempListBox.Items.Count;
            if (itemCount > 0)
            {

                foreach (String item in tempListBox.Items)
                {
                    tempSum += float.Parse(item);

                }
                float averageSum = RoundToNearestTenth(tempSum / itemCount);
                averageSumTextBox.Text = averageSum.ToString();
              
            }

        }

        // Parse float to 1 digit after decimal
        private float RoundToNearestTenth(float num)
        {
            return (float)Math.Round(num, 1);
        }

        // Validate user input is within specified temp rang
        private bool IsTempWithinRange(float temp)
        {
            return temp >= -30 && temp <= 130 ? true : false;
        }
        // Determine tempt trend and update temptrendlabel text
        private void DisplayTemperatureTrend()
        {
            // Iterate tempListBox items and evaluate trend
            // Update tempTrendLabel with proper value
            float previousNumber = 0;
            int higher = 0;
            int lower = 0;

            foreach(String item in tempListBox.Items)
            {
                // Increments accumulators while comparing temp with the last value
                float tempNum = float.Parse(item);

                if(previousNumber == 0)
                {
                    previousNumber = tempNum;
                } else
                {
                    if(previousNumber < tempNum)
                    {
                        ++higher;
                        previousNumber = tempNum;
                    } else
                    {
                        ++lower;
                        previousNumber = tempNum;
                    }
                }
            }

            // Display coorisponding output based upon separate accumulators
            if(higher == 4)
            {
                tempTrendLabel.Text = "Getting Warmer";
                tempTrendLabel.ForeColor = Color.Red;
            } else if(lower == 4)
            {
                tempTrendLabel.Text = "Getting Cooler";
                tempTrendLabel.ForeColor = Color.LightBlue;
            } else
            {
                tempTrendLabel.Text = "It's a mixed bag";
                tempTrendLabel.ForeColor = Color.White;
            }
        }

        // Pressing 'Enter' key to add user input into tempListBox if valid
        private void tempInputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tempInputBox.Text != "") 
            {
                try
                {
                    // Check if user input is within range
                    bool isUserInputValid = IsTempWithinRange(float.Parse(tempInputBox.Text));
                    if (isUserInputValid)
                    {
                        // Parse input to proper format and add to tempListBox
                        float tempInput = RoundToNearestTenth(float.Parse(tempInputBox.Text));
                        tempListBox.Items.Add(Convert.ToString(tempInput));
                        tempInputBox.Text = "";

                        // Calculate Sum of all temps listed in tempListBox
                        CalculateAndDisplayListBoxSum();
                    // Error handling: Show message box if user entered value outside of range
                    } else
                    {
                        // If user input is invalid clear tempInputBox and display error message
                        tempInputBox.Text = "";
                        MessageBox.Show("Please enter a value between -30 and 130", "Invalid Entry");
                    }
                } catch
                {
                    // Error handling: Show message if user enters no numeric values
                    tempInputBox.Text = "";
                    MessageBox.Show("Invalid entry. Numbers only.", "Invalid entry");
                }

                // If all 5 list items are present disable input box and display temp trend
                if(tempListBox.Items.Count == 5)
                {
                    tempInputBox.Enabled = false;

                    // Display weather trend in cooresponding label
                    DisplayTemperatureTrend();
                }

            }
        }

        // Clear all values within the tempListBox
        private void clearTempButton_Click(object sender, EventArgs e)
        {
            tempListBox.Items.Clear();
            averageSumTextBox.Text = "";
            tempInputBox.Enabled = true;
            tempTrendLabel.Text = "";
            tempInputBox.Select();
        }

    }
}
