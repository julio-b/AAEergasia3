namespace AAEergasia3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.songsDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.volumeBtn = new System.Windows.Forms.Button();
            this.repeatBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.editModeBtn = new System.Windows.Forms.Button();
            this.newSongBtn = new System.Windows.Forms.Button();
            this.playingSongLabel = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playingAuthorLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.songsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // songsDataGridView
            // 
            this.songsDataGridView.AllowUserToAddRows = false;
            this.songsDataGridView.AllowUserToDeleteRows = false;
            this.songsDataGridView.AllowUserToResizeColumns = false;
            this.songsDataGridView.AllowUserToResizeRows = false;
            this.songsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.songsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.songsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.songsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.songsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.songsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.songsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.songsDataGridView.Location = new System.Drawing.Point(15, 15);
            this.songsDataGridView.MultiSelect = false;
            this.songsDataGridView.Name = "songsDataGridView";
            this.songsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.songsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.songsDataGridView.RowTemplate.Height = 40;
            this.songsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.songsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.songsDataGridView.Size = new System.Drawing.Size(746, 427);
            this.songsDataGridView.TabIndex = 6;
            this.songsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.songsDataGridView_CellEndEdit);
            this.songsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.songsDataGridView_CellMouseDoubleClick);
            this.songsDataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.songsDataGridView_CellMouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 61);
            this.panel1.TabIndex = 8;
            // 
            // volumeBtn
            // 
            this.volumeBtn.FlatAppearance.BorderSize = 0;
            this.volumeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.volumeBtn.Location = new System.Drawing.Point(400, 12);
            this.volumeBtn.Name = "volumeBtn";
            this.volumeBtn.Size = new System.Drawing.Size(60, 35);
            this.volumeBtn.TabIndex = 9;
            this.volumeBtn.Text = "";
            this.volumeBtn.UseVisualStyleBackColor = true;
            this.volumeBtn.Click += new System.EventHandler(this.volumeBtn_Click);
            // 
            // repeatBtn
            // 
            this.repeatBtn.FlatAppearance.BorderSize = 0;
            this.repeatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeatBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.repeatBtn.Location = new System.Drawing.Point(5, 12);
            this.repeatBtn.Name = "repeatBtn";
            this.repeatBtn.Size = new System.Drawing.Size(60, 35);
            this.repeatBtn.TabIndex = 8;
            this.repeatBtn.Text = "";
            this.repeatBtn.UseVisualStyleBackColor = true;
            this.repeatBtn.Click += new System.EventHandler(this.repeatBtn_Click);
            this.repeatBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.repeatBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // randomBtn
            // 
            this.randomBtn.FlatAppearance.BorderSize = 0;
            this.randomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.randomBtn.Location = new System.Drawing.Point(71, 12);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(60, 35);
            this.randomBtn.TabIndex = 7;
            this.randomBtn.Text = "";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            this.randomBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.randomBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // prevBtn
            // 
            this.prevBtn.FlatAppearance.BorderSize = 0;
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.prevBtn.Location = new System.Drawing.Point(164, 12);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(60, 35);
            this.prevBtn.TabIndex = 6;
            this.prevBtn.Text = "";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            this.prevBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.prevBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // nextBtn
            // 
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nextBtn.Location = new System.Drawing.Point(307, 12);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(60, 35);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            this.nextBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.nextBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // editModeBtn
            // 
            this.editModeBtn.FlatAppearance.BorderSize = 0;
            this.editModeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editModeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.editModeBtn.Location = new System.Drawing.Point(0, 0);
            this.editModeBtn.Name = "editModeBtn";
            this.editModeBtn.Size = new System.Drawing.Size(70, 40);
            this.editModeBtn.TabIndex = 4;
            this.editModeBtn.Text = "";
            this.editModeBtn.UseVisualStyleBackColor = true;
            this.editModeBtn.Click += new System.EventHandler(this.editModeBtn_Click);
            // 
            // newSongBtn
            // 
            this.newSongBtn.FlatAppearance.BorderSize = 0;
            this.newSongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newSongBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.newSongBtn.Location = new System.Drawing.Point(76, 0);
            this.newSongBtn.Name = "newSongBtn";
            this.newSongBtn.Size = new System.Drawing.Size(70, 40);
            this.newSongBtn.TabIndex = 2;
            this.newSongBtn.Text = "";
            this.newSongBtn.UseVisualStyleBackColor = true;
            this.newSongBtn.Click += new System.EventHandler(this.newSongBtn_Click);
            // 
            // playingSongLabel
            // 
            this.playingSongLabel.ForeColor = System.Drawing.Color.White;
            this.playingSongLabel.Location = new System.Drawing.Point(3, 11);
            this.playingSongLabel.MaximumSize = new System.Drawing.Size(150, 17);
            this.playingSongLabel.Name = "playingSongLabel";
            this.playingSongLabel.Size = new System.Drawing.Size(150, 17);
            this.playingSongLabel.TabIndex = 1;
            this.playingSongLabel.Text = "       ";
            // 
            // playBtn
            // 
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.playBtn.Location = new System.Drawing.Point(230, 2);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(71, 55);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            this.playBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.playBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.songsDataGridView);
            this.panel2.Location = new System.Drawing.Point(24, 44);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(776, 457);
            this.panel2.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playingAuthorLabel
            // 
            this.playingAuthorLabel.AutoEllipsis = true;
            this.playingAuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.playingAuthorLabel.Location = new System.Drawing.Point(3, 33);
            this.playingAuthorLabel.MaximumSize = new System.Drawing.Size(150, 17);
            this.playingAuthorLabel.Name = "playingAuthorLabel";
            this.playingAuthorLabel.Size = new System.Drawing.Size(150, 17);
            this.playingAuthorLabel.TabIndex = 10;
            this.playingAuthorLabel.Text = "       ";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.playBtn);
            this.panel3.Controls.Add(this.volumeBtn);
            this.panel3.Controls.Add(this.nextBtn);
            this.panel3.Controls.Add(this.repeatBtn);
            this.panel3.Controls.Add(this.prevBtn);
            this.panel3.Controls.Add(this.randomBtn);
            this.panel3.Location = new System.Drawing.Point(168, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 61);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.editModeBtn);
            this.panel4.Controls.Add(this.newSongBtn);
            this.panel4.Location = new System.Drawing.Point(671, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 40);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.playingSongLabel);
            this.panel5.Controls.Add(this.playingAuthorLabel);
            this.panel5.Location = new System.Drawing.Point(12, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 61);
            this.panel5.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(826, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(842, 624);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.songsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView songsDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label playingSongLabel;
        private System.Windows.Forms.Button newSongBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button editModeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button repeatBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button volumeBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label playingAuthorLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

