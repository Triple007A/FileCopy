namespace FileCopy
{
    partial class FileCopyApp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.forceButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.allFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.timerNumericBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.timerNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source directory";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(16, 29);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(552, 20);
            this.sourceTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination directory";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(16, 68);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(552, 20);
            this.destinationTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Delay (in seconds):";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(16, 138);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(180, 50);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.Location = new System.Drawing.Point(202, 138);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(180, 50);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // forceButton
            // 
            this.forceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.forceButton.Location = new System.Drawing.Point(388, 138);
            this.forceButton.Name = "forceButton";
            this.forceButton.Size = new System.Drawing.Size(180, 50);
            this.forceButton.TabIndex = 8;
            this.forceButton.Text = "Force synchronization";
            this.forceButton.UseVisualStyleBackColor = true;
            this.forceButton.Click += new System.EventHandler(this.forceButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "File extenions (separated by \",\") ie. \".jpg\"";
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.Location = new System.Drawing.Point(16, 111);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(201, 20);
            this.extensionTextBox.TabIndex = 10;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(19, 138);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(460, 95);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 36);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save settings";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(426, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Arkadiusz Kowalczyk © 2018";
            // 
            // allFilesCheckBox
            // 
            this.allFilesCheckBox.AutoSize = true;
            this.allFilesCheckBox.Location = new System.Drawing.Point(354, 106);
            this.allFilesCheckBox.Name = "allFilesCheckBox";
            this.allFilesCheckBox.Size = new System.Drawing.Size(100, 17);
            this.allFilesCheckBox.TabIndex = 15;
            this.allFilesCheckBox.Text = "Replace all files";
            this.allFilesCheckBox.UseVisualStyleBackColor = true;
            this.allFilesCheckBox.CheckedChanged += new System.EventHandler(this.allFilesCheckBox_CheckedChanged);
            // 
            // timerNumericBox
            // 
            this.timerNumericBox.Location = new System.Drawing.Point(226, 111);
            this.timerNumericBox.Maximum = new decimal(new int[] {
            -1821689629,
            1293503,
            0,
            0});
            this.timerNumericBox.Name = "timerNumericBox";
            this.timerNumericBox.Size = new System.Drawing.Size(120, 20);
            this.timerNumericBox.TabIndex = 16;
            this.timerNumericBox.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // FileCopyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 214);
            this.Controls.Add(this.timerNumericBox);
            this.Controls.Add(this.allFilesCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.extensionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.forceButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FileCopyApp";
            this.Text = "FileCopy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timerNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button forceButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox allFilesCheckBox;
        private System.Windows.Forms.NumericUpDown timerNumericBox;
    }
}

