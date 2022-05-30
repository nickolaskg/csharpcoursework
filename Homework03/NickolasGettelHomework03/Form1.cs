using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NickolasGettelHomework03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate sum of temperatures listed in listbox and display average in averageSumTextBox
        private void CalcTempSum()
        {
            double tempSum = 0;
            int itemCount = tempListBox.Items.Count;
            if (itemCount > 0)
            {

                foreach (String item in tempListBox.Items)
                {
                    tempSum += double.Parse(item);

                }
                averageSumTextBox.Text = (tempSum / itemCount).ToString();
            }

        }

        // Validate user input is within specified temp rang
        private bool ValidateTempRange(int temp)
        {
            return temp >= -30 && temp <= 130 ? true : false;
        }


        // Upon user pressing 'Enter' key, add user input into tempListBox if valid
        private void tempInputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // Check if user input is within range
                    bool isUserInputValid = ValidateTempRange(Int32.Parse(tempInputBox.Text));
                    if (isUserInputValid)
                    {
                        // Add temp to tempListBox and clear tempInputBox
                        tempListBox.Items.Add(tempInputBox.Text.ToString());
                        tempInputBox.Text = "";

                        // Calculate Sum of all temps listed in tempListBox
                        CalcTempSum();
                    } else
                    {
                        // If user input is invalid clear tempInputBox and display error message
                        tempInputBox.Text = "";
                        MessageBox.Show("Please enter a value between -30 and 130", "Invalid Entry");
                    }
                } catch
                {
                    // Error message displayed in above if else statement
                }

                if(tempListBox.Items.Count == 5)
                {
                    tempInputBox.Enabled = false;

                    // Display weather trend in cooresponding label
                }

            }
        }

        // Clear all values within the tempListBox
        private void clearTempButton_Click(object sender, EventArgs e)
        {
            tempListBox.Items.Clear();
        }

    }
}
