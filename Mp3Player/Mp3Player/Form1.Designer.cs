namespace Mp3Player
{
    partial class mp3Player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mp3Player));
            this.topPanel = new System.Windows.Forms.Panel();
            this.minBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.mplists = new System.Windows.Forms.ListBox();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.shuffleBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.selectSongbtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timeBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel1 = new System.Windows.Forms.Label();
            this.timerLabel2 = new System.Windows.Forms.Label();
            this.volumeVal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MistyRose;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.minBtn);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.closeBtn);
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.Name = "topPanel";
            this.topPanel.Click += new System.EventHandler(this.topPanel_Click);
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.MistyRose;
            this.minBtn.BackgroundImage = global::Mp3Player.Properties.Resources.icons8_minimize_window_100__1_;
            resources.ApplyResources(this.minBtn, "minBtn");
            this.minBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minBtn.Name = "minBtn";
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Name = "label1";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.MistyRose;
            this.closeBtn.BackgroundImage = global::Mp3Player.Properties.Resources.icons8_close_window_100;
            resources.ApplyResources(this.closeBtn, "closeBtn");
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // mplists
            // 
            this.mplists.BackColor = System.Drawing.Color.Bisque;
            this.mplists.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.mplists, "mplists");
            this.mplists.FormattingEnabled = true;
            this.mplists.Name = "mplists";
            this.mplists.SelectedIndexChanged += new System.EventHandler(this.mplists_SelectedIndexChanged);
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.MistyRose;
            this.btnPanel.Controls.Add(this.deleteBtn);
            this.btnPanel.Controls.Add(this.shuffleBtn);
            this.btnPanel.Controls.Add(this.forwardBtn);
            this.btnPanel.Controls.Add(this.stopBtn);
            this.btnPanel.Controls.Add(this.playBtn);
            this.btnPanel.Controls.Add(this.backBtn);
            this.btnPanel.Controls.Add(this.selectSongbtn);
            resources.ApplyResources(this.btnPanel, "btnPanel");
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPanel_Paint);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.MistyRose;
            this.deleteBtn.BackgroundImage = global::Mp3Player.Properties.Resources.icons8_delete_64;
            resources.ApplyResources(this.deleteBtn, "deleteBtn");
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.BackColor = System.Drawing.Color.MistyRose;
            this.shuffleBtn.BackgroundImage = global::Mp3Player.Properties.Resources.icons8_shuffle_1001;
            resources.ApplyResources(this.shuffleBtn, "shuffleBtn");
            this.shuffleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.UseVisualStyleBackColor = false;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.BackColor = System.Drawing.Color.MistyRose;
            this.forwardBtn.BackgroundImage = global::Mp3Player.Properties.Resources.icons8_fast_forward_64;
            resources.ApplyResources(this.forwardBtn, "forwardBtn");
            this.forwardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.UseVisualStyleBackColor = false;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.MistyRose;
            this.stopBtn.BackgroundImage = global::Mp3Player.Properties.Resources.icons8_pause_button_64;
            resources.ApplyResources(this.stopBtn, "stopBtn");
            this.stopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.MistyRose;
            this.playBtn.BackgroundImage = global::Mp3Player.Properties.Resources.icons8_circled_play_64;
            resources.ApplyResources(this.playBtn, "playBtn");
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn.Name = "playBtn";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.MistyRose;
            this.backBtn.BackgroundImage = global::Mp3Player.Properties.Resources.icons8_rewind_64;
            resources.ApplyResources(this.backBtn, "backBtn");
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Name = "backBtn";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // selectSongbtn
            // 
            this.selectSongbtn.BackColor = System.Drawing.Color.MistyRose;
            this.selectSongbtn.BackgroundImage = global::Mp3Player.Properties.Resources.icons8_add_64_removebg_preview;
            resources.ApplyResources(this.selectSongbtn, "selectSongbtn");
            this.selectSongbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectSongbtn.Name = "selectSongbtn";
            this.selectSongbtn.UseVisualStyleBackColor = false;
            this.selectSongbtn.Click += new System.EventHandler(this.selectSongbtn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.MistyRose;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timeBar
            // 
            this.timeBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.timeBar, "timeBar");
            this.timeBar.Name = "timeBar";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel1
            // 
            resources.ApplyResources(this.timerLabel1, "timerLabel1");
            this.timerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel1.Name = "timerLabel1";
            // 
            // timerLabel2
            // 
            resources.ApplyResources(this.timerLabel2, "timerLabel2");
            this.timerLabel2.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel2.Name = "timerLabel2";
            // 
            // volumeVal
            // 
            resources.ApplyResources(this.volumeVal, "volumeVal");
            this.volumeVal.BackColor = System.Drawing.Color.Transparent;
            this.volumeVal.Name = "volumeVal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Mp3Player.Properties.Resources.icons8_headphones_1001;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // mp3Player
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mp3Player.Properties.Resources.annie_spratt_zA7I5BtFbvw_unsplash;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.volumeVal);
            this.Controls.Add(this.timerLabel2);
            this.Controls.Add(this.timerLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeBar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.mplists);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mp3Player";
            this.Load += new System.EventHandler(this.mp3Player_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox mplists;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button selectSongbtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar timeBar;
        private System.Windows.Forms.Button shuffleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel1;
        private System.Windows.Forms.Label timerLabel2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label volumeVal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

