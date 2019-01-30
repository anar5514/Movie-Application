namespace CinemaApp
{
    partial class CinemaApp
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
            this.cinemaPicture = new System.Windows.Forms.PictureBox();
            this.previous = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.search = new MetroFramework.Controls.MetroButton();
            this.next = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // cinemaPicture
            // 
            this.cinemaPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cinemaPicture.Location = new System.Drawing.Point(12, 55);
            this.cinemaPicture.Name = "cinemaPicture";
            this.cinemaPicture.Size = new System.Drawing.Size(311, 433);
            this.cinemaPicture.TabIndex = 0;
            this.cinemaPicture.TabStop = false;
            // 
            // previous
            // 
            this.previous.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.previous.Location = new System.Drawing.Point(12, 512);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(137, 40);
            this.previous.TabIndex = 3;
            this.previous.Text = "<<";
            this.previous.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(546, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(12, 12);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(568, 30);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // search
            // 
            this.search.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.search.Location = new System.Drawing.Point(604, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(166, 30);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseSelectable = true;
            // 
            // next
            // 
            this.next.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.next.Location = new System.Drawing.Point(186, 512);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(137, 40);
            this.next.TabIndex = 6;
            this.next.Text = ">>";
            this.next.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Purple;
            this.metroLabel1.Location = new System.Drawing.Point(351, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 28);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Title";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(351, 295);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 28);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Runtime";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(351, 253);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 28);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Year";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(351, 212);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 28);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Genre";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(351, 336);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 28);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Description";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CinemaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(30)))), ((int)(((byte)(190)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 564);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.search);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.cinemaPicture);
            this.Name = "CinemaApp";
            this.Text = "Cinema ";
            this.Load += new System.EventHandler(this.CinemaApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cinemaPicture;
        private MetroFramework.Controls.MetroButton previous;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton search;
        private MetroFramework.Controls.MetroButton next;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}

