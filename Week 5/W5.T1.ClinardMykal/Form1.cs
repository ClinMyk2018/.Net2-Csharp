using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5.T1.ClinardMykal
{
    public partial class Form1 : Form
    {
        // Initializing the variables
        Bitmap back, hour, minute, dot, second;        

        private void button1_Click(object sender, EventArgs e) //This is the button that adds the new Alarm
        {
            // This lets you know if you did not fill out all of the fields
            if (listBox1.SelectedItem == null 
                || listBox2.SelectedItem == null) 
            {
                MessageBox.Show("Please select one of each of the fields " +
                    "in the Alarm section to set an alarm.");
            }
            else // Adds the new alarm to the Label 2 Box
            {
                String HourAlarm = listBox1.SelectedItem.ToString();
                String MinuteAlarm = listBox2.SelectedItem.ToString();
                String NewAlarm = HourAlarm + ":" + MinuteAlarm ;
                label2.Text = NewAlarm;

            }           
            
        }


        private void button2_Click(object sender, EventArgs e) // This clears the Alarm set
        {
            label2.Text = "";
            listBox1.SelectedItem = false;
            listBox2.SelectedItem = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // This is the current date and it broken down there after
            DateTime Now = DateTime.Now;
            int Hour = Now.Hour;
            int Minute = Now.Minute;
            int Second = Now.Second;

            // Displaying the current time in the label for digital view
            label1.Text = Hour.ToString() + ":" + Minute;

            // Instantiating the way the rotating will work for Hour, Minute, Second
            Single AngleS = Second * 6;
            Single AngleM = Minute * 6 + AngleS / 60;
            Single AngleH = Hour * 30 + AngleM / 12;

            // Clock Face
            backBox.Image = back;
            // Hour
            backBox.Controls.Add(hourBox);
            hourBox.Location = new Point(0, 0);
            hourBox.Image = rotateImage(hour, AngleH);
            // Minute
            hourBox.Controls.Add(minuteBox);
            minuteBox.Location = new Point(0, 0);
            minuteBox.Image = rotateImage(minute, AngleM);
            // Dot
            minuteBox.Controls.Add(dotBox);
            dotBox.Location = new Point(0, 0);
            dotBox.Image = dot;
            // Second
            dotBox.Controls.Add(secondBox);
            secondBox.Location = new Point(0, 0);
            secondBox.Image = rotateImage(second, AngleS);

            // Error catching
            if (listBox1.SelectedItem != null
                && listBox2.SelectedItem != null && label2.Text != "")
            {
                //The alarm that is currently in the "New Alarm Box"
                String HourAlarm = listBox1.SelectedItem.ToString();
                String MinuteAlarm = listBox2.SelectedItem.ToString();

                // Verifying the Time matches ".NOW" down to the second so it only pops up once
                if (HourAlarm == Hour.ToString() && MinuteAlarm == Minute.ToString() && Second == 00)
                {
                    // Message to show alarm going off
                    if (MessageBox.Show("YOUR ALARM IS GOING OFF!! \n\n\t\t Would you like to snooze some more?",
                        "Alarm", 
                        MessageBoxButtons.YesNo) == DialogResult.Yes) // If snooze more, adds 5 minutes
                    {
                        // adds 5 more minutes (THIS WILL NOT TRIGGER NEW ALARM YET, ONLY DISPLAY)
                        label2.Text = Hour + ":" + (Minute + 5);
                        
                    }
                    else
                    {
                        // Clear the alarm
                        label2.Text = "";
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            // Instantiating where the picture will be tied to
            back = new Bitmap(".\\back.png");
            hour = new Bitmap(".\\hour.png");
            minute = new Bitmap(".\\minute.png");
            dot = new Bitmap(".\\dot.png");
            second = new Bitmap(".\\second.png");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private Bitmap rotateImage(Bitmap rotateMe, float angle) // Creating the rotation understanding
        {
            Bitmap rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2);
                g.DrawImage(rotateMe, new Point(0, 0));
            }
            return rotatedImage;
        }
    }
}
