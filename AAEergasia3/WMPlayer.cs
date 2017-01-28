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
            wplayer.settings.autoStart = true;
            wplayer.settings.volume = 100;
        }

        public void playSong(string filepath) {
            if (!File.Exists(filepath)) return;
            wplayer.settings.autoStart = true;
            if (filepath.Contains(".."))
                wplayer.URL = new DirectoryInfo(@filepath).FullName;
            else
                wplayer.URL = filepath;
            wplayer.controls.play();

        }

        public void pauseSong() {
            wplayer.controls.pause();
        }

        public string toggle() {
            if (wplayer.playState == WMPPlayState.wmppsPlaying) {
                wplayer.controls.pause();
                return "\uf132";
            } else if (wplayer.playState == WMPPlayState.wmppsPaused||wplayer.playState==WMPPlayState.wmppsReady) {
                wplayer.controls.play();
                return "\uf130";
            }
            return "\uf132";
        }
    }
}
