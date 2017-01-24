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

namespace AAEergasia3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            MusicLib m = new MusicLib();
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
            SQLiteDataReader r = m.GetOrdered();
            songsDataGridView.ColumnCount = 7;
            songsDataGridView.Columns[6].Visible = false;
            songsDataGridView.EnableHeadersVisualStyles = false;
            for(int i =0; i<songsDataGridView.ColumnCount-1;i++) {
                songsDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
                songsDataGridView.Columns[i].Name = r.GetName(i+1);
            }
            while (r.Read()) {
                songsDataGridView.Rows.Add(new object[] { r["name"], r["author"], r["year"], r["genre"], r["language"], r["score"], r["filename"] });
            }

        }

        private void button1_Click(object sender, EventArgs e) {
            /*
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = "..\\..\\SupeMario.mp3";
            wplayer.settings.volume = 90;
            wplayer.controls.play();
            */
            /*
            System.Media.SoundPlayer mario = new System.Media.SoundPlayer(@"Super_Mario_Bros.wav");
            mario.Play();
            */

        }

        private void songsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            var songFile = songsDataGridView.Rows[e.RowIndex].Cells[6].Value;
            if (File.Exists(songFile.ToString())) {
                label1.Text = songFile.ToString();
                System.Media.SoundPlayer test = new System.Media.SoundPlayer(songFile.ToString());
                test.Play();
            } else label1.Text = "File not found";
        }
    }
}
