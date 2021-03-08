using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class SongChange
    {
        public void OnMusicEnded(object sender, EventArgs e)
        {
            MusicPlayer musicPlayer = new MusicPlayer();
            for (int i = 1; i < 7000; i++)
            {
                musicPlayer.Index = i%7;
                musicPlayer.PlayMusic();
            }
        }
    }
}
