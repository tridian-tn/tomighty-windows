//
//  Tomighty - http://www.tomighty.org
//
//  This software is licensed under the Apache License Version 2.0:
//  http://www.apache.org/licenses/LICENSE-2.0.txt
//

namespace Tomighty.Windows.Preferences
{
    partial class UserPreferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPreferencesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.longBreakDurationTextBox = new System.Windows.Forms.NumericUpDown();
            this.shortBreakDurationTextBox = new System.Windows.Forms.NumericUpDown();
            this.pomodoroDurationTextBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxPomodoroCountTextBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.soundNotifications = new System.Windows.Forms.CheckBox();
            this.toastNotification = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.autoupdate = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longBreakDurationTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortBreakDurationTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroDurationTextBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxPomodoroCountTextBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.longBreakDurationTextBox);
            this.groupBox1.Controls.Add(this.shortBreakDurationTextBox);
            this.groupBox1.Controls.Add(this.pomodoroDurationTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // longBreakDurationTextBox
            // 
            resources.ApplyResources(this.longBreakDurationTextBox, "longBreakDurationTextBox");
            this.longBreakDurationTextBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.longBreakDurationTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.longBreakDurationTextBox.Name = "longBreakDurationTextBox";
            this.longBreakDurationTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shortBreakDurationTextBox
            // 
            resources.ApplyResources(this.shortBreakDurationTextBox, "shortBreakDurationTextBox");
            this.shortBreakDurationTextBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shortBreakDurationTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shortBreakDurationTextBox.Name = "shortBreakDurationTextBox";
            this.shortBreakDurationTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pomodoroDurationTextBox
            // 
            resources.ApplyResources(this.pomodoroDurationTextBox, "pomodoroDurationTextBox");
            this.pomodoroDurationTextBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.pomodoroDurationTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pomodoroDurationTextBox.Name = "pomodoroDurationTextBox";
            this.pomodoroDurationTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.maxPomodoroCountTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // maxPomodoroCountTextBox
            // 
            resources.ApplyResources(this.maxPomodoroCountTextBox, "maxPomodoroCountTextBox");
            this.maxPomodoroCountTextBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maxPomodoroCountTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxPomodoroCountTextBox.Name = "maxPomodoroCountTextBox";
            this.maxPomodoroCountTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OnOkButtonClick);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.soundNotifications);
            this.tabPage2.Controls.Add(this.toastNotification);
            this.tabPage2.Controls.Add(this.label8);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // soundNotifications
            // 
            resources.ApplyResources(this.soundNotifications, "soundNotifications");
            this.soundNotifications.Name = "soundNotifications";
            this.soundNotifications.UseVisualStyleBackColor = true;
            // 
            // toastNotification
            // 
            resources.ApplyResources(this.toastNotification, "toastNotification");
            this.toastNotification.Name = "toastNotification";
            this.toastNotification.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.autoupdate);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // autoupdate
            // 
            resources.ApplyResources(this.autoupdate, "autoupdate");
            this.autoupdate.Name = "autoupdate";
            this.autoupdate.UseVisualStyleBackColor = true;
            // 
            // UserPreferencesForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserPreferencesForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longBreakDurationTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortBreakDurationTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroDurationTextBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxPomodoroCountTextBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown maxPomodoroCountTextBox;
        private System.Windows.Forms.NumericUpDown longBreakDurationTextBox;
        private System.Windows.Forms.NumericUpDown shortBreakDurationTextBox;
        private System.Windows.Forms.NumericUpDown pomodoroDurationTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox toastNotification;
        private System.Windows.Forms.CheckBox soundNotifications;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox autoupdate;
    }
}