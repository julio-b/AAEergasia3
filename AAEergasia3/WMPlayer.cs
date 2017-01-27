using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.IO;

namespace AAEergasia3 {
    class WMPlayer {
        public WindowsMediaPlayer wplayer;
        public WMPlayer() {
            wplayer = new WindowsMediaPlayer();
        }

        public void playSong(string filepath) {
            if (!File.Exists(filepath)) return;
            if (filepath.Contains(".."))
                wplayer.URL = new DirectoryInfo(@filepath).FullName;
            else
                wplayer.URL = filepath;
            wplayer.settings.volume = 90;
            wplayer.controls.play();
        }

        public void pauseSong() {
            wplayer.controls.pause();
        }

        public string toggle() {
            if (wplayer.playState == WMPPlayState.wmppsPlaying) {
                wplayer.controls.pause();
                return "Play";
            } else {
                wplayer.controls.play();
                return "Pause";
            }

        }
    }
}
