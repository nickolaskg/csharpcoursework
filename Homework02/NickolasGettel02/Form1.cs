using System;
using System.Windows.Forms;

namespace NickolasGettel02
{
    public partial class VowelCounterForm : Form
    {
        private readonly Vowels vowels = new Vowels();

        public void updateLabels()
        {

            labelA.Text = "A: " + vowels.GetVowelA();
            labelE.Text = "E: " + vowels.GetVowelE();
            labelI.Text = "I: " + vowels.GetVowelI();
            labelO.Text = "O: " + vowels.GetVowelO();
            labelU.Text = "U: " + vowels.GetVowelU();
        }

        public VowelCounterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            updateLabels();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

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

        private void phraseTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                countVowels();
                updateLabels();
            }

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
                // Count vowels and add to Vowels class properties
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

       
    }
}
