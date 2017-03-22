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
    public partial class Form1 : Form
    {
        SoundPlayerController player = null;
       
        public Form1()
        {
            InitializeComponent();
            player = new SoundPlayerController();
            trackBar1.Value = player.getPlayerVolume();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seconds = 0;
            int minutes = 0;
           
            if (textBox1.Text != "")
            {
                minutes = System.Convert.ToInt32(textBox1.Text);
            }
            if (textBox2.Text != "")
            {
                seconds = System.Convert.ToInt32(textBox2.Text);
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
                if(textBox1.Text != "")
                {
                    int temp = System.Convert.ToInt32(textBox1.Text);
                }
                
            }catch(Exception ex)
            {
                textBox1.Text = "";
                MessageBox.Show("Enter Numbers Only");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(textBox2.Text != "")
                {
                    int temp = System.Convert.ToInt32(textBox2.Text);
                }
                
            }
            catch (Exception ex)
            {
                textBox2.Text = "";
                MessageBox.Show("Enter Numbers Only");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(player != null)
            {
                player.setPlayerVolume(trackBar1.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(player != null)
            {
               
                timeSeconds = 0;
               
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
    }
}
