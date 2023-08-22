using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class DigitalClock : Form
    {

        bool bright = false;

        public DigitalClock()
        {
            InitializeComponent();
            BmButton.FlatStyle = FlatStyle.Flat;

        }
        private void DigitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();

        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DateTime pt = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"));
            DateTime et = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
            DateTime gmt = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));
            DateTime jst = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time"));

            TimeLabel.Text = DateTime.Now.ToString();

            switch (TimezoneListBox.SelectedIndex)
            {
                case 0:
                    DisplayTzLabel.Text = "Central European Time";
                    TimeLabel.Text = DateTime.Now.ToString();
                    break;
                case 1:
                    DisplayTzLabel.Text = "Pacific Time(USA, West Coast)";
                    TimeLabel.Text = pt.ToString();
                    break;
                case 2:
                    DisplayTzLabel.Text = "Eastern time(USA, East Coast)";
                    TimeLabel.Text = et.ToString();
                    break;
                case 3:
                    DisplayTzLabel.Text = "Greenwich Mean Time(UK)";
                    TimeLabel.Text = gmt.ToString();
                    break;
                case 4:
                    DisplayTzLabel.Text = "Japan Standard Time";
                    TimeLabel.Text = jst.ToString();
                    break;
            }

        }

        private void BmButton_Click(object sender, EventArgs e)
        {

            if(bright == false)
            {
                BmButton.Text = "Dark mode";
                BmButton.ForeColor = Color.White;
                BmButton.BackColor = Color.Black;
                this.BackColor = Color.White;
                TimeLabel.ForeColor = Color.Black;
                DisplayTzLabel.ForeColor = Color.Black;
                TzLabel.ForeColor = Color.Black;
                bright = true;
            }
            else
            {
                BmButton.Text = "Bright mode";
                BmButton.ForeColor = Color.Black;
                BmButton.BackColor = Color.White;
                this.BackColor = Color.Black;
                TimeLabel.ForeColor = Color.Green;
                DisplayTzLabel.ForeColor = Color.Green;
                TzLabel.ForeColor = Color.Green;
                bright = false;
            }
        }

        private void TimezoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }
    }
}
