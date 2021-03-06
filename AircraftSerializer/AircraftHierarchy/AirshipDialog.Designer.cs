﻿namespace AircraftSerializer
{
    partial class AirshipDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.maxLoadTextBox = new System.Windows.Forms.TextBox();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.propulsionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max load:";
            // 
            // maxLoadTextBox
            // 
            this.maxLoadTextBox.Location = new System.Drawing.Point(117, 12);
            this.maxLoadTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxLoadTextBox.Name = "maxLoadTextBox";
            this.maxLoadTextBox.Size = new System.Drawing.Size(76, 22);
            this.maxLoadTextBox.TabIndex = 1;
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(117, 44);
            this.massTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(76, 22);
            this.massTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mass:";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(117, 76);
            this.volumeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(76, 22);
            this.volumeTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Volume:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(21, 185);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(173, 28);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Rigid",
            "Non-rigid"});
            this.typeComboBox.Location = new System.Drawing.Point(104, 108);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(89, 24);
            this.typeComboBox.TabIndex = 9;
            // 
            // propulsionComboBox
            // 
            this.propulsionComboBox.FormattingEnabled = true;
            this.propulsionComboBox.Items.AddRange(new object[] {
            "Jet",
            "Propeller"});
            this.propulsionComboBox.Location = new System.Drawing.Point(104, 142);
            this.propulsionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.propulsionComboBox.Name = "propulsionComboBox";
            this.propulsionComboBox.Size = new System.Drawing.Size(89, 24);
            this.propulsionComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Propulsion:";
            // 
            // AirshipDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 223);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.propulsionComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.massTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxLoadTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AirshipDialog";
            this.Text = "Airship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxLoadTextBox;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox propulsionComboBox;
        private System.Windows.Forms.Label label5;
    }
}