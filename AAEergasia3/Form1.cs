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
using System.Drawing.Text;

namespace AAEergasia3 {
    public partial class Form1 : Form {
        MusicLib m = new MusicLib();
        WMPlayer w = new WMPlayer();
        PrivateFontCollection modernFont = new PrivateFontCollection();
        int[] rand = null;
        bool repeat = false;
        bool random = false;
        int rind = 0;
        Font spoticon;
        int playing = -1;
        bool edit_mode = false;

        public Form1() {
            InitializeComponent();
            modernFont.AddFontFile("..\\..\\Externals\\spoticon.ttf");
            modernFont.AddFontFile("..\\..\\Externals\\proxima_nova_regular_1.ttf");
            
            playBtn.Font = new Font(modernFont.Families[1], 30);
            spoticon = new Font(modernFont.Families[1], 16);
            nextBtn.Font = spoticon;prevBtn.Font = spoticon;repeatBtn.Font = spoticon;randomBtn.Font = spoticon;volumeBtn.Font = spoticon;
            editModeBtn.Font = spoticon;newSongBtn.Font = spoticon;
            playingSongLabel.Font = new Font(modernFont.Families[0], 11);
            playingAuthorLabel.Font = new Font(modernFont.Families[0], 9);
            
            songsDataGridView.RowsDefaultCellStyle.Font = new Font(modernFont.Families[0], 12);
            songsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(modernFont.Families[0], 10);
            
            refresh_dataGridView();
        }

        private void volumeCh(object sender, EventArgs e) {
            w.wplayer.settings.volume = (sender as TrackBar).Value;
        }

        private void refresh_dataGridView() { //sqlite db --> datagridview
            songsDataGridView.Rows.Clear();
            SQLiteDataReader r = m.GetOrdered();
            while (r.Read()) {
                songsDataGridView.Rows.Add(new object[] { "\uf160", r.StepCount, r["song"], r["artist"], r["year"], r["genre"], r["language"], r["score"], r["filename"]});
                songsDataGridView.Rows[r.StepCount - 1].Cells[0].Style.Font = spoticon;
                songsDataGridView.Rows[r.StepCount - 1].Cells[0].Style.SelectionForeColor = Color.DarkRed;
            }
        }

