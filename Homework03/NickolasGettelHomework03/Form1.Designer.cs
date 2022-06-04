
namespace NickolasGettelHomework03
{
    partial class Form1
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
            this.tempInputBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.tempRangeLabel = new System.Windows.Forms.Label();
            this.overallTrendLabel = new System.Windows.Forms.Label();
            this.clearTempButton = new System.Windows.Forms.Button();
            this.tempTrendLabel = new System.Windows.Forms.Label();
            this.tempListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.averageSumTextBox = new System.Windows.Forms.TextBox();
            this.averageSumLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempInputBox
            // 
            this.tempInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.tempInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempInputBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempInputBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tempInputBox.Location = new System.Drawing.Point(188, 8);
            this.tempInputBox.Name = "tempInputBox";
            this.tempInputBox.Size = new System.Drawing.Size(53, 19);
            this.tempInputBox.TabIndex = 0;
            this.tempInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tempInputBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tempInputBox_KeyUp);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.instructionLabel.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.instructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(192)))), ((int)(((byte)(105)))));
            this.instructionLabel.Location = new System.Drawing.Point(9, 11);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(259, 19);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Add 5 temperatures to find  the trend";
            // 
            // tempRangeLabel
            // 
            this.tempRangeLabel.AutoSize = true;
            this.tempRangeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.tempRangeLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempRangeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tempRangeLabel.Location = new System.Drawing.Point(11, 11);
            this.tempRangeLabel.Name = "tempRangeLabel";
            this.tempRangeLabel.Size = new System.Drawing.Size(137, 18);
            this.tempRangeLabel.TabIndex = 2;
            this.tempRangeLabel.Text = "Temp Rang -30 to 130";
            // 
            // overallTrendLabel
            // 
            this.overallTrendLabel.AutoSize = true;
            this.overallTrendLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.overallTrendLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overallTrendLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.overallTrendLabel.Location = new System.Drawing.Point(11, 46);
            this.overallTrendLabel.Name = "overallTrendLabel";
            this.overallTrendLabel.Size = new System.Drawing.Size(94, 18);
            this.overallTrendLabel.TabIndex = 4;
            this.overallTrendLabel.Text = "Overall trend:";
            // 
            // clearTempButton
            // 
            this.clearTempButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.clearTempButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearTempButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearTempButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clearTempButton.Location = new System.Drawing.Point(11, 138);
            this.clearTempButton.Name = "clearTempButton";
            this.clearTempButton.Size = new System.Drawing.Size(230, 40);
            this.clearTempButton.TabIndex = 1;
            this.clearTempButton.Text = "Clear Temperatures";
            this.clearTempButton.UseVisualStyleBackColor = false;
            this.clearTempButton.Click += new System.EventHandler(this.clearTempButton_Click);
            // 
            // tempTrendLabel
            // 
            this.tempTrendLabel.AutoSize = true;
            this.tempTrendLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.tempTrendLabel.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tempTrendLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tempTrendLabel.Location = new System.Drawing.Point(11, 86);
            this.tempTrendLabel.Name = "tempTrendLabel";
            this.tempTrendLabel.Size = new System.Drawing.Size(134, 23);
            this.tempTrendLabel.TabIndex = 8;
            this.tempTrendLabel.Text = "                               ";
            // 
            // tempListBox
            // 
            this.tempListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.tempListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tempListBox.FormattingEnabled = true;
            this.tempListBox.ItemHeight = 18;
            this.tempListBox.Location = new System.Drawing.Point(188, 37);
            this.tempListBox.Name = "tempListBox";
            this.tempListBox.Size = new System.Drawing.Size(53, 90);
            this.tempListBox.TabIndex = 9;
            this.tempListBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.averageSumTextBox);
            this.panel1.Controls.Add(this.averageSumLabel);
            this.panel1.Controls.Add(this.tempListBox);
            this.panel1.Controls.Add(this.tempInputBox);
            this.panel1.Controls.Add(this.tempTrendLabel);
            this.panel1.Controls.Add(this.tempRangeLabel);
            this.panel1.Controls.Add(this.overallTrendLabel);
            this.panel1.Controls.Add(this.clearTempButton);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 226);
            this.panel1.TabIndex = 10;
            // 
            // averageSumTextBox
            // 
            this.averageSumTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.averageSumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.averageSumTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.averageSumTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.averageSumTextBox.Location = new System.Drawing.Point(188, 193);
            this.averageSumTextBox.Name = "averageSumTextBox";
            this.averageSumTextBox.Size = new System.Drawing.Size(53, 19);
            this.averageSumTextBox.TabIndex = 11;
            this.averageSumTextBox.TabStop = false;
            // 
            // averageSumLabel
            // 
            this.averageSumLabel.AutoSize = true;
            this.averageSumLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.averageSumLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.averageSumLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.averageSumLabel.Location = new System.Drawing.Point(11, 193);
            this.averageSumLabel.Name = "averageSumLabel";
            this.averageSumLabel.Size = new System.Drawing.Size(165, 18);
            this.averageSumLabel.TabIndex = 10;
            this.averageSumLabel.Text = "Average Sum of all temps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(280, 284);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.instructionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Trend";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tempInputBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label tempRangeLabel;
        private System.Windows.Forms.Label overallTrendLabel;
        private System.Windows.Forms.Button clearTempButton;
        private System.Windows.Forms.Label tempTrendLabel;
        private System.Windows.Forms.ListBox tempListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox averageSumTextBox;
        private System.Windows.Forms.Label averageSumLabel;
    }
}

