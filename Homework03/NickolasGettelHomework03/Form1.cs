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

        
        private void CalcTempSum()
        {
            // Calculate sum of temps listed in tempListView
            // And update tempSumBox with that value
        }

        private void tempInputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tempInputBox.Text != "")
                {
                    tempListView.Items.Add(tempInputBox.Text);
                    tempInputBox.Text = "";

                    CalcTempSum();
                }
            }

        }

        private void clearTempButton_Click(object sender, EventArgs e)
        {
            tempListView.Clear();
        }

    }
}