        private void songsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            int ind = (e == null ? songsDataGridView.SelectedRows[0].Index : e.RowIndex); 
            if (ind < 0) return;
            string songFile = songsDataGridView.Rows[ind].Cells[8].Value.ToString();    ///column # 8 = filename
            if (File.Exists(songFile)) {
                if (playing != -1) {//reset previous song row colors
                    songsDataGridView.Rows[playing].DefaultCellStyle.ForeColor = Color.White;
                    songsDataGridView.Rows[playing].DefaultCellStyle.SelectionForeColor = Color.White;
                    songsDataGridView.Rows[playing].DefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24);
                }
                //play new song
                playing = ind;
                playingSongLabel.Text = songsDataGridView[2, ind].Value.ToString();
                playingAuthorLabel.Text = songsDataGridView[3, ind].Value.ToString();
                w.playSong(songFile);
                songsDataGridView.Rows[playing].DefaultCellStyle.ForeColor = Color.FromArgb(29, 185, 84);
                songsDataGridView.Rows[playing].DefaultCellStyle.SelectionForeColor = Color.FromArgb(29, 185, 84);
                songsDataGridView.Rows[playing].DefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
                playBtn.Text = "\uf130";
                int tt = Int32.Parse(songsDataGridView[7, ind].Value.ToString()) + 1; 
                m.EditFileInfos(songsDataGridView[8, ind].Value.ToString(), "score", tt);
                songsDataGridView[7, ind].Value = tt;
            } else playingSongLabel.Text = "File not found";

        }

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
                btn.ForeColor = Color.FromArgb(160, 160, 160);
            } else { 
                songsDataGridView.CellClick += new DataGridViewCellEventHandler(songsDataGridView_CellClick);
                btn.ForeColor = Color.DarkRed;
            }
            edit_mode = !edit_mode;
            songsDataGridView.Columns[0].Visible = edit_mode; //hide delete_btn column
        }

        private void songsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.ColumnIndex == 0 &&///delete song
                MessageBox.Show("Delete \"" + songsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() + "\" ?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                m.DeleteFile(songsDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString());//delete from sqlite
                songsDataGridView.Rows.Remove(songsDataGridView.Rows[e.RowIndex]);//delete from datagridview
            } else {//edit cell
                songsDataGridView.BeginEdit(true);
            }
        }

        private void songsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (songsDataGridView[e.ColumnIndex, e.RowIndex].Value==null||songsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() == "") { songsDataGridView.CancelEdit(); return; }
            m.EditFileInfos(songsDataGridView[8,e.RowIndex].Value.ToString(), songsDataGridView.Columns[e.ColumnIndex].HeaderText, songsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private void songsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0) return;
            songsDataGridView.Rows[e.RowIndex].Selected = true;
        }

        private void playBtn_Click(object sender, EventArgs e) {
            if (playing == -1) { songsDataGridView_CellMouseDoubleClick(null, null); return; }
            (sender as Button).Text = w.toggle();
        }
        private void controls_MouseEnter(object sender, EventArgs e) {
            var b = sender as Button;
            if((b==repeatBtn && repeat)||(b==randomBtn&&random )|| (b == editModeBtn && edit_mode) || (b == volumeBtn && w.wplayer.settings.mute)) { return; }
            b.ForeColor = Color.White;
        }

        private void controls_MouseLeave(object sender, EventArgs e) {
            var b = sender as Button;
            if ((b == repeatBtn && repeat)||(b==randomBtn&&random)||(b==editModeBtn&&edit_mode)||(b==volumeBtn&&w.wplayer.settings.mute)) { return; }
            b.ForeColor = Color.FromArgb(160, 160, 160);
        }

        private void volumeBtn_Click(object sender, EventArgs e) {
            w.wplayer.settings.mute = !w.wplayer.settings.mute;
            (sender as Button).Text = w.wplayer.settings.mute ? "" : "";
            (sender as Button).ForeColor = w.wplayer.settings.mute ? Color.DarkRed : Color.White;
        }

        private void prevBtn_Click(object sender, EventArgs e) {
            int prev=0;
            if (random) {
                rind = rind <= 0 ? songsDataGridView.RowCount-1 : rind - 1;
            } else {
                prev = playing <= 0 ? songsDataGridView.RowCount-1 : playing - 1;
            }
            songsDataGridView.Rows[repeat&&sender==null? playing : random ? rand[rind] : prev].Selected = true;
            songsDataGridView_CellMouseDoubleClick(null, null);
        }

        private void nextBtn_Click(object sender, EventArgs e) {
            int next=0;
            if (random) {
                rind = rind >= songsDataGridView.RowCount - 1 ? 0 : rind + 1;
            } else {
                next = playing >= songsDataGridView.Rows.Count - 1 ? 0 : playing + 1;
            }
            songsDataGridView.Rows[repeat&&sender==null? playing : random ? rand[rind] : next].Selected = true;
            songsDataGridView_CellMouseDoubleClick(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            var ee = w.wplayer.playState;
            if (ee ==WMPPlayState.wmppsStopped) { nextBtn_Click(null, null); }
            if (ee == WMPPlayState.wmppsReady) { w.wplayer.controls.play(); }
            if (ee == WMPPlayState.wmppsPlaying||ee==WMPPlayState.wmppsPaused) {
                label2.Text = w.wplayer.controls.currentItem.durationString;
                label1.Text = w.wplayer.controls.currentPositionString;
                int v = (int)(songtb.Maximum * (w.wplayer.controls.currentPosition / w.wplayer.controls.currentItem.duration));
                songtb.Value = v > songtb.Maximum ? songtb.Maximum : v;
            } else {
                label2.Text = "00:00";
                label1.Text = "00:00";
                songtb.Value = 0;
            }
        }

        private void repeatBtn_Click(object sender, EventArgs e) {
            repeat = !repeat;
            (sender as Button).ForeColor = repeat ? Color.FromArgb(29, 185, 84) : Color.FromArgb(160, 160, 160);
        }

        private void randomBtn_Click(object sender, EventArgs e) {
            random = !random;
            (sender as Button).ForeColor = random ? Color.FromArgb(29, 185, 84) : Color.FromArgb(160, 160, 160);
            Random r = new Random();
            rand = new int[songsDataGridView.RowCount];
            rind = 0;
            for (int i = 0; i < songsDataGridView.RowCount; i++) rand[i] = i;
            for(int i=0; i < songsDataGridView.RowCount; i++) {
                int j = r.Next(i, songsDataGridView.RowCount);
                int tmp = rand[j];
                rand[j] = rand[i];
                rand[i] = tmp;
            }
            if (playing != -1) {
                int c = Array.IndexOf(rand, playing);
                rand[c] = rand[0];
                rand[0] = playing;
            }
        }

        private void songtb_Scroll(object sender, EventArgs e) {
            if(w.wplayer.controls.currentItem != null)
                w.wplayer.controls.currentPosition= (sender as TrackBar).Value*(( w.wplayer.controls.currentItem.duration/1000));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            m.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Created by:\n";
            about += "\tΓιώργος\n";
            about += "\tΘεοφάνης\n";
            about += "\tΤζούλιο\n";
            MessageBox.Show(about, "About");
        }
    }

}
