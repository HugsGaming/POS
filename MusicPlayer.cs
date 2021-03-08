using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alvas.Audio;
using System.Threading;
using System.Media;
using System.IO;

namespace POS
{
    class MusicPlayer
    {
        private int index = 0;

        public int Index 
        { 
            get
            {
                return index;
            }
            set
            {
                this.index = value;
            }
        }

        public delegate void MusicEndedEventHandler(object sender, EventArgs e);

        public event MusicEndedEventHandler MusicEnded;

        public void PlayMusic()
        {
            string[] songs = new string[7];
            songs[0] = "National Anthem of the soviet union - Red Army Choir.wav";
            songs[1] = "Katyusha_Катюша with Lyrics.wav";
            songs[2] = "'Kalinka'.wav";
            songs[3] = "Red Army Choir - Korobeiniki.wav";
            songs[4] = "Boney M. - Rasputin.wav";
            songs[5] = "Tetris Theme (Piano Version) - 400k Special.wav";
            songs[6] = "Dschinghis Khan - Moskau 1979.wav";

            SoundPlayer player = new SoundPlayer();
            WaveReader reader = new WaveReader(File.OpenRead(songs[index]));

            player.SoundLocation = songs[index];
            player.Play();
            Thread.Sleep(reader.GetDurationInMS());

            OnMusicEnded();
        }

        protected virtual void OnMusicEnded()
        {
            if(MusicEnded != null)
            {
                MusicEnded(this, EventArgs.Empty);
            }
        }
    }
}
