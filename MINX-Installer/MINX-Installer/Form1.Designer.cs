namespace MINX_Installer
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.installDetectorButton = new System.Windows.Forms.Button();
            this.vsVersionPanel = new System.Windows.Forms.Panel();
            this.vs13Dir = new System.Windows.Forms.Label();
            this.vs12Dir = new System.Windows.Forms.Label();
            this.vs10Dir = new System.Windows.Forms.Label();
            this.vs13Checkbox = new System.Windows.Forms.CheckBox();
            this.vs12Checkbox = new System.Windows.Forms.CheckBox();
            this.vs10Checkbox = new System.Windows.Forms.CheckBox();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.installMINXButton = new System.Windows.Forms.Button();
            this.installProgress = new System.Windows.Forms.ProgressBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.vsVersionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(239, 13);
            label1.TabIndex = 3;
            label1.Text = "Select Which Visual Studio Versions to Install To:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(277, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 13);
            label2.TabIndex = 3;
            label2.Text = "Installation Log";
            // 
            // installDetectorButton
            // 
            this.installDetectorButton.Location = new System.Drawing.Point(13, 13);
            this.installDetectorButton.Name = "installDetectorButton";
            this.installDetectorButton.Size = new System.Drawing.Size(120, 38);
            this.installDetectorButton.TabIndex = 0;
            this.installDetectorButton.Text = "Detect Visual Studio Installations";
            this.installDetectorButton.UseVisualStyleBackColor = true;
            this.installDetectorButton.Click += new System.EventHandler(this.installDetectorButton_Click);
            // 
            // vsVersionPanel
            // 
            this.vsVersionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vsVersionPanel.Controls.Add(this.vs13Dir);
            this.vsVersionPanel.Controls.Add(this.vs12Dir);
            this.vsVersionPanel.Controls.Add(this.vs10Dir);
            this.vsVersionPanel.Controls.Add(label1);
            this.vsVersionPanel.Controls.Add(this.vs13Checkbox);
            this.vsVersionPanel.Controls.Add(this.vs12Checkbox);
            this.vsVersionPanel.Controls.Add(this.vs10Checkbox);
            this.vsVersionPanel.Enabled = false;
            this.vsVersionPanel.Location = new System.Drawing.Point(13, 57);
            this.vsVersionPanel.Name = "vsVersionPanel";
            this.vsVersionPanel.Size = new System.Drawing.Size(258, 199);
            this.vsVersionPanel.TabIndex = 1;
            // 
            // vs13Dir
            // 
            this.vs13Dir.AutoSize = true;
            this.vs13Dir.Location = new System.Drawing.Point(3, 175);
            this.vs13Dir.Name = "vs13Dir";
            this.vs13Dir.Size = new System.Drawing.Size(0, 13);
            this.vs13Dir.TabIndex = 7;
            // 
            // vs12Dir
            // 
            this.vs12Dir.AutoSize = true;
            this.vs12Dir.Location = new System.Drawing.Point(3, 118);
            this.vs12Dir.Name = "vs12Dir";
            this.vs12Dir.Size = new System.Drawing.Size(0, 13);
            this.vs12Dir.TabIndex = 6;
            // 
            // vs10Dir
            // 
            this.vs10Dir.AutoSize = true;
            this.vs10Dir.Location = new System.Drawing.Point(3, 71);
            this.vs10Dir.Name = "vs10Dir";
            this.vs10Dir.Size = new System.Drawing.Size(0, 13);
            this.vs10Dir.TabIndex = 5;
            // 
            // vs13Checkbox
            // 
            this.vs13Checkbox.AutoSize = true;
            this.vs13Checkbox.Location = new System.Drawing.Point(6, 155);
            this.vs13Checkbox.Name = "vs13Checkbox";
            this.vs13Checkbox.Size = new System.Drawing.Size(67, 17);
            this.vs13Checkbox.TabIndex = 2;
            this.vs13Checkbox.Text = "VS 2013";
            this.vs13Checkbox.UseVisualStyleBackColor = true;
            // 
            // vs12Checkbox
            // 
            this.vs12Checkbox.AutoSize = true;
            this.vs12Checkbox.Location = new System.Drawing.Point(6, 98);
            this.vs12Checkbox.Name = "vs12Checkbox";
            this.vs12Checkbox.Size = new System.Drawing.Size(67, 17);
            this.vs12Checkbox.TabIndex = 1;
            this.vs12Checkbox.Text = "VS 2012";
            this.vs12Checkbox.UseVisualStyleBackColor = true;
            // 
            // vs10Checkbox
            // 
            this.vs10Checkbox.AutoSize = true;
            this.vs10Checkbox.Location = new System.Drawing.Point(6, 51);
            this.vs10Checkbox.Name = "vs10Checkbox";
            this.vs10Checkbox.Size = new System.Drawing.Size(67, 17);
            this.vs10Checkbox.TabIndex = 0;
            this.vs10Checkbox.Text = "VS 2010";
            this.vs10Checkbox.UseVisualStyleBackColor = true;
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.consoleBox.Location = new System.Drawing.Point(277, 34);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.Size = new System.Drawing.Size(307, 193);
            this.consoleBox.TabIndex = 2;
            // 
            // installMINXButton
            // 
            this.installMINXButton.Location = new System.Drawing.Point(277, 233);
            this.installMINXButton.Name = "installMINXButton";
            this.installMINXButton.Size = new System.Drawing.Size(307, 23);
            this.installMINXButton.TabIndex = 4;
            this.installMINXButton.Text = "Install MINX";
            this.installMINXButton.UseVisualStyleBackColor = true;
            this.installMINXButton.Click += new System.EventHandler(this.installMINXButton_Click);
            // 
            // installProgress
            // 
            this.installProgress.Location = new System.Drawing.Point(13, 275);
            this.installProgress.Name = "installProgress";
            this.installProgress.Size = new System.Drawing.Size(571, 23);
            this.installProgress.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 310);
            this.Controls.Add(this.installProgress);
            this.Controls.Add(this.installMINXButton);
            this.Controls.Add(label2);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.vsVersionPanel);
            this.Controls.Add(this.installDetectorButton);
            this.Name = "Form1";
            this.Text = "MINX Installer";
            this.vsVersionPanel.ResumeLayout(false);
            this.vsVersionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button installDetectorButton;
        private System.Windows.Forms.Panel vsVersionPanel;
        private System.Windows.Forms.CheckBox vs13Checkbox;
        private System.Windows.Forms.CheckBox vs12Checkbox;
        private System.Windows.Forms.CheckBox vs10Checkbox;
        private System.Windows.Forms.Label vs13Dir;
        private System.Windows.Forms.Label vs12Dir;
        private System.Windows.Forms.Label vs10Dir;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.Button installMINXButton;
        private System.Windows.Forms.ProgressBar installProgress;
    }
}

