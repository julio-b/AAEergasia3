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
        int[] random = null;
        bool repeat = false;
        Font spoticon;
        int playing = -1;
        bool edit_mode = false;
        public Form1() {
            InitializeComponent();
            modernFont.AddFontFile("..\\..\\Externals\\spoticon.ttf");
            modernFont.AddFontFile("..\\..\\Externals\\proxima_nova_regular_1.ttf");
            
            playBtn.Font = new Font(modernFont.Families[1], 29);
            spoticon = new Font(modernFont.Families[1], 16);
            nextBtn.Font = spoticon;prevBtn.Font = spoticon;repeatBtn.Font = spoticon;randomBtn.Font = spoticon;volumeBtn.Font = spoticon;/////         
            editModeBtn.Font = spoticon;newSongBtn.Font = spoticon;

            songsDataGridView.RowsDefaultCellStyle.Font = new Font(modernFont.Families[0], 13);
            songsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(modernFont.Families[0], 12);
            songsDataGridView.EnableHeadersVisualStyles = false;
            songsDataGridView.ColumnCount = 9;
            string[] tmp = { "#", "", "Name", "Author", "Year", "Genre", "Language", "Score", "filename"};
            for(int i = 0; i<tmp.Length; i++) {
                songsDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
                songsDataGridView.Columns[i].Name = tmp[i].ToString();
            }
            
            songsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            songsDataGridView.Columns[0].Width = 55;
            songsDataGridView.Columns[0].ReadOnly = true;
            songsDataGridView.Columns[1].DefaultCellStyle.Font = new Font(modernFont.Families[1], 18);
            songsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            songsDataGridView.Columns[1].Width = 40;
            songsDataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            songsDataGridView.Columns[1].Visible = false;
            songsDataGridView.Columns[1].ReadOnly = true;
            songsDataGridView.Columns[2].FillWeight = 180;
            songsDataGridView.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            songsDataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            songsDataGridView.Columns[7].Width = 60;
            songsDataGridView.Columns[7].ReadOnly = true;
            songsDataGridView.Columns[8].Visible = false;//hide filename column

            refresh_dataGridView();


        }


        private void refresh_dataGridView() { //sqlite db --> datagridview
            songsDataGridView.Rows.Clear();
            SQLiteDataReader r = m.GetOrdered();
            while (r.Read()) {
                songsDataGridView.Rows.Add(new object[] { r.StepCount, "\uf160", r["name"], r["author"], r["year"], r["genre"], r["language"], r["score"], r["filename"]});
                songsDataGridView.Rows[r.StepCount - 1].Cells[1].Style.Font = spoticon;
                songsDataGridView.Rows[r.StepCount - 1].Cells[1].Style.SelectionForeColor = Color.DarkRed;
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
                label1.Text = songFile;
                w.playSong(songFile);
                songsDataGridView.Rows[playing].DefaultCellStyle.ForeColor = Color.FromArgb(29, 185, 84);
                songsDataGridView.Rows[playing].DefaultCellStyle.SelectionForeColor = Color.FromArgb(29, 185, 84);
                songsDataGridView.Rows[playing].DefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
                playBtn.Text = "\uf130";
            } else label1.Text = "File not found";

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
            songsDataGridView.Columns[1].Visible = edit_mode; //hide delete_btn column
        }

        private void songsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.ColumnIndex == 1 &&///delete song
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
            if (songsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() == "") { songsDataGridView.CancelEdit(); return; }
            m.EditFileInfos(songsDataGridView[8,e.RowIndex].Value.ToString(), songsDataGridView.Columns[e.ColumnIndex].Name, songsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
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
            (sender as Button).ForeColor = Color.White;
        }

        private void controls_MouseLeave(object sender, EventArgs e) {
            (sender as Button).ForeColor = Color.FromArgb(160, 160, 160);
        }

        private void volumeBtn_Click(object sender, EventArgs e) {

        }

        private void prevBtn_Click(object sender, EventArgs e) {
            int prev = playing <= 0 ? songsDataGridView.Rows.Count - 1 : playing - 1;
            songsDataGridView.Rows[prev].Selected = true;
            songsDataGridView_CellMouseDoubleClick(null, null);
        }

        private void nextBtn_Click(object sender, EventArgs e) {
            int next = playing >= songsDataGridView.Rows.Count-1 ? 0 : playing+1;
            songsDataGridView.Rows[next].Selected = true;
            songsDataGridView_CellMouseDoubleClick(null, null);
        }

        private void button1_Click(object sender, EventArgs e) {
            label1.Text = w.wplayer.playState.ToString();
        }
    }

}
