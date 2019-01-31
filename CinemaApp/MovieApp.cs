using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            CurrentIndex = 0;
            HttpClient http = new HttpClient(); 
            var response =  http.GetAsync($@"http://www.omdbapi.com/?apikey=a9a2e8a2&s={movieSearch.Text}").Result;
            var str = response.Content.ReadAsStringAsync().Result;
            dynamic data = JsonConvert.DeserializeObject(str);
            Data = data;
            DataSize = data.Search.Count;
            cinemaPicture.Load($@"{data.Search[CurrentIndex].Poster}");
            movieTitle.Text = data.Search[CurrentIndex].Title;
            movieGenre.Text = data.Search[CurrentIndex].Genre;
            movieRuntime.Text = data.Search[CurrentIndex].Runtime;
            movieYear.Text = data.Search[CurrentIndex].Year;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(Json files)|*.json";
            saveFileDialog.ShowDialog();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(Json files)|*.json";
            openFileDialog.ShowDialog();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();
            var response = http.GetAsync($@"http://www.omdbapi.com/?apikey=a9a2e8a2&s={movieSearch.Text}").Result;
            var str = response.Content.ReadAsStringAsync().Result;
            dynamic data = JsonConvert.DeserializeObject(str);

            if (CurrentIndex > 0)
            {
                --CurrentIndex;
                show.Text = CurrentIndex.ToString();

                if (Data.Search[CurrentIndex].Poster != "N/A")
                {
                    cinemaPicture.Load($@"{Data.Search[CurrentIndex].Poster}");
                    movieTitle.Text = Data.Search[CurrentIndex].Title;
                    movieGenre.Text = Data.Search[CurrentIndex].Genre;
                    movieRuntime.Text = Data.Search[CurrentIndex].Runtime;
                    movieYear.Text = Data.Search[CurrentIndex].Year;
                    movieImdb.Text = Data.Search[CurrentIndex].imdbRating;
                }
                else if (Data.Search[CurrentIndex].Poster == "N/A")
                {
                    cinemaPicture.Image = Properties.Resources.None;
                    movieTitle.Text = Data.Search[CurrentIndex].Title;
                    movieGenre.Text = Data.Search[CurrentIndex].Genre;
                    movieRuntime.Text = Data.Search[CurrentIndex].Runtime;
                    movieYear.Text = Data.Search[CurrentIndex].Year;
                    movieImdb.Text = Data.Search[CurrentIndex].imdbRating;
                }
            }                                
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (CurrentIndex < DataSize - 1)
            {
                ++CurrentIndex;
                show.Text = CurrentIndex.ToString();

                if (Data.Search[CurrentIndex].Poster != "N/A")
                {
                    cinemaPicture.Load($@"{Data.Search[CurrentIndex].Poster}");
                    movieTitle.Text = Data.Search[CurrentIndex].Title;
                    movieGenre.Text = Data.Search[CurrentIndex].Genre;
                    movieRuntime.Text = Data.Search[CurrentIndex].Runtime;
                    movieYear.Text = Data.Search[CurrentIndex].Year;
                    movieImdb.Text = Data.Search[CurrentIndex].imdbRating;
                }
                else if (Data.Search[CurrentIndex].Poster == "N/A")
                {
                    cinemaPicture.Image = Properties.Resources.None;
                    movieTitle.Text = Data.Search[CurrentIndex].Title;
                    movieGenre.Text = Data.Search[CurrentIndex].Genre;
                    movieRuntime.Text = Data.Search[CurrentIndex].Runtime;
                    movieYear.Text = Data.Search[CurrentIndex].Year;
                    movieImdb.Text = Data.Search[CurrentIndex].imdbRating;
                }
                
            }
        }
    }
    
}
