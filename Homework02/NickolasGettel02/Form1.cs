using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NickolasGettel02
{
    public partial class VowelCounterForm : Form
    {
        // Store vowel counts in Vowel object
        private readonly Vowels vowels = new Vowels();

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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateLabels();
        }

        // *****Button actions*****
        private void countButton_Click(object sender, EventArgs e)
        {

            countVowels();
            resetAllValues();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            phraseTextBox.Text = "";
            resetAllValues();
            updateLabels();
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
                countVowels();
                updateLabels();
                resetAllValues();
            }

        }

        // *****Action methods - Update / Reset / Count*****
        public void updateLabels()
        {
            labelA.Text = "A: " + vowels.GetVowelA();
            labelE.Text = "E: " + vowels.GetVowelE();
            labelI.Text = "I: " + vowels.GetVowelI();
            labelO.Text = "O: " + vowels.GetVowelO();
            labelU.Text = "U: " + vowels.GetVowelU();
        }
        private void resetAllValues()
        {
            vowels.SetVowelA(0);
            vowels.SetVowelE(0);
            vowels.SetVowelO(0);
            vowels.SetVowelI(0);
            vowels.SetVowelU(0);
        }

        private void countVowels()
        {
            for (int i = 0; i < phraseTextBox.TextLength; i++)
            {
                string phrase = phraseTextBox.Text.ToLower();
                switch (phrase[i])
                {
                    case 'a':
                        vowels.SetVowelA(vowels.GetVowelA() + 1);
                        break;
                    case 'e':
                        vowels.SetVowelE(vowels.GetVowelE() + 1);
                        break;
                    case 'i':
                        vowels.SetVowelI(vowels.GetVowelI() + 1);
                        break;
                    case 'o':
                        vowels.SetVowelO(vowels.GetVowelO() + 1);
                        break;
                    case 'u':
                        vowels.SetVowelU(vowels.GetVowelU() + 1);
                        break;
                }
            }

            updateLabels();
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
