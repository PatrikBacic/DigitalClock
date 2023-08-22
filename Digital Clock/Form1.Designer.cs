namespace Digital_Clock
{
    partial class DigitalClock
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
            this.components = new System.ComponentModel.Container();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.BmButton = new System.Windows.Forms.Button();
            this.TimezoneListBox = new System.Windows.Forms.ListBox();
            this.DisplayTzLabel = new System.Windows.Forms.Label();
            this.TzLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Green;
            this.TimeLabel.Location = new System.Drawing.Point(88, 59);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(620, 306);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = ". . .";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // BmButton
            // 
            this.BmButton.BackColor = System.Drawing.Color.White;
            this.BmButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BmButton.ForeColor = System.Drawing.Color.Black;
            this.BmButton.Location = new System.Drawing.Point(88, 401);
            this.BmButton.Name = "BmButton";
            this.BmButton.Size = new System.Drawing.Size(138, 39);
            this.BmButton.TabIndex = 1;
            this.BmButton.Text = "Bright mode";
            this.BmButton.UseVisualStyleBackColor = false;
            this.BmButton.Click += new System.EventHandler(this.BmButton_Click);
            // 
            // TimezoneListBox
            // 
            this.TimezoneListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimezoneListBox.FormattingEnabled = true;
            this.TimezoneListBox.Items.AddRange(new object[] {
            "CET",
            "PST",
            "EST",
            "GMT",
            "JST",
            " "});
            this.TimezoneListBox.Location = new System.Drawing.Point(588, 401);
            this.TimezoneListBox.Name = "TimezoneListBox";
            this.TimezoneListBox.Size = new System.Drawing.Size(120, 67);
            this.TimezoneListBox.TabIndex = 2;
            this.TimezoneListBox.SelectedIndexChanged += new System.EventHandler(this.TimezoneListBox_SelectedIndexChanged);
            // 
            // DisplayTzLabel
            // 
            this.DisplayTzLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayTzLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DisplayTzLabel.ForeColor = System.Drawing.Color.Green;
            this.DisplayTzLabel.Location = new System.Drawing.Point(189, 20);
            this.DisplayTzLabel.Name = "DisplayTzLabel";
            this.DisplayTzLabel.Size = new System.Drawing.Size(421, 39);
            this.DisplayTzLabel.TabIndex = 3;
            this.DisplayTzLabel.Text = "Central European Time";
            this.DisplayTzLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TzLabel
            // 
            this.TzLabel.AutoSize = true;
            this.TzLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TzLabel.ForeColor = System.Drawing.Color.Green;
            this.TzLabel.Location = new System.Drawing.Point(584, 375);
            this.TzLabel.Name = "TzLabel";
            this.TzLabel.Size = new System.Drawing.Size(115, 23);
            this.TzLabel.TabIndex = 4;
            this.TzLabel.Text = "Time zones:";
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(791, 512);
            this.Controls.Add(this.TzLabel);
            this.Controls.Add(this.DisplayTzLabel);
            this.Controls.Add(this.TimezoneListBox);
            this.Controls.Add(this.BmButton);
            this.Controls.Add(this.TimeLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "DigitalClock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.DigitalClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button BmButton;
        private System.Windows.Forms.ListBox TimezoneListBox;
        private System.Windows.Forms.Label DisplayTzLabel;
        private System.Windows.Forms.Label TzLabel;
    }
}

