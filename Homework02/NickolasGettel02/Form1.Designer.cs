
namespace NickolasGettel02
{
    partial class VowelCounterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelA = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.phraseTextBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.labelU = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultsLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelA.Location = new System.Drawing.Point(5, 6);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(27, 20);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "A:";
            // 
            // countButton
            // 
            this.countButton.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countButton.Location = new System.Drawing.Point(256, 85);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(171, 32);
            this.countButton.TabIndex = 2;
            this.countButton.Text = "Count Vowels";
            this.countButton.UseVisualStyleBackColor = true;
            // 
            // phraseTextBox
            // 
            this.phraseTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.phraseTextBox.Location = new System.Drawing.Point(12, 41);
            this.phraseTextBox.MaxLength = 144;
            this.phraseTextBox.Name = "phraseTextBox";
            this.phraseTextBox.Size = new System.Drawing.Size(434, 23);
            this.phraseTextBox.TabIndex = 1;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLabel.Location = new System.Drawing.Point(13, 11);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(188, 18);
            this.textLabel.TabIndex = 4;
            this.textLabel.Text = "Type a phrase in the text box:";
            this.textLabel.Click += new System.EventHandler(this.textLabel_Click);
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelE.Location = new System.Drawing.Point(5, 31);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(27, 20);
            this.labelE.TabIndex = 5;
            this.labelE.Text = "E:";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelI.Location = new System.Drawing.Point(5, 56);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(27, 20);
            this.labelI.TabIndex = 6;
            this.labelI.Text = "I:";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelO.Location = new System.Drawing.Point(5, 81);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(27, 20);
            this.labelO.TabIndex = 7;
            this.labelO.Text = "O:";
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelU.Location = new System.Drawing.Point(5, 102);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(27, 20);
            this.labelU.TabIndex = 8;
            this.labelU.Text = "U:";
            this.labelU.Click += new System.EventHandler(this.label6_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.Controls.Add(this.labelA);
            this.resultsLabel.Controls.Add(this.labelU);
            this.resultsLabel.Controls.Add(this.labelE);
            this.resultsLabel.Controls.Add(this.labelO);
            this.resultsLabel.Controls.Add(this.labelI);
            this.resultsLabel.Location = new System.Drawing.Point(13, 85);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(200, 125);
            this.resultsLabel.TabIndex = 9;
            this.resultsLabel.TabStop = true;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(256, 123);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(171, 31);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset Vowels";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(256, 179);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(171, 31);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit Program";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // VowelCounterForm
            // 
            this.AccessibleDescription = "A program that counts the vowels of the phrase a user enters.";
            this.AccessibleName = "Vowel Counter";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.phraseTextBox);
            this.Controls.Add(this.countButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(474, 262);
            this.MinimumSize = new System.Drawing.Size(474, 262);
            this.Name = "VowelCounterForm";
            this.Text = "Phrase vowel counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.resultsLabel.ResumeLayout(false);
            this.resultsLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox phraseTextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label labelU;
        private System.Windows.Forms.Panel resultsLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

