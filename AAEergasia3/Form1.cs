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
        bool edit_mode = false;
        public Form1() {
            InitializeComponent();
            
            /*
            m.InsertNewFile("aa.mp3", "AA", "aaaa", 1111, "A#", "dottt", 111111);
            m.InsertNewFile("bbb.bbb", "BBBB", "werbb", 22, "CCC", "c", 2);
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
            refresh_dataGridView();

        }

        private void refresh_dataGridView() {
            songsDataGridView.Rows.Clear();
            SQLiteDataReader r = m.GetOrdered();
            while (r.Read()) {
                songsDataGridView.Rows.Add(new object[] { r["name"], r["author"], r["year"], r["genre"], r["language"], r["score"], r["filename"] });
            }
        }

        private void playBtn_Click(object sender, EventArgs e) {
            if (w.wplayer.playState != WMPPlayState.wmppsPaused && w.wplayer.playState!=WMPPlayState.wmppsPlaying) {
                songsDataGridView_CellMouseDoubleClick(null, null);
            }
            var b = sender as Button;
            b.Text = w.toggle();
        }

        private void songsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            int ind = (e == null ? songsDataGridView.SelectedRows[0].Index : e.RowIndex);
            if (ind < 0) return;
            string songFile = songsDataGridView.Rows[ind].Cells[6].Value.ToString();
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
        private void newSongBtn_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                foreach (var s in openFileDialog1.FileNames) {
                    m.InsertNewFile(s,new DirectoryInfo(s).Name, "--", 0, "--");
                }
            }
            refresh_dataGridView();
        }

        private void editModeBtn_Click(object sender, EventArgs e) {
            var btn = sender as Button;
            if (edit_mode) { 
                songsDataGridView.CellClick -= songsDataGridView_CellClick;
                btn.Font = Button.DefaultFont;
                btn.ForeColor = Button.DefaultForeColor;
            } else { 
                songsDataGridView.CellClick += new DataGridViewCellEventHandler(songsDataGridView_CellClick);
                btn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                btn.ForeColor = Color.DarkRed;
            }
            edit_mode = !edit_mode;
        }

        private void songsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            songsDataGridView.BeginEdit(true);
        }

        private void songsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            m.EditFileInfos(songsDataGridView[6,e.RowIndex].Value.ToString(), songsDataGridView.Columns[e.ColumnIndex].Name, songsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private void deleteSongBtn_Click(object sender, EventArgs e) {
            if (songsDataGridView.SelectedRows.Count > 0 && 
                MessageBox.Show("Delete \""+ songsDataGridView.SelectedRows[0].Cells[0].Value.ToString()+ "\" ?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes) {
                m.DeleteFile(songsDataGridView.SelectedRows[0].Cells[6].Value.ToString());//delete from sqlite
                songsDataGridView.Rows.Remove(songsDataGridView.SelectedRows[0]);//delete from datagridview
            }
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
