namespace RPG_Char_Stats_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayInfoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentRaceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentLevelTextBox = new System.Windows.Forms.TextBox();
            this.updateNameTextBox = new System.Windows.Forms.TextBox();
            this.updateRaceTextBox = new System.Windows.Forms.TextBox();
            this.updateLevelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.addSheetButton = new System.Windows.Forms.Button();
            this.deleteSheetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayInfoLabel
            // 
            this.displayInfoLabel.AutoSize = true;
            this.displayInfoLabel.Location = new System.Drawing.Point(165, 9);
            this.displayInfoLabel.Name = "displayInfoLabel";
            this.displayInfoLabel.Size = new System.Drawing.Size(65, 13);
            this.displayInfoLabel.TabIndex = 0;
            this.displayInfoLabel.Text = "Sheet 0 of 0";
           // this.displayInfoLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // currentNameTextBox
            // 
            this.currentNameTextBox.Location = new System.Drawing.Point(13, 71);
            this.currentNameTextBox.Name = "currentNameTextBox";
            this.currentNameTextBox.ReadOnly = true;
            this.currentNameTextBox.Size = new System.Drawing.Size(169, 20);
            this.currentNameTextBox.TabIndex = 2;
            this.currentNameTextBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Race";
            // 
            // currentRaceTextBox
            // 
            this.currentRaceTextBox.Location = new System.Drawing.Point(13, 111);
            this.currentRaceTextBox.Name = "currentRaceTextBox";
            this.currentRaceTextBox.ReadOnly = true;
            this.currentRaceTextBox.Size = new System.Drawing.Size(169, 20);
            this.currentRaceTextBox.TabIndex = 2;
            this.currentRaceTextBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Level";
            // 
            // currentLevelTextBox
            // 
            this.currentLevelTextBox.Location = new System.Drawing.Point(13, 151);
            this.currentLevelTextBox.Name = "currentLevelTextBox";
            this.currentLevelTextBox.ReadOnly = true;
            this.currentLevelTextBox.Size = new System.Drawing.Size(169, 20);
            this.currentLevelTextBox.TabIndex = 2;
            this.currentLevelTextBox.TabStop = false;
            // 
            // updateNameTextBox
            // 
            this.updateNameTextBox.Location = new System.Drawing.Point(219, 71);
            this.updateNameTextBox.Name = "updateNameTextBox";
            this.updateNameTextBox.Size = new System.Drawing.Size(169, 20);
            this.updateNameTextBox.TabIndex = 0;
            // 
            // updateRaceTextBox
            // 
            this.updateRaceTextBox.Location = new System.Drawing.Point(219, 111);
            this.updateRaceTextBox.Name = "updateRaceTextBox";
            this.updateRaceTextBox.Size = new System.Drawing.Size(169, 20);
            this.updateRaceTextBox.TabIndex = 1;
            // 
            // updateLevelTextBox
            // 
            this.updateLevelTextBox.Location = new System.Drawing.Point(219, 151);
            this.updateLevelTextBox.Name = "updateLevelTextBox";
            this.updateLevelTextBox.Size = new System.Drawing.Size(169, 20);
            this.updateLevelTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "(Change these to update)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "(Change these to update)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "(Change these to update)";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(219, 197);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(169, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update Sheet";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(13, 241);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(123, 23);
            this.previousButton.TabIndex = 5;
            this.previousButton.Text = "Previous Sheet";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(265, 241);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(123, 23);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next Sheet";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // addSheetButton
            // 
            this.addSheetButton.Location = new System.Drawing.Point(13, 307);
            this.addSheetButton.Name = "addSheetButton";
            this.addSheetButton.Size = new System.Drawing.Size(123, 23);
            this.addSheetButton.TabIndex = 6;
            this.addSheetButton.Text = "Add Sheet";
            this.addSheetButton.UseVisualStyleBackColor = true;
            this.addSheetButton.Click += new System.EventHandler(this.addSheetButton_Click);
            // 
            // deleteSheetButton
            // 
            this.deleteSheetButton.Location = new System.Drawing.Point(265, 307);
            this.deleteSheetButton.Name = "deleteSheetButton";
            this.deleteSheetButton.Size = new System.Drawing.Size(123, 23);
            this.deleteSheetButton.TabIndex = 6;
            this.deleteSheetButton.Text = "Delete Current Sheet";
            this.deleteSheetButton.UseVisualStyleBackColor = true;
            this.deleteSheetButton.Click += new System.EventHandler(this.deleteSheetButton_Click);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 365);
            this.Controls.Add(this.deleteSheetButton);
            this.Controls.Add(this.addSheetButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateLevelTextBox);
            this.Controls.Add(this.currentLevelTextBox);
            this.Controls.Add(this.updateRaceTextBox);
            this.Controls.Add(this.currentRaceTextBox);
            this.Controls.Add(this.updateNameTextBox);
            this.Controls.Add(this.currentNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayInfoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            
        }

        #endregion

        private System.Windows.Forms.Label displayInfoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentRaceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentLevelTextBox;
        private System.Windows.Forms.TextBox updateNameTextBox;
        private System.Windows.Forms.TextBox updateRaceTextBox;
        private System.Windows.Forms.TextBox updateLevelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button addSheetButton;
        private System.Windows.Forms.Button deleteSheetButton;
    }
}

