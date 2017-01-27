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
        WMPlayer w = new WMPlayer();
        int playing = -1;
        bool edit_mode = false;
        public Form1() {
            InitializeComponent();
            songsDataGridView.ColumnCount = 8;
            songsDataGridView.EnableHeadersVisualStyles = false;
            string[] tmp = { "#", "Name", "Author", "Year", "Genre", "Language", "Score", "filename" };
            for(int i = 0; i<tmp.Length; i++) {
                songsDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
                songsDataGridView.Columns[i].Name = tmp[i].ToString();
            }
            songsDataGridView.Columns[7].Visible = false;//hide filename column
            refresh_dataGridView();
            DataGridViewImageColumn cc = new DataGridViewImageColumn();                     //Delete-btn column
            cc.Image = Properties.Resources.delete;                                         //
            cc.ImageLayout = DataGridViewImageCellLayout.Zoom;
            cc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cc.Width = 20;
            cc.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cc.Visible = false;
            songsDataGridView.Columns.Insert(8, cc);                                        /////
            
            songsDataGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;//<--fix, dn douleuei
            songsDataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            songsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            songsDataGridView.Columns[0].Width = 40;
            songsDataGridView.Columns[0].ReadOnly = true;
            songsDataGridView.Columns[1].FillWeight = 180;
            songsDataGridView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            songsDataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            songsDataGridView.Columns[6].Width = 60;
            songsDataGridView.Columns[6].ReadOnly = true;
        }

        private void refresh_dataGridView() { //sqlite db --> datagridview
            songsDataGridView.Rows.Clear();
            SQLiteDataReader r = m.GetOrdered();
            while (r.Read()) {
                songsDataGridView.Rows.Add(new object[] { r.StepCount, r["name"], r["author"], r["year"], r["genre"], r["language"], r["score"], r["filename"] });
            }
        }

        //Dn douleuei swsta!! 
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
            string songFile = songsDataGridView.Rows[ind].Cells[7].Value.ToString();    ///column # 7 = filename
            if (File.Exists(songFile)) {
                if (playing != -1) {//reset previous row colors
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
            songsDataGridView.Columns[8].Visible = edit_mode; //hide delete_btn column
        }

        private void songsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.ColumnIndex == 8 &&///delete song
                MessageBox.Show("Delete \"" + songsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() + "\" ?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                m.DeleteFile(songsDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());//delete from sqlite
                songsDataGridView.Rows.Remove(songsDataGridView.Rows[e.RowIndex]);//delete from datagridview
            } else {//edit cell
                songsDataGridView.BeginEdit(true);
            }
        }

        private void songsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (songsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() == "") { songsDataGridView.CancelEdit(); return; }
            m.EditFileInfos(songsDataGridView[7,e.RowIndex].Value.ToString(), songsDataGridView.Columns[e.ColumnIndex].Name, songsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

    }
 
}
