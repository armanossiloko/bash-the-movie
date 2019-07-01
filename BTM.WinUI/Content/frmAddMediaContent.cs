using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTM.Models;
using BTM.Models.Requests;
using Flurl.Http;
using MetroFramework.Forms;

namespace BTM.WinUI.Content
{
    public partial class frmAddMediaContent : MetroForm
    {
        private OpenFileDialog OpenFileDialog = new OpenFileDialog();

        private APIService _mediaService = new APIService("Media");
        //private APIService _trailersService = new APIService("Trailers"); // NOT TESTED
        //private APIService _soundtrackData  = new APIService("Soundtracks");

        private string OriginalSoundtrack = "";
        private string Soundtrack = "";
        private string OriginalTrailer = "";
        private string Trailer = "";
        private Media Media = null;
        private Soundtrack ThemeSong = null;
        private Trailer trailer = null;
        private List<PlotInputModel> PlotKeywords = new List<PlotInputModel>();

        public frmAddMediaContent()
        {
            InitializeComponent();
        }

        private void FrmAddMediaContent_Load(object sender, EventArgs e)
        {
			txtPlotKeywords.PromptText = "Separate each keyword with ;";
        }

        private void TxtTrailer_TextChanged(object sender, EventArgs e)
        {
            Trailer = txtTrailer.Text;
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            if (gridResults.Rows.Count > 0)
            {
                gridResults.Rows.Clear();
            }

            IEnumerable<Media> movies = null;
            try
            {
                if (txtTitle.Text != "")
                {
                    movies = await _mediaService.Get<IEnumerable<Media>>(null);
                    movies = movies.Where(m => m.Title.Contains(txtTitle.Text));
                }
            }
            catch { }

            if (movies == null)
            {
                MessageBox.Show("Found no movies! Please try something else.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (movies.Count() > 1)
                {
                    foreach (var item in movies)
                    {
                        gridResults.Rows.Add(item.MediaID, item.Title, item.ReleaseDate.ToShortDateString());
                    }
                    MessageBox.Show("Found more than 1 movie result, please select one in the table below!", "Notice",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (movies.Count() == 1)
                {
                    var item = movies.ElementAt(0);
                    gridResults.Rows.Add(item.MediaID, item.Title, item.ReleaseDate.ToShortDateString());
                }
            }
        }

        private async void GridResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Media = await $"{Properties.Settings.Default.APIUrl}/media/{GetID()}"
                    .WithBasicAuth(APIService.Username, APIService.Password)
                    .GetJsonAsync<Media>();

                // Try to set trailer value in form
                try
                {
                    trailer = await $"{Properties.Settings.Default.APIUrl}/trailers/{GetID()}"
                        .WithBasicAuth(APIService.Username, APIService.Password)
                        .GetJsonAsync<Trailer>();
                    txtTrailer.Text = trailer.Location;
                    OriginalTrailer = trailer.Location;
                }
                catch
                {
                    Trailer = null;
                    txtTrailer.Text = "";
                    OriginalTrailer = "";
                }

                // Try to set soundtrack value in form
                try
                {
                    int x = GetID();
                    ThemeSong = await $"{Properties.Settings.Default.APIUrl}/soundtracks/{GetID()}"
                        .WithBasicAuth(APIService.Username, APIService.Password)
                        .GetJsonAsync<Soundtrack>();
                    txtSoundtrack.Text = ThemeSong.Location;
                    OriginalSoundtrack = ThemeSong.Location;
                }
                catch
                {
                    ThemeSong = null;
                    txtSoundtrack.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "MP3 Files|*.mp3|WAV Files|*.wav" /*+ "|All Files|*.*"*/;
            OpenFileDialog.InitialDirectory = $"{Properties.Settings.Default.InitialDirectory}";
            OpenFileDialog.Multiselect = false;

            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Soundtrack = OpenFileDialog.FileName;
                txtSoundtrack.Text = Soundtrack;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            bool commitedAnything = false; // Keep track if we saved anything to the database

            if (txtPlotKeywords.Text != "")
            {
				if (Media == null)
                {
                    MessageBox.Show("Select a movie first!", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
				
                var arr = txtPlotKeywords.Text.Split(';');
                foreach (var item in arr)
                {
                    PlotInputModel plotInput = new PlotInputModel
                    {
                        MediaID = Media.MediaID,
                        KeywordName = item
                    };

                    try
                    {
                        await $"{Properties.Settings.Default.APIUrl}/PlotKeywords"
                            .WithBasicAuth(APIService.Username, APIService.Password)
                            .PostJsonAsync(plotInput)
                            .ReceiveJson<PlotKeywords>();
                        commitedAnything = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    PlotKeywords.Add(plotInput);
                }
            }

            if (txtTrailer.Text != "" && OriginalTrailer != Trailer)
            {
                Regex regex = new Regex(Global.YouTubeRegex);
                if (regex.Match(txtTrailer.Text).Success)
                {
                    if (trailer == null)
                    {
                        trailer = new Models.Trailer
                        {
                            MediaID = GetID(),
                            Location = Trailer
                        };
                        await $"{Properties.Settings.Default.APIUrl}/Trailers"
                            .WithBasicAuth(APIService.Username, APIService.Password)
                            .PostJsonAsync(trailer);
                        commitedAnything = true;
                    }
                    else
                    {
                        trailer.Location = Trailer;
                        await $"{Properties.Settings.Default.APIUrl}/Trailers/{ThemeSong.SoundtrackID}"
                            .WithBasicAuth(APIService.Username, APIService.Password)
                            .PutJsonAsync(trailer);
                    }
                }
            }

            if (Soundtrack != "" && OriginalSoundtrack != Soundtrack)
            {
                string directory = await $"{Properties.Settings.Default.APIUrl}/info/soundtracks"
                            .GetStringAsync();

                string filename = Path.GetFileName(Soundtrack);
                if (ThemeSong == null)
                {
                    ThemeSong = new Models.Soundtrack
                    {
                        Artist = "Unknown",
                        Name = "Unknown",
                        MediaID = GetID(),
                        Location = $"/Assets/Soundtracks/{filename}"
                    };
                    await $"{Properties.Settings.Default.APIUrl}/Soundtracks"
                        .WithBasicAuth(APIService.Username, APIService.Password)
                        .PostJsonAsync(ThemeSong);
                    commitedAnything = true;
                }
                else
                {
                    ThemeSong.Location = $"/Assets/Soundtracks/{filename}";
                    await $"{Properties.Settings.Default.APIUrl}/Soundtracks/{ThemeSong.SoundtrackID}"
                        .WithBasicAuth(APIService.Username, APIService.Password)
                        .PutJsonAsync(ThemeSong);
                }

                try
                {
                    File.Copy(OpenFileDialog.FileName, $"{directory}/{filename}");
                }
                catch { }
            }

            if (commitedAnything)
            {
                MessageBox.Show("Operation completed!", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
			else 
			{
				MessageBox.Show("No operation to complete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
			}
        }


        #region Support Methods
        private int GetID()
        {
            int selectedrowindex = gridResults.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = gridResults.Rows[selectedrowindex];

            string ID = Convert.ToString(selectedRow.Cells["ID"].Value);
            return int.Parse(ID);
        }
        #endregion
    }
}
