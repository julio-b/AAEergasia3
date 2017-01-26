using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace AAEergasia3
{
    class Song
    {
        private string type;
        private object player;
        public Song() { }

        public Song(string filepath)
        {
            LoadSong(filepath);
        }
        public void LoadSong(string filepath)
        {
            if (!File.Exists(filepath)) return;
            if (filepath.EndsWith(".wav"))
            {
                if (type != "WAV")
                {
                    if (type == "MP3")
                    {
                        (player as WindowsMediaPlayer).controls.stop();
                        (player as WindowsMediaPlayer).close();
                    }
                    type = "WAV";
                    player = new SoundPlayer(@filepath);
                }
                else
                {
                    (player as SoundPlayer).SoundLocation = @filepath;
                }
            }
            else if (filepath.EndsWith(".mp3"))
            {
                if (type != "MP3")
                {
                    if (type == "WAV")
                    {
                        (player as SoundPlayer).Stop();
                        (player as SoundPlayer).Dispose();
                    }
                    type = "MP3";
                    player = new WindowsMediaPlayer();
                    (player as WindowsMediaPlayer).settings.volume = 90;
                }
                if (filepath.Contains(".."))
                    (player as WindowsMediaPlayer).URL = new DirectoryInfo(@filepath).FullName;
                else
                    (player as WindowsMediaPlayer).URL = filepath;

            }

        }

        public void Stop()
        {
            switch (type)
            {
                case "WAV":
                    (player as SoundPlayer).Stop();
                    break;
                case "MP3":
                    (player as WindowsMediaPlayer).controls.stop();
                    break;
            }
        }

        public void Play()
        {
            switch (type)
            {
                case "WAV":
                    (player as SoundPlayer).Load();
                    (player as SoundPlayer).Play();
                    break;
                case "MP3":
                    (player as WindowsMediaPlayer).controls.play();
                    break;
            }
        }
    }
}
