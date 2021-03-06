using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Author: Nickolas Gettel
// Date: 6/4/2022
// Purpose:
// This Windows Froms application is intended to accept a user 
// entered phrase, and then count the number of vowels that
// appear in the phrase (not counting Y). I designed the UI
// to have the following functionality; A textbox for user input,
// a Label to count each individual vowel, and three separate
// buttons; Count Vowels- which serves the main function of counting
// vowels in the phrase, Reset All- a button that clears both the vowel
// list and the textbox, Exit Program- Simply a button to exit the program.
// A user should also be able to press enter while the textbox is focused 
// to count the vowels without having to click the Count Vowel button.


namespace NickolasGettel02
{
    public partial class VowelCounterForm : Form
    {
    
        // Store vowel counts in Vowel object
        private Vowel vowel = new Vowel();

        // Props for moving form without titlebar
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        // Define IntPtr for rounded corner styling
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        // *****Constructor and initial load methods*****
        public VowelCounterForm()
        {
            InitializeComponent();

            // Change form style to rounded corners
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            UpdateLabels();
        }


        // *****Button actions*****
        private void countButton_Click(object sender, EventArgs e)
        {
            CountVowels();
            ResetAllValues();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            phraseTextBox.Text = "";
            ResetAllValues();
            UpdateLabels();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Execute count function upon user pressing 'Enter' button while inside textbox
        private void phraseTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CountVowels();
                UpdateLabels();
                ResetAllValues();
            }

        }

        // *****Action methods - Update / Reset / Count*****
        public void UpdateLabels()
        {
            labelA.Text = "A: " + vowel.VowelA;
            labelE.Text = "E: " + vowel.VowelE;
            labelI.Text = "I: " + vowel.VowelI;
            labelO.Text = "O: " + vowel.VowelO;
            labelU.Text = "U: " + vowel.VowelU;
        }
        private void ResetAllValues()
        {
            vowel.VowelA = 0;
            vowel.VowelE = 0;
            vowel.VowelI = 0;
            vowel.VowelO = 0;
            vowel.VowelU = 0;
        }

        private void CountVowels()
        {
            for (int i = 0; i < phraseTextBox.TextLength; i++)
            {
                string phrase = phraseTextBox.Text.ToLower();
                switch (phrase[i])
                {
                    case 'a':
                        vowel.VowelA++;
                        break;
                    case 'e':
                        vowel.VowelE++;
                        break;
                    case 'i':
                        vowel.VowelI++;
                        break;
                    case 'o':
                        vowel.VowelO++;
                        break;
                    case 'u':
                        vowel.VowelU++;
                        break;
                }
            }

            UpdateLabels();
        }

        // *****Events for moving form without titlebar*****
        private void VowelCounterForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void VowelCounterForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void VowelCounterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

    }
}
