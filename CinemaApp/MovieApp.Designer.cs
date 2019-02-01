namespace CinemaApp
{
    partial class MovieApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieApp));
            this.btnPrevious = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.labelRuntime = new MetroFramework.Controls.MetroLabel();
            this.labelYear = new MetroFramework.Controls.MetroLabel();
            this.labelGenre = new MetroFramework.Controls.MetroLabel();
            this.labelDescription = new MetroFramework.Controls.MetroLabel();
            this.movieTitle = new MetroFramework.Controls.MetroLabel();
            this.movieGenre = new MetroFramework.Controls.MetroLabel();
            this.movieYear = new MetroFramework.Controls.MetroLabel();
            this.movieRuntime = new MetroFramework.Controls.MetroLabel();
            this.movieImdb = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            this.labelImdb = new MetroFramework.Controls.MetroLabel();
            this.movieDescription = new MetroFramework.Controls.MetroLabel();
            this.labelShow = new MetroFramework.Controls.MetroLabel();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.movieSearch = new MetroFramework.Controls.MetroTextBox();
            this.cinemaPicture = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new MetroFramework.Controls.MetroButton();
            this.formTopPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaPicture)).BeginInit();
            this.formTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.BackgroundImage")));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPrevious.Location = new System.Drawing.Point(67, 574);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(69, 40);
            this.btnPrevious.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.UseCustomBackColor = true;
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Visible = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSearch.Location = new System.Drawing.Point(888, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 48);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnSearch.TabIndex = 5;
            this.btnSearch.TabStop = false;
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.search_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNext.Location = new System.Drawing.Point(209, 574);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(69, 40);
            this.btnNext.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnNext.TabIndex = 6;
            this.btnNext.TabStop = false;
            this.btnNext.UseCustomBackColor = true;
            this.btnNext.UseSelectable = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Black;
            this.labelTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelTitle.ForeColor = System.Drawing.Color.DimGray;
            this.labelTitle.Location = new System.Drawing.Point(387, 193);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(98, 28);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.UseCustomBackColor = true;
            this.labelTitle.UseCustomForeColor = true;
            this.labelTitle.Visible = false;
            // 
            // labelRuntime
            // 
            this.labelRuntime.BackColor = System.Drawing.Color.Black;
            this.labelRuntime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelRuntime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelRuntime.ForeColor = System.Drawing.Color.DimGray;
            this.labelRuntime.Location = new System.Drawing.Point(387, 321);
            this.labelRuntime.Name = "labelRuntime";
            this.labelRuntime.Size = new System.Drawing.Size(98, 28);
            this.labelRuntime.TabIndex = 8;
            this.labelRuntime.Text = "Runtime";
            this.labelRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRuntime.UseCustomBackColor = true;
            this.labelRuntime.UseCustomForeColor = true;
            this.labelRuntime.Visible = false;
            // 
            // labelYear
            // 
            this.labelYear.BackColor = System.Drawing.Color.Black;
            this.labelYear.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelYear.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelYear.ForeColor = System.Drawing.Color.DimGray;
            this.labelYear.Location = new System.Drawing.Point(387, 279);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(98, 28);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "Year";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelYear.UseCustomBackColor = true;
            this.labelYear.UseCustomForeColor = true;
            this.labelYear.Visible = false;
            // 
            // labelGenre
            // 
            this.labelGenre.BackColor = System.Drawing.Color.Black;
            this.labelGenre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelGenre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelGenre.ForeColor = System.Drawing.Color.DimGray;
            this.labelGenre.Location = new System.Drawing.Point(387, 238);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(98, 28);
            this.labelGenre.TabIndex = 10;
            this.labelGenre.Text = "Genre";
            this.labelGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelGenre.UseCustomBackColor = true;
            this.labelGenre.UseCustomForeColor = true;
            this.labelGenre.Visible = false;
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescription.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelDescription.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelDescription.ForeColor = System.Drawing.Color.Gray;
            this.labelDescription.Location = new System.Drawing.Point(1008, 175);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(125, 28);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDescription.UseCustomBackColor = true;
            this.labelDescription.UseCustomForeColor = true;
            this.labelDescription.Visible = false;
            // 
            // movieTitle
            // 
            this.movieTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.movieTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.movieTitle.ForeColor = System.Drawing.Color.DimGray;
            this.movieTitle.Location = new System.Drawing.Point(518, 193);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(391, 28);
            this.movieTitle.TabIndex = 13;
            this.movieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.movieTitle.UseCustomBackColor = true;
            this.movieTitle.UseCustomForeColor = true;
            this.movieTitle.Visible = false;
            // 
            // movieGenre
            // 
            this.movieGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieGenre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.movieGenre.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.movieGenre.ForeColor = System.Drawing.Color.DimGray;
            this.movieGenre.Location = new System.Drawing.Point(518, 238);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(391, 28);
            this.movieGenre.TabIndex = 14;
            this.movieGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.movieGenre.UseCustomBackColor = true;
            this.movieGenre.UseCustomForeColor = true;
            this.movieGenre.Visible = false;
            // 
            // movieYear
            // 
            this.movieYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieYear.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.movieYear.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.movieYear.ForeColor = System.Drawing.Color.DimGray;
            this.movieYear.Location = new System.Drawing.Point(518, 279);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(391, 28);
            this.movieYear.TabIndex = 15;
            this.movieYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.movieYear.UseCustomBackColor = true;
            this.movieYear.UseCustomForeColor = true;
            this.movieYear.Visible = false;
            // 
            // movieRuntime
            // 
            this.movieRuntime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieRuntime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.movieRuntime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.movieRuntime.ForeColor = System.Drawing.Color.DimGray;
            this.movieRuntime.Location = new System.Drawing.Point(518, 321);
            this.movieRuntime.Name = "movieRuntime";
            this.movieRuntime.Size = new System.Drawing.Size(391, 28);
            this.movieRuntime.TabIndex = 16;
            this.movieRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.movieRuntime.UseCustomBackColor = true;
            this.movieRuntime.UseCustomForeColor = true;
            this.movieRuntime.Visible = false;
            // 
            // movieImdb
            // 
            this.movieImdb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieImdb.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.movieImdb.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.movieImdb.ForeColor = System.Drawing.Color.DimGray;
            this.movieImdb.Location = new System.Drawing.Point(518, 362);
            this.movieImdb.Name = "movieImdb";
            this.movieImdb.Size = new System.Drawing.Size(391, 28);
            this.movieImdb.TabIndex = 17;
            this.movieImdb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.movieImdb.UseCustomBackColor = true;
            this.movieImdb.UseCustomForeColor = true;
            this.movieImdb.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(543, 557);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 57);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnSave.TabIndex = 19;
            this.btnSave.TabStop = false;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.BackgroundImage")));
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnOpen.Location = new System.Drawing.Point(632, 557);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(62, 57);
            this.btnOpen.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnOpen.TabIndex = 20;
            this.btnOpen.TabStop = false;
            this.btnOpen.UseCustomBackColor = true;
            this.btnOpen.UseSelectable = true;
            this.btnOpen.Visible = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // labelImdb
            // 
            this.labelImdb.BackColor = System.Drawing.Color.Black;
            this.labelImdb.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelImdb.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelImdb.ForeColor = System.Drawing.Color.DimGray;
            this.labelImdb.Location = new System.Drawing.Point(387, 362);
            this.labelImdb.Name = "labelImdb";
            this.labelImdb.Size = new System.Drawing.Size(98, 28);
            this.labelImdb.TabIndex = 22;
            this.labelImdb.Text = "IMDB";
            this.labelImdb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelImdb.UseCustomBackColor = true;
            this.labelImdb.UseCustomForeColor = true;
            this.labelImdb.Visible = false;
            // 
            // movieDescription
            // 
            this.movieDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieDescription.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.movieDescription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.movieDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.movieDescription.Location = new System.Drawing.Point(948, 225);
            this.movieDescription.Name = "movieDescription";
            this.movieDescription.Size = new System.Drawing.Size(270, 242);
            this.movieDescription.TabIndex = 23;
            this.movieDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.movieDescription.UseCustomBackColor = true;
            this.movieDescription.UseCustomForeColor = true;
            this.movieDescription.Visible = false;
            this.movieDescription.WrapToLine = true;
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelShow.ForeColor = System.Drawing.Color.DimGray;
            this.labelShow.Location = new System.Drawing.Point(387, 516);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 0);
            this.labelShow.TabIndex = 24;
            this.labelShow.UseCustomBackColor = true;
            this.labelShow.UseCustomForeColor = true;
            this.labelShow.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnExit.BackgroundImage = global::CinemaApp.Properties.Resources.exiticon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1177, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 41);
            this.btnExit.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnExit.TabIndex = 25;
            this.btnExit.TabStop = false;
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // movieSearch
            // 
            this.movieSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.movieSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // 
            // 
            this.movieSearch.CustomButton.Image = null;
            this.movieSearch.CustomButton.Location = new System.Drawing.Point(540, 2);
            this.movieSearch.CustomButton.Name = "";
            this.movieSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.movieSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.movieSearch.CustomButton.TabIndex = 1;
            this.movieSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.movieSearch.CustomButton.UseSelectable = true;
            this.movieSearch.CustomButton.Visible = false;
            this.movieSearch.DisplayIcon = true;
            this.movieSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.movieSearch.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.movieSearch.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.movieSearch.Icon = global::CinemaApp.Properties.Resources.searchicon1;
            this.movieSearch.Lines = new string[0];
            this.movieSearch.Location = new System.Drawing.Point(305, 67);
            this.movieSearch.MaxLength = 32767;
            this.movieSearch.Name = "movieSearch";
            this.movieSearch.PasswordChar = '\0';
            this.movieSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.movieSearch.SelectedText = "";
            this.movieSearch.SelectionLength = 0;
            this.movieSearch.SelectionStart = 0;
            this.movieSearch.ShortcutsEnabled = true;
            this.movieSearch.ShowClearButton = true;
            this.movieSearch.Size = new System.Drawing.Size(568, 30);
            this.movieSearch.Style = MetroFramework.MetroColorStyle.Purple;
            this.movieSearch.TabIndex = 4;
            this.movieSearch.UseCustomBackColor = true;
            this.movieSearch.UseCustomForeColor = true;
            this.movieSearch.UseSelectable = true;
            this.movieSearch.UseStyleColors = true;
            this.movieSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.movieSearch.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieSearch.TextChanged += new System.EventHandler(this.movieSearch_TextChanged);
            // 
            // cinemaPicture
            // 
            this.cinemaPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cinemaPicture.Location = new System.Drawing.Point(0, 103);
            this.cinemaPicture.Name = "cinemaPicture";
            this.cinemaPicture.Size = new System.Drawing.Size(330, 453);
            this.cinemaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cinemaPicture.TabIndex = 0;
            this.cinemaPicture.TabStop = false;
            this.cinemaPicture.Visible = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMinimize.Location = new System.Drawing.Point(1115, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(56, 41);
            this.btnMinimize.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnMinimize.TabIndex = 26;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseCustomBackColor = true;
            this.btnMinimize.UseSelectable = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // formTopPanel
            // 
            this.formTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.formTopPanel.Controls.Add(this.metroLabel1);
            this.formTopPanel.Controls.Add(this.btnMinimize);
            this.formTopPanel.Controls.Add(this.btnExit);
            this.formTopPanel.Controls.Add(this.pictureBox1);
            this.formTopPanel.HorizontalScrollbarBarColor = true;
            this.formTopPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.formTopPanel.HorizontalScrollbarSize = 10;
            this.formTopPanel.Location = new System.Drawing.Point(0, 1);
            this.formTopPanel.Name = "formTopPanel";
            this.formTopPanel.Size = new System.Drawing.Size(1234, 41);
            this.formTopPanel.TabIndex = 27;
            this.formTopPanel.UseCustomBackColor = true;
            this.formTopPanel.VerticalScrollbarBarColor = true;
            this.formTopPanel.VerticalScrollbarHighlightOnWheel = false;
            this.formTopPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Indigo;
            this.metroLabel1.Location = new System.Drawing.Point(56, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 39);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "EA Movie";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CinemaApp.Properties.Resources.iconApp1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MovieApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.BackgroundImage = global::CinemaApp.Properties.Resources.formBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1233, 619);
            this.Controls.Add(this.formTopPanel);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.movieDescription);
            this.Controls.Add(this.labelImdb);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.movieImdb);
            this.Controls.Add(this.movieRuntime);
            this.Controls.Add(this.movieYear);
            this.Controls.Add(this.movieGenre);
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelRuntime);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.movieSearch);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.cinemaPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieApp";
            this.Text = "EA Movie";
            this.Load += new System.EventHandler(this.CinemaApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaPicture)).EndInit();
            this.formTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cinemaPicture;
        private MetroFramework.Controls.MetroButton btnPrevious;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel labelRuntime;
        private MetroFramework.Controls.MetroLabel labelYear;
        private MetroFramework.Controls.MetroLabel labelGenre;
        private MetroFramework.Controls.MetroLabel labelDescription;
        private MetroFramework.Controls.MetroLabel movieTitle;
        private MetroFramework.Controls.MetroLabel movieGenre;
        private MetroFramework.Controls.MetroLabel movieYear;
        private MetroFramework.Controls.MetroLabel movieRuntime;
        private MetroFramework.Controls.MetroLabel movieImdb;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnOpen;
        private MetroFramework.Controls.MetroLabel labelImdb;
        private MetroFramework.Controls.MetroLabel movieDescription;
        private MetroFramework.Controls.MetroLabel labelShow;
        private MetroFramework.Controls.MetroTextBox movieSearch;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnMinimize;
        private MetroFramework.Controls.MetroPanel formTopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

