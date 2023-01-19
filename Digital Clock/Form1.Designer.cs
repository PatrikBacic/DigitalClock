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
            this.timeLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.bmButton = new System.Windows.Forms.Button();
            this.timezoneListBox = new System.Windows.Forms.ListBox();
            this.displayTzLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Green;
            this.timeLabel.Location = new System.Drawing.Point(88, 59);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(620, 306);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = ". . .";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // bmButton
            // 
            this.bmButton.BackColor = System.Drawing.Color.White;
            this.bmButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmButton.ForeColor = System.Drawing.Color.Black;
            this.bmButton.Location = new System.Drawing.Point(88, 381);
            this.bmButton.Name = "bmButton";
            this.bmButton.Size = new System.Drawing.Size(104, 23);
            this.bmButton.TabIndex = 1;
            this.bmButton.Text = "Bright mode";
            this.bmButton.UseVisualStyleBackColor = false;
            this.bmButton.Click += new System.EventHandler(this.bmButton_Click);
            // 
            // timezoneListBox
            // 
            this.timezoneListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timezoneListBox.FormattingEnabled = true;
            this.timezoneListBox.Items.AddRange(new object[] {
            "CET",
            "PST",
            "EST",
            "GMT",
            "JST",
            " "});
            this.timezoneListBox.Location = new System.Drawing.Point(588, 401);
            this.timezoneListBox.Name = "timezoneListBox";
            this.timezoneListBox.Size = new System.Drawing.Size(120, 67);
            this.timezoneListBox.TabIndex = 2;
            this.timezoneListBox.SelectedIndexChanged += new System.EventHandler(this.timezoneListBox_SelectedIndexChanged);
            // 
            // displayTzLabel
            // 
            this.displayTzLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTzLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.displayTzLabel.ForeColor = System.Drawing.Color.Green;
            this.displayTzLabel.Location = new System.Drawing.Point(189, 20);
            this.displayTzLabel.Name = "displayTzLabel";
            this.displayTzLabel.Size = new System.Drawing.Size(421, 39);
            this.displayTzLabel.TabIndex = 3;
            this.displayTzLabel.Text = "Central European Time";
            this.displayTzLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(791, 512);
            this.Controls.Add(this.displayTzLabel);
            this.Controls.Add(this.timezoneListBox);
            this.Controls.Add(this.bmButton);
            this.Controls.Add(this.timeLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "DigitalClock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.DigitalClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button bmButton;
        private System.Windows.Forms.ListBox timezoneListBox;
        private System.Windows.Forms.Label displayTzLabel;
    }
}

