
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
            this.averageSumLabel = new System.Windows.Forms.Label();
            this.averageSumTextBox = new System.Windows.Forms.TextBox();
            this.tempTrendLabel = new System.Windows.Forms.Label();
            this.tempListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tempInputBox
            // 
            this.tempInputBox.Location = new System.Drawing.Point(163, 56);
            this.tempInputBox.Name = "tempInputBox";
            this.tempInputBox.Size = new System.Drawing.Size(53, 23);
            this.tempInputBox.TabIndex = 0;
            this.tempInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tempInputBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tempInputBox_KeyUp);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(13, 26);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(203, 15);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Add 5 temperatures to find  the trend";
            // 
            // tempRangeLabel
            // 
            this.tempRangeLabel.AutoSize = true;
            this.tempRangeLabel.Location = new System.Drawing.Point(13, 59);
            this.tempRangeLabel.Name = "tempRangeLabel";
            this.tempRangeLabel.Size = new System.Drawing.Size(121, 15);
            this.tempRangeLabel.TabIndex = 2;
            this.tempRangeLabel.Text = "Temp Rang -30 to 130";
            // 
            // overallTrendLabel
            // 
            this.overallTrendLabel.AutoSize = true;
            this.overallTrendLabel.Location = new System.Drawing.Point(43, 94);
            this.overallTrendLabel.Name = "overallTrendLabel";
            this.overallTrendLabel.Size = new System.Drawing.Size(75, 15);
            this.overallTrendLabel.TabIndex = 4;
            this.overallTrendLabel.Text = "Overall trend";
            // 
            // clearTempButton
            // 
            this.clearTempButton.Location = new System.Drawing.Point(12, 175);
            this.clearTempButton.Name = "clearTempButton";
            this.clearTempButton.Size = new System.Drawing.Size(204, 40);
            this.clearTempButton.TabIndex = 5;
            this.clearTempButton.Text = "Clear Temperatures";
            this.clearTempButton.UseVisualStyleBackColor = true;
            this.clearTempButton.Click += new System.EventHandler(this.clearTempButton_Click);
            // 
            // averageSumLabel
            // 
            this.averageSumLabel.AutoSize = true;
            this.averageSumLabel.Location = new System.Drawing.Point(12, 236);
            this.averageSumLabel.Name = "averageSumLabel";
            this.averageSumLabel.Size = new System.Drawing.Size(142, 15);
            this.averageSumLabel.TabIndex = 6;
            this.averageSumLabel.Text = "Average Sum of all temps";
            // 
            // averageSumTextBox
            // 
            this.averageSumTextBox.Location = new System.Drawing.Point(165, 233);
            this.averageSumTextBox.Name = "averageSumTextBox";
            this.averageSumTextBox.Size = new System.Drawing.Size(52, 23);
            this.averageSumTextBox.TabIndex = 7;
            // 
            // tempTrendLabel
            // 
            this.tempTrendLabel.AutoSize = true;
            this.tempTrendLabel.Location = new System.Drawing.Point(42, 137);
            this.tempTrendLabel.Name = "tempTrendLabel";
            this.tempTrendLabel.Size = new System.Drawing.Size(92, 15);
            this.tempTrendLabel.TabIndex = 8;
            this.tempTrendLabel.Text = "Need more data";
            // 
            // tempListBox
            // 
            this.tempListBox.FormattingEnabled = true;
            this.tempListBox.ItemHeight = 15;
            this.tempListBox.Location = new System.Drawing.Point(163, 85);
            this.tempListBox.Name = "tempListBox";
            this.tempListBox.Size = new System.Drawing.Size(53, 79);
            this.tempListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 275);
            this.Controls.Add(this.tempListBox);
            this.Controls.Add(this.tempTrendLabel);
            this.Controls.Add(this.averageSumTextBox);
            this.Controls.Add(this.averageSumLabel);
            this.Controls.Add(this.clearTempButton);
            this.Controls.Add(this.overallTrendLabel);
            this.Controls.Add(this.tempRangeLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.tempInputBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tempInputBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label tempRangeLabel;
        private System.Windows.Forms.Label overallTrendLabel;
        private System.Windows.Forms.Button clearTempButton;
        private System.Windows.Forms.Label averageSumLabel;
        private System.Windows.Forms.TextBox averageSumTextBox;
        private System.Windows.Forms.Label tempTrendLabel;
        private System.Windows.Forms.ListBox tempListBox;
    }
}

