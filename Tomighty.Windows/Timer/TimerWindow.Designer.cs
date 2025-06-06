//
//  Tomighty - http://www.tomighty.org
//
//  This software is licensed under the Apache License Version 2.0:
//  http://www.apache.org/licenses/LICENSE-2.0.txt
//

namespace Tomighty.Windows.Timer
{
    partial class TimerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerWindow));
            this.timeLabel = new Tomighty.Windows.Timer.TimerWindow.TransparentLabel();
            this.pinButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new Tomighty.Windows.Timer.TimerWindow.TransparentLabel();
            this.timerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Name = "timeLabel";
            // 
            // pinButton
            // 
            this.pinButton.CausesValidation = false;
            this.pinButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.pinButton, "pinButton");
            this.pinButton.Image = global::Tomighty.Windows.Properties.Resources.image_unpinned;
            this.pinButton.Name = "pinButton";
            this.pinButton.TabStop = false;
            this.pinButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.CausesValidation = false;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.Image = global::Tomighty.Windows.Properties.Resources.image_x;
            this.closeButton.Name = "closeButton";
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Name = "titleLabel";
            // 
            // timerButton
            // 
            resources.ApplyResources(this.timerButton, "timerButton");
            this.timerButton.BackColor = System.Drawing.Color.Silver;
            this.timerButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.timerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.timerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.timerButton.Name = "timerButton";
            this.timerButton.UseVisualStyleBackColor = false;
            this.timerButton.Click += new System.EventHandler(this.OnTimerButtonClick);
            // 
            // TimerWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ControlBox = false;
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pinButton);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentLabel timeLabel;
        private System.Windows.Forms.Button pinButton;
        private System.Windows.Forms.Button closeButton;
        private TransparentLabel titleLabel;
        private System.Windows.Forms.Button timerButton;
    }
}