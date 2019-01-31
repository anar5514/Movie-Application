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
            this.btnPrevious = new MetroFramework.Controls.MetroButton();
            this.movieSearch = new MetroFramework.Controls.MetroTextBox();
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
            this.movieDescription = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            this.show = new System.Windows.Forms.Label();
            this.cinemaPicture = new System.Windows.Forms.PictureBox();
            this.labelImdb = new MetroFramework.Controls.MetroLabel();
            this.movieImdb = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPrevious.Location = new System.Drawing.Point(12, 512);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(137, 40);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // movieSearch
            // 
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
            this.movieSearch.Lines = new string[0];
            this.movieSearch.Location = new System.Drawing.Point(12, 12);
            this.movieSearch.MaxLength = 32767;
            this.movieSearch.Name = "movieSearch";
            this.movieSearch.PasswordChar = '\0';
            this.movieSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.movieSearch.SelectedText = "";
            this.movieSearch.SelectionLength = 0;
            this.movieSearch.SelectionStart = 0;
            this.movieSearch.ShortcutsEnabled = true;
            this.movieSearch.Size = new System.Drawing.Size(568, 30);
            this.movieSearch.TabIndex = 4;
            this.movieSearch.UseSelectable = true;
            this.movieSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.movieSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSearch.Location = new System.Drawing.Point(604, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.search_Click);
            // 
            // btnNext
            // 
            this.btnNext.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNext.Location = new System.Drawing.Point(186, 512);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 40);
            this.btnNext.TabIndex = 6;
            this.btnNext.TabStop = false;
            this.btnNext.Text = ">>";
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Purple;
            this.labelTitle.Location = new System.Drawing.Point(351, 167);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(98, 28);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRuntime
            // 
            this.labelRuntime.Location = new System.Drawing.Point(351, 295);
            this.labelRuntime.Name = "labelRuntime";
            this.labelRuntime.Size = new System.Drawing.Size(98, 28);
            this.labelRuntime.TabIndex = 8;
            this.labelRuntime.Text = "Runtime";
            this.labelRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYear
            // 
            this.labelYear.Location = new System.Drawing.Point(351, 253);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(98, 28);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "Year";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGenre
            // 
            this.labelGenre.Location = new System.Drawing.Point(351, 212);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(98, 28);
            this.labelGenre.TabIndex = 10;
            this.labelGenre.Text = "Genre";
            this.labelGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(351, 336);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(98, 28);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieTitle
            // 
            this.movieTitle.BackColor = System.Drawing.Color.Purple;
            this.movieTitle.Location = new System.Drawing.Point(482, 167);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(191, 28);
            this.movieTitle.TabIndex = 13;
            this.movieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieGenre
            // 
            this.movieGenre.Location = new System.Drawing.Point(482, 212);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(191, 28);
            this.movieGenre.TabIndex = 14;
            this.movieGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieYear
            // 
            this.movieYear.Location = new System.Drawing.Point(482, 253);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(191, 28);
            this.movieYear.TabIndex = 15;
            this.movieYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieRuntime
            // 
            this.movieRuntime.Location = new System.Drawing.Point(482, 295);
            this.movieRuntime.Name = "movieRuntime";
            this.movieRuntime.Size = new System.Drawing.Size(191, 28);
            this.movieRuntime.TabIndex = 16;
            this.movieRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieDescription
            // 
            this.movieDescription.Location = new System.Drawing.Point(482, 336);
            this.movieDescription.Name = "movieDescription";
            this.movieDescription.Size = new System.Drawing.Size(191, 28);
            this.movieDescription.TabIndex = 17;
            this.movieDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(422, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 40);
            this.btnSave.TabIndex = 19;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save as";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnOpen.Location = new System.Drawing.Point(565, 512);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(137, 40);
            this.btnOpen.TabIndex = 20;
            this.btnOpen.TabStop = false;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseSelectable = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(376, 445);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(42, 21);
            this.show.TabIndex = 21;
            // 
            // cinemaPicture
            // 
            this.cinemaPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cinemaPicture.Location = new System.Drawing.Point(12, 55);
            this.cinemaPicture.Name = "cinemaPicture";
            this.cinemaPicture.Size = new System.Drawing.Size(311, 433);
            this.cinemaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cinemaPicture.TabIndex = 0;
            this.cinemaPicture.TabStop = false;
            // 
            // labelImdb
            // 
            this.labelImdb.BackColor = System.Drawing.Color.Purple;
            this.labelImdb.Location = new System.Drawing.Point(351, 377);
            this.labelImdb.Name = "labelImdb";
            this.labelImdb.Size = new System.Drawing.Size(98, 28);
            this.labelImdb.TabIndex = 22;
            this.labelImdb.Text = "IMDB";
            this.labelImdb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieImdb
            // 
            this.movieImdb.Location = new System.Drawing.Point(482, 377);
            this.movieImdb.Name = "movieImdb";
            this.movieImdb.Size = new System.Drawing.Size(191, 28);
            this.movieImdb.TabIndex = 23;
            this.movieImdb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(30)))), ((int)(((byte)(190)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 559);
            this.Controls.Add(this.movieImdb);
            this.Controls.Add(this.labelImdb);
            this.Controls.Add(this.show);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.movieDescription);
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
            this.Name = "MovieApp";
            this.Text = "Movie Application";
            this.Load += new System.EventHandler(this.CinemaApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cinemaPicture;
        private MetroFramework.Controls.MetroButton btnPrevious;
        private MetroFramework.Controls.MetroTextBox movieSearch;
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
        private MetroFramework.Controls.MetroLabel movieDescription;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnOpen;
        private System.Windows.Forms.Label show;
        private MetroFramework.Controls.MetroLabel labelImdb;
        private MetroFramework.Controls.MetroLabel movieImdb;
    }
}

