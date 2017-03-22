using Reminder.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder
{
    public partial class MainWindow : Form
    {
        SoundPlayerController player = null;
       
        public MainWindow()
        {
            InitializeComponent();
            player = new SoundPlayerController();
            VolumeController.Value = player.getPlayerVolume();
            mynotifyicon.BalloonTipText = "Reminder still working...";
            mynotifyicon.BalloonTipTitle = "Reminder";
            mynotifyicon.Text = "Reminder";
            mynotifyicon.BalloonTipIcon = ToolTipIcon.Info;
            mynotifyicon.DoubleClick += Mynotifyicon_DoubleClick; ;
            mynotifyicon.Icon = Reminder.Properties.Resources.favicon;

        }

        private void Mynotifyicon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int seconds = 0;
            int minutes = 0;
           
            if (minutesText.Text != "")
            {
                minutes = System.Convert.ToInt32(minutesText.Text);
            }
            if (secondsText.Text != "")
            {
                seconds = System.Convert.ToInt32(secondsText.Text);
            }
            if(seconds != 0 && minutes != 0)
            {
                player.setTimeIntervale(minutes, seconds);
                player.startTimer();
               
            }
            
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(minutesText.Text != "")
                {
                    int temp = System.Convert.ToInt32(minutesText.Text);
                }
                
            }catch(Exception ex)
            {
                minutesText.Text = "";
                MessageBox.Show("Enter Numbers Only");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(secondsText.Text != "")
                {
                    int temp = System.Convert.ToInt32(secondsText.Text);
                }
                
            }
            catch (Exception ex)
            {
                secondsText.Text = "";
                MessageBox.Show("Enter Numbers Only");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(player != null)
            {
                player.setPlayerVolume(VolumeController.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(player != null)
            {
                player.stopTimer();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.stopAlram();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                mynotifyicon.Visible = true;
                mynotifyicon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                mynotifyicon.Visible = false;
            }
        }
    }
}
