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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.songsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.playingSongLabel = new System.Windows.Forms.Label();
            this.playingAuthorLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.volumeBtn = new System.Windows.Forms.Button();
            this.volumetb = new System.Windows.Forms.TrackBar();
            this.editModeBtn = new System.Windows.Forms.Button();
            this.newSongBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.songtb = new System.Windows.Forms.TrackBar();
            this.playBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.repeatBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.songsDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumetb)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songtb)).BeginInit();
            this.panel2.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.songsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.songsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.songsDataGridView.EnableHeadersVisualStyles = false;
            this.songsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.songsDataGridView.Location = new System.Drawing.Point(15, 15);
            this.songsDataGridView.MultiSelect = false;
            this.songsDataGridView.Name = "songsDataGridView";
            this.songsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.songsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.songsDataGridView.RowTemplate.Height = 40;
            this.songsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.songsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.songsDataGridView.Size = new System.Drawing.Size(869, 411);
            this.songsDataGridView.TabIndex = 6;
            this.songsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.songsDataGridView_CellEndEdit);
            this.songsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.songsDataGridView_CellMouseDoubleClick);
            this.songsDataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.songsDataGridView_CellMouseMove);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column2.Visible = false;
            this.Column2.Width = 40;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 55;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 180F;
            this.Column3.HeaderText = "SONG";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ARTIST";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "YEAR";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "GENRE";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "LANGUAGE";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column8.HeaderText = "SCORE";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "filename";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.testToolStripMenuItem.Text = "Add song";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.newSongBtn_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 79);
            this.panel1.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.playingSongLabel);
            this.panel5.Controls.Add(this.playingAuthorLabel);
            this.panel5.Location = new System.Drawing.Point(12, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 60);
            this.panel5.TabIndex = 7;
            // 
            // playingSongLabel
            // 
            this.playingSongLabel.ForeColor = System.Drawing.Color.White;
            this.playingSongLabel.Location = new System.Drawing.Point(3, 15);
            this.playingSongLabel.MaximumSize = new System.Drawing.Size(200, 17);
            this.playingSongLabel.Name = "playingSongLabel";
            this.playingSongLabel.Size = new System.Drawing.Size(200, 17);
            this.playingSongLabel.TabIndex = 1;
            this.playingSongLabel.Text = "       ";
            // 
            // playingAuthorLabel
            // 
            this.playingAuthorLabel.AutoEllipsis = true;
            this.playingAuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.playingAuthorLabel.Location = new System.Drawing.Point(3, 39);
            this.playingAuthorLabel.MaximumSize = new System.Drawing.Size(150, 17);
            this.playingAuthorLabel.Name = "playingAuthorLabel";
            this.playingAuthorLabel.Size = new System.Drawing.Size(150, 17);
            this.playingAuthorLabel.TabIndex = 10;
            this.playingAuthorLabel.Text = "       ";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.volumeBtn);
            this.panel4.Controls.Add(this.volumetb);
            this.panel4.Controls.Add(this.editModeBtn);
            this.panel4.Controls.Add(this.newSongBtn);
            this.panel4.Location = new System.Drawing.Point(792, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 73);
            this.panel4.TabIndex = 7;
            // 
            // volumeBtn
            // 
            this.volumeBtn.FlatAppearance.BorderSize = 0;
            this.volumeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.volumeBtn.Location = new System.Drawing.Point(4, 5);
            this.volumeBtn.Name = "volumeBtn";
            this.volumeBtn.Size = new System.Drawing.Size(30, 30);
            this.volumeBtn.TabIndex = 9;
            this.volumeBtn.Text = "";
            this.toolTip1.SetToolTip(this.volumeBtn, "Mute");
            this.volumeBtn.UseVisualStyleBackColor = true;
            this.volumeBtn.Click += new System.EventHandler(this.volumeBtn_Click);
            this.volumeBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.volumeBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // volumetb
            // 
            this.volumetb.AutoSize = false;
            this.volumetb.Location = new System.Drawing.Point(33, 8);
            this.volumetb.Maximum = 100;
            this.volumetb.Name = "volumetb";
            this.volumetb.Size = new System.Drawing.Size(124, 21);
            this.volumetb.TabIndex = 10;
            this.volumetb.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumetb.Value = 100;
            this.volumetb.ValueChanged += new System.EventHandler(this.volumeCh);
            // 
            // editModeBtn
            // 
            this.editModeBtn.FlatAppearance.BorderSize = 0;
            this.editModeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editModeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.editModeBtn.Location = new System.Drawing.Point(116, 37);
            this.editModeBtn.Name = "editModeBtn";
            this.editModeBtn.Size = new System.Drawing.Size(30, 30);
            this.editModeBtn.TabIndex = 4;
            this.editModeBtn.Text = "";
            this.toolTip1.SetToolTip(this.editModeBtn, "Edit playlist\'s songs.");
            this.editModeBtn.UseVisualStyleBackColor = true;
            this.editModeBtn.Click += new System.EventHandler(this.editModeBtn_Click);
            this.editModeBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.editModeBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // newSongBtn
            // 
            this.newSongBtn.FlatAppearance.BorderSize = 0;
            this.newSongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newSongBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.newSongBtn.Location = new System.Drawing.Point(80, 37);
            this.newSongBtn.Name = "newSongBtn";
            this.newSongBtn.Size = new System.Drawing.Size(30, 30);
            this.newSongBtn.TabIndex = 2;
            this.newSongBtn.Text = "";
            this.toolTip1.SetToolTip(this.newSongBtn, "Add new song to playlist.");
            this.newSongBtn.UseVisualStyleBackColor = true;
            this.newSongBtn.Click += new System.EventHandler(this.newSongBtn_Click);
            this.newSongBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.newSongBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.songtb);
            this.panel3.Controls.Add(this.playBtn);
            this.panel3.Controls.Add(this.nextBtn);
            this.panel3.Controls.Add(this.repeatBtn);
            this.panel3.Controls.Add(this.prevBtn);
            this.panel3.Controls.Add(this.randomBtn);
            this.panel3.Location = new System.Drawing.Point(224, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 76);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(-3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "0:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(457, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "9:59:59";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // songtb
            // 
            this.songtb.AutoSize = false;
            this.songtb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songtb.Location = new System.Drawing.Point(33, 58);
            this.songtb.Maximum = 1000;
            this.songtb.Name = "songtb";
            this.songtb.Size = new System.Drawing.Size(431, 21);
            this.songtb.TabIndex = 7;
            this.songtb.TickStyle = System.Windows.Forms.TickStyle.None;
            this.songtb.Scroll += new System.EventHandler(this.songtb_Scroll);
            // 
            // playBtn
            // 
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.playBtn.Location = new System.Drawing.Point(215, 5);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(71, 50);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "";
            this.toolTip1.SetToolTip(this.playBtn, "Play");
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            this.playBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.playBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // nextBtn
            // 
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nextBtn.Location = new System.Drawing.Point(292, 15);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(60, 35);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "";
            this.toolTip1.SetToolTip(this.nextBtn, "Next");
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            this.nextBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.nextBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // repeatBtn
            // 
            this.repeatBtn.FlatAppearance.BorderSize = 0;
            this.repeatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeatBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.repeatBtn.Location = new System.Drawing.Point(358, 15);
            this.repeatBtn.Name = "repeatBtn";
            this.repeatBtn.Size = new System.Drawing.Size(60, 35);
            this.repeatBtn.TabIndex = 8;
            this.repeatBtn.Text = "";
            this.toolTip1.SetToolTip(this.repeatBtn, "Repeat");
            this.repeatBtn.UseVisualStyleBackColor = true;
            this.repeatBtn.Click += new System.EventHandler(this.repeatBtn_Click);
            this.repeatBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.repeatBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // prevBtn
            // 
            this.prevBtn.FlatAppearance.BorderSize = 0;
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.prevBtn.Location = new System.Drawing.Point(149, 15);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(60, 35);
            this.prevBtn.TabIndex = 6;
            this.prevBtn.Text = "";
            this.toolTip1.SetToolTip(this.prevBtn, "Previous");
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            this.prevBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.prevBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // randomBtn
            // 
            this.randomBtn.FlatAppearance.BorderSize = 0;
            this.randomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.randomBtn.Location = new System.Drawing.Point(83, 15);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(60, 35);
            this.randomBtn.TabIndex = 7;
            this.randomBtn.Text = "";
            this.toolTip1.SetToolTip(this.randomBtn, "Random");
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            this.randomBtn.MouseEnter += new System.EventHandler(this.controls_MouseEnter);
            this.randomBtn.MouseLeave += new System.EventHandler(this.controls_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mp3";
            this.openFileDialog1.Filter = "Music files|*.mp3;*.wav|All files|*.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.songsDataGridView);
            this.panel2.Location = new System.Drawing.Point(24, 52);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(901, 443);
            this.panel2.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tag = "";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(951, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(842, 624);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spootify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.songsDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumetb)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songtb)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar songtb;
        private System.Windows.Forms.TrackBar volumetb;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

