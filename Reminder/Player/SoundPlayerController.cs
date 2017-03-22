using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Player
{
    class SoundPlayerController
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        System.Timers.Timer timer;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Reminder.Properties.Resources.Air_Horn_SoundBible_com_964603082);
        public SoundPlayerController(int minutes,int seconds)
        {
            double milisecods = (minutes * 60* 1000) + seconds* 1000;
            timer = new System.Timers.Timer(milisecods);
            timer.AutoReset = true;
            timer.Elapsed += PlaySound;
            
        
        }
        private void PlaySound(Object source, System.Timers.ElapsedEventArgs e)
        {
            player.PlayLooping();
        }
        public void stopTimer()
        {
            player.Stop();
            timer.Stop();
            
            
        }
        public void stopAlram()
        {
            player.Stop();
        }
        public void startTimer()
        {
            timer.Start();
        }
        public void startTimer(int minutes,int seconds)
        {
            double milisecods = (minutes * 60 * 1000) + seconds * 1000;
            timer.Interval = milisecods;
            timer.Start();
        }
        public void setPlayerVolume(int value)
        {
            // Calculate the volume that's being set. BTW: this is a trackbar!
            int NewVolume = ((ushort.MaxValue / 10) * value);
            // Set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }
        public int getPlayerVolume()
        {
            uint CurrVol = 0;
            // At this point, CurrVol gets assigned the volume
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            // Calculate the volume
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10 (to fit the trackbar)
            return CalcVol / (ushort.MaxValue / 10);
        }

    }
}
