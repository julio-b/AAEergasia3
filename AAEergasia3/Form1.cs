using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using WMPLib;

namespace AAEergasia3 {
    public partial class Form1 : Form {
        MusicLib m = new MusicLib();
        WMPplayer w = new WMPplayer();
        int playing = -1;
        public Form1() {
            InitializeComponent();
            
            /*
            m.InsertNewFile("aa.mp3", "AA", "aaaa", 1111, "A#", "dottt", 111111);
            m.InsertNewFile("bbb.bbb", "BBBB", "werbb", 22, "CCC", "c", 2);
            m.InsertNewFile("musicwow22.mp3", "asqwqw N Or", "qwe", 2006, "Thrash Metal", "english", 230);
            m.InsertNewFile("i333weqwe.mp3", "meee", "QWEr", 2006, "Thrash Metal", "english", 0);
            m.InsertNewFile("memem-uouou.mp3", "ououou", "memem", 2016, "Thrash Metal", "english", 0);
            m.InsertNewFile("Mfofo - LSSDD.mp3", "LSSDD", "Mfofoo", 2046, "Thrash Metal", "english");
            m.InsertNewFile("HVTT.mp3", "Tor", "wqe", 20776, "Thrash Metal");
            m.InsertNewFile("Deletethis.mp3", "Tor", "wqe", 20776, "Thrash Metal");
            m.DeleteFile("Deletethis.mp3");
            m.EditFileInfos("HVTT.mp3", "name", "fucccccc");
            m.EditFileInfos("HVTT.mp3", "year", 2030);
            */
            /*
            m.InsertNewFile("..\\..\\test\\Loading Loop.wav", "Loading..", "8bit", 1990, "8bit");
            m.InsertNewFile("..\\..\\test\\Marimba Boy.wav", "Marimba", "18bit", 1990, "8bit");
            m.InsertNewFile("..\\..\\test\\Oniku Loop.wav", "Onikk", "Ninn", 1970, "8bit");
            */
            m.InsertNewFile("../../rickroll.mp3", "Rickroll", "unkown", 1960, "pop");
            songsDataGridView.ColumnCount = 7;
            songsDataGridView.Columns[6].Visible = false;
            songsDataGridView.EnableHeadersVisualStyles = false;
            SQLiteDataReader r = m.GetOrdered();
            for(int i =0; i<songsDataGridView.ColumnCount-1;i++) {
                songsDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
                songsDataGridView.Columns[i].Name = r.GetName(i+1);
            }
            reset_dataGridView();

        }

        private void reset_dataGridView() {
            songsDataGridView.Rows.Clear();
            SQLiteDataReader r = m.GetOrdered();
            while (r.Read()) {
                songsDataGridView.Rows.Add(new object[] { r["name"], r["author"], r["year"], r["genre"], r["language"], r["score"], r["filename"] });
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            //w.playSong("../../rickroll.mp3");
            //label1.Text = w.wplayer.URL;
            //reset_dataGridView();
            /*thelei ftiaksimo...
            if (w.wplayer.playState != WMPPlayState.wmppsPaused && w.wplayer.playState!=WMPPlayState.wmppsPlaying) {
                songsDataGridView_CellMouseDoubleClick(null, null);
            }
            */
            var b = sender as Button;
            b.Text = w.toggle();
        }

        private void songsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {

            int ind = (e == null ? songsDataGridView.SelectedRows[0].Index : e.RowIndex);
            if (ind < 0) return;
            string songFile = songsDataGridView.Rows[ind].Cells[6].Value.ToString();
            label1.Text += playing.ToString();
            if (File.Exists(songFile)) {
                if (playing != -1) {
                    songsDataGridView.Rows[playing].DefaultCellStyle.ForeColor = Color.White;
                    songsDataGridView.Rows[playing].DefaultCellStyle.SelectionForeColor = Color.White;
                }
                playing = ind;
                label1.Text = songFile;
                w.playSong(songFile);
                songsDataGridView.Rows[playing].DefaultCellStyle.ForeColor = Color.Yellow;
                songsDataGridView.Rows[playing].DefaultCellStyle.SelectionForeColor = Color.Yellow;
            } else label1.Text = "File not found";
        }

        /*
        private void playSong(string filepath)
        {
            if (!File.Exists(filepath)) return;
            if (filepath.EndsWith(".wav"))
            {
                SoundPlayer sound = new SoundPlayer(@filepath);
                sound.Load();
                sound.Play();
            }
            else if (filepath.EndsWith(".mp3"))
            {
                WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
                if (filepath.Contains(".."))
                    wplayer.URL = new DirectoryInfo(@filepath).FullName;
                else
                    wplayer.URL = filepath;
                wplayer.settings.volume = 90;
                wplayer.controls.play();
            }
        }
        */
        private void button2_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                foreach (var s in openFileDialog1.FileNames) {
                    m.InsertNewFile(s, s, "--", 0, "--");
                }
            }
            reset_dataGridView();
        }
    }
    class WMPplayer {
        public WindowsMediaPlayer wplayer;
        public WMPplayer() {
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
