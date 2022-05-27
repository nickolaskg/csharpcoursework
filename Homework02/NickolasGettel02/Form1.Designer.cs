
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VowelCounterForm));
            this.labelA = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.phraseTextBox = new System.Windows.Forms.TextBox();
            this.labelE = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.labelU = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultsLabel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelA.ForeColor = System.Drawing.SystemColors.Control;
            this.labelA.Location = new System.Drawing.Point(5, 6);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(27, 20);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "A:";
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.countButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.countButton.FlatAppearance.BorderSize = 0;
            this.countButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countButton.ForeColor = System.Drawing.Color.Peru;
            this.countButton.Location = new System.Drawing.Point(0, 39);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(128, 51);
            this.countButton.TabIndex = 2;
            this.countButton.Text = "C o u n t   V o w e l s";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // phraseTextBox
            // 
            this.phraseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.phraseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phraseTextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phraseTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.phraseTextBox.Location = new System.Drawing.Point(11, 79);
            this.phraseTextBox.MaxLength = 144;
            this.phraseTextBox.Name = "phraseTextBox";
            this.phraseTextBox.Size = new System.Drawing.Size(316, 27);
            this.phraseTextBox.TabIndex = 1;
            this.phraseTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.phraseTextBox_KeyUp);
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelE.ForeColor = System.Drawing.SystemColors.Control;
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
            this.labelI.ForeColor = System.Drawing.SystemColors.Control;
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
            this.labelO.ForeColor = System.Drawing.SystemColors.Control;
            this.labelO.Location = new System.Drawing.Point(5, 80);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(27, 20);
            this.labelO.TabIndex = 7;
            this.labelO.Text = "O:";
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelU.ForeColor = System.Drawing.SystemColors.Control;
            this.labelU.Location = new System.Drawing.Point(5, 102);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(27, 20);
            this.labelU.TabIndex = 8;
            this.labelU.Text = "U:";
            // 
            // resultsLabel
            // 
            this.resultsLabel.Controls.Add(this.labelA);
            this.resultsLabel.Controls.Add(this.labelU);
            this.resultsLabel.Controls.Add(this.labelE);
            this.resultsLabel.Controls.Add(this.labelO);
            this.resultsLabel.Controls.Add(this.labelI);
            this.resultsLabel.Location = new System.Drawing.Point(128, 126);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(74, 125);
            this.resultsLabel.TabIndex = 9;
            this.resultsLabel.TabStop = true;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.Peru;
            this.resetButton.Location = new System.Drawing.Point(0, 89);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(128, 51);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "R e s e t   A l l ";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.Peru;
            this.exitButton.Location = new System.Drawing.Point(0, 214);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 51);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E x i t  P r o g r a m";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Peru;
            this.textBox1.Location = new System.Drawing.Point(5, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Type a phrase below and click count.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.buttonPanel.Controls.Add(this.label4);
            this.buttonPanel.Controls.Add(this.minimizeButton);
            this.buttonPanel.Controls.Add(this.exitButton2);
            this.buttonPanel.Controls.Add(this.label5);
            this.buttonPanel.Controls.Add(this.label3);
            this.buttonPanel.Controls.Add(this.label2);
            this.buttonPanel.Controls.Add(this.countButton);
            this.buttonPanel.Controls.Add(this.resetButton);
            this.buttonPanel.Controls.Add(this.exitButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPanel.Location = new System.Drawing.Point(343, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(129, 266);
            this.buttonPanel.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(0, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 1);
            this.label4.TabIndex = 20;
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizeButton.ForeColor = System.Drawing.Color.Peru;
            this.minimizeButton.Location = new System.Drawing.Point(82, 5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(22, 22);
            this.minimizeButton.TabIndex = 19;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "__";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton2
            // 
            this.exitButton2.FlatAppearance.BorderSize = 0;
            this.exitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton2.ForeColor = System.Drawing.Color.Peru;
            this.exitButton2.Location = new System.Drawing.Point(105, 7);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(22, 22);
            this.exitButton2.TabIndex = 18;
            this.exitButton2.TabStop = false;
            this.exitButton2.Text = "X";
            this.exitButton2.UseVisualStyleBackColor = true;
            this.exitButton2.Click += new System.EventHandler(this.exitButton2_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(-3, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 1);
            this.label5.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(-1, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 1);
            this.label3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(0, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 1);
            this.label2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Homework02 - Phrase vowel counter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 125);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // VowelCounterForm
            // 
            this.AccessibleDescription = "A program that counts the vowels of the phrase a user enters.";
            this.AccessibleName = "Vowel Counter";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(472, 266);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.phraseTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "VowelCounterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phrase vowel counter";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VowelCounterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VowelCounterForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VowelCounterForm_MouseUp);
            this.resultsLabel.ResumeLayout(false);
            this.resultsLabel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox phraseTextBox;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label labelU;
        private System.Windows.Forms.Panel resultsLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitButton2;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

