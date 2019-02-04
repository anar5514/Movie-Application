using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApp
{
    public partial class MovieApp : Form
    {
        public dynamic Data { get; set; }
        public int CurrentIndex { get; set; }
        public int DataSize { get; set; }

        public MovieApp()
        {
            InitializeComponent();
        }

        private void CinemaApp_Load(object sender, EventArgs e)
        {
            //labelTitle.BackColor = Color.FromArgb(200, Color.Black);
            //labelGenre.BackColor = Color.FromArgb(200, Color.Black);
            //labelYear.BackColor = Color.FromArgb(200, Color.Black);
            //labelRuntime.BackColor = Color.FromArgb(200, Color.Black);
            //labelImdb.BackColor = Color.FromArgb(200, Color.Black);
        }

        private void search_Click(object sender, EventArgs e)
        {
            CurrentIndex = 0;
            if(movieSearch.Text != string.Empty)
            {                

                HttpClient http = new HttpClient();
                var response = http.GetAsync($@"http://www.omdbapi.com/?apikey=a9a2e8a2&s={movieSearch.Text}").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                var errormessage = str.Split('"');

                if (!str.Contains("\"Response\":\"False\""))
                {
                    dynamic data = JsonConvert.DeserializeObject(str);
                    Data = data;
                    DataSize = data.Search.Count;
                    labelShow.Text = $"{(CurrentIndex + 1).ToString()} of {DataSize} results";

                    response = http.GetAsync($@"http://www.omdbapi.com/?apikey=a9a2e8a2&t={Data.Search[CurrentIndex].Title}").Result;
                    str = response.Content.ReadAsStringAsync().Result;
                    data = JsonConvert.DeserializeObject(str);

                    if (data.Poster != "N/A")
                    {
                        cinemaPicture.Load($@"{data.Poster}");
                        movieTitle.Text = data.Title;
                        movieGenre.Text = data.Genre;
                        movieRuntime.Text = data.Runtime;
                        movieYear.Text = data.Year;
                        movieImdb.Text = data.imdbRating;
                        movieDescription.Text = data.Plot;
                    }
                    else if (data.Poster == "N/A")
                    {
                        cinemaPicture.Image = Properties.Resources.notfound;
                        movieTitle.Text = data.Title;
                        movieGenre.Text = data.Genre;
                        movieRuntime.Text = data.Runtime;
                        movieYear.Text = data.Year;
                        movieImdb.Text = data.imdbRating;
                        movieDescription.Text = data.Plot;
                    }
                    cinemaPicture.Visible = true;
                    movieTitle.Visible = true;
                    movieGenre.Visible = true;
                    movieRuntime.Visible = true;
                    movieYear.Visible = true;
                    movieImdb.Visible = true;
                    movieDescription.Visible = true;
                    labelTitle.Visible = true;
                    labelGenre.Visible = true;
                    labelRuntime.Visible = true;
                    labelYear.Visible = true;
                    labelImdb.Visible = true;
                    btnPrevious.Visible = true;
                    btnNext.Visible = true;
                    btnSave.Visible = true;
                    btnOpen.Visible = true;
                    labelDescription.Visible = true;
                    labelShow.Visible = true;
                }
                else
                    MessageBox.Show(errormessage[7], "Error");


            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(JSON files)|*.json";
            saveFileDialog.FileName = movieTitle.Text;

            HttpClient http = new HttpClient();
            if (Data != null)
            {
                var response = http.GetAsync($@"http://www.omdbapi.com/?apikey=a9a2e8a2&t={Data.Search[CurrentIndex].Title}").Result;
                var str = response.Content.ReadAsStringAsync().Result;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = Path.GetFullPath(saveFileDialog.FileName);
                    File.WriteAllText(filePath, str);
                }
            }

            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(Json files)|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = Path.GetFullPath(openFileDialog.FileName);
                var jsoncontent = File.ReadAllText(filePath);
                var obj = JsonConvert.DeserializeObject<dynamic>(jsoncontent);

                if (obj.Poster != "N/A")
                {
                    cinemaPicture.Load($@"{obj.Poster}");
                    movieTitle.Text = obj.Title;
                    movieGenre.Text = obj.Genre;
                    movieRuntime.Text = obj.Runtime;
                    movieYear.Text = obj.Year;
                    movieImdb.Text = obj.imdbRating;
                    movieDescription.Text = obj.Plot;
                }
                else if (obj.Poster == "N/A")
                {
                    cinemaPicture.Image = Properties.Resources.notfound;
                    movieTitle.Text = obj.Title;
                    movieGenre.Text = obj.Genre;
                    movieRuntime.Text = obj.Runtime;
                    movieYear.Text = obj.Year;
                    movieImdb.Text = obj.imdbRating;
                    movieDescription.Text = obj.Plot;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
            {
                --CurrentIndex;
                labelShow.Text = $"{(CurrentIndex + 1).ToString()} of {DataSize} results";

                HttpClient http = new HttpClient();
                var response = http.GetAsync($@"http://www.omdbapi.com/?apikey=a9a2e8a2&t={Data.Search[CurrentIndex].Title}").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                dynamic data = JsonConvert.DeserializeObject(str);

                if (data.Poster != "N/A")
                {
                    cinemaPicture.Load($@"{data.Poster}");
                    movieTitle.Text = data.Title;
                    movieGenre.Text = data.Genre;
                    movieRuntime.Text = data.Runtime;
                    movieYear.Text = data.Year;
                    movieImdb.Text = data.imdbRating;
                    movieDescription.Text = data.Plot;
                }
                else if (data.Poster == "N/A")
                {
                    cinemaPicture.Image = Properties.Resources.notfound;
                    movieTitle.Text = data.Title;
                    movieGenre.Text = data.Genre;
                    movieRuntime.Text = data.Runtime;
                    movieYear.Text = data.Year;
                    movieImdb.Text = data.imdbRating;
                    movieDescription.Text = data.Plot;
                }
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (CurrentIndex < DataSize - 1)
            {
                ++CurrentIndex;
                labelShow.Text = $"{(CurrentIndex + 1).ToString()} of {DataSize} results";

                HttpClient http = new HttpClient();
                var response = http.GetAsync($@"http://www.omdbapi.com/?apikey=a9a2e8a2&t={Data.Search[CurrentIndex].Title}").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                dynamic data = JsonConvert.DeserializeObject(str);

                if (data.Poster != "N/A")
                {
                    cinemaPicture.Load($"{data.Poster}");
                    movieTitle.Text = data.Title;
                    movieGenre.Text = data.Genre;
                    movieRuntime.Text = data.Runtime;
                    movieYear.Text = data.Year;
                    movieImdb.Text = data.imdbRating;
                    movieDescription.Text = data.Plot;
                }
                else if (data.Poster == "N/A")
                {
                    cinemaPicture.Image = Properties.Resources.notfound;
                    movieTitle.Text = data.Title;
                    movieGenre.Text = data.Genre;
                    movieRuntime.Text = data.Runtime;
                    movieYear.Text = data.Year;
                    movieImdb.Text = data.imdbRating;
                    movieDescription.Text = data.Plot;
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void movieSearch_TextChanged(object sender, EventArgs e)
        {
            if(movieSearch.Text == string.Empty)
            {
                cinemaPicture.Visible = false;
                movieTitle.Visible = false;
                movieGenre.Visible = false;
                movieRuntime.Visible = false;
                movieYear.Visible = false;
                movieImdb.Visible = false;
                movieDescription.Visible = false;
                labelTitle.Visible = false;
                labelGenre.Visible = false;
                labelRuntime.Visible = false;
                labelYear.Visible = false;
                labelImdb.Visible = false;
                labelDescription.Visible = false;
                btnPrevious.Visible = false;
                btnNext.Visible = false;
                btnSave.Visible = false;
                btnOpen.Visible = false;
                    
            }
        }
    }

}
