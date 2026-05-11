using NAudio.Wave;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Playlist_DeNardo
{
    public partial class Form1 : Form
    {
        List<Canzone> Playlist = new List<Canzone>();
        string percorsoJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PlaylistApp", "Playlist.json");
        WaveOutEvent outputDevice = new WaveOutEvent();
        AudioFileReader audioFile;
        class Canzone
        {
            public string Titolo { get; set; }
            public string Autore { get; set; }
            public float Durata { get; set; }

            public Canzone(string titolo, string autore, float durata)
            {
                Titolo = titolo;
                Autore = autore;
                Durata = durata;
            }
        }
        public Form1()
        {
            InitializeComponent();
            string directoryPath = Path.GetDirectoryName(percorsoJson);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (File.Exists(percorsoJson))
            {
                string jsonCaricato = File.ReadAllText(percorsoJson);
                Playlist = JsonSerializer.Deserialize<List<Canzone>>(jsonCaricato);
                if (Playlist != null && Playlist.Count > 0)
                {
                    MessageBox.Show($"Brani caricati: {Playlist.Count.ToString()}");
                    PulisciCaselle();
                }
            }

        }
        private void AggiornaInterfaccia()
        {
            Brani.Items.Clear();
            Playlist = Playlist.OrderBy(c => c.Titolo).ToList();
            foreach (Canzone brano in Playlist)
            {
                Brani.Items.Add($"{brano.Titolo}, {brano.Autore}, {brano.Durata}");
            }
        }
        private void PulisciCaselle()
        {
            txtTitolo.Text = "";
            txtAutore.Text = "";
            txtDurata.Text = "";
            AggiornaInterfaccia();
        }
        private void Aggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitolo.Text)
                || string.IsNullOrWhiteSpace(txtAutore.Text)
                || string.IsNullOrWhiteSpace(txtDurata.Text))
            {
                MessageBox.Show("Attenzione, riempire tutti gli spazi.");
            }
            else
            {
                MessageBox.Show("Canzone aggiunta con successo!");
                Canzone nuovaCanzone = new Canzone(txtTitolo.Text, txtAutore.Text, float.Parse(txtDurata.Text));
                Playlist.Add(nuovaCanzone);
                string json = JsonSerializer.Serialize(Playlist);
                File.WriteAllText(percorsoJson, json);
                PulisciCaselle();
            }
        }
        private void Brani_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = Brani.SelectedIndex;
            if (indice != -1)
            {
                Canzone selezionata = Playlist[indice];
                txtTitolo.Text = selezionata.Titolo;
                txtAutore.Text = selezionata.Autore;
                txtDurata.Text = selezionata.Durata.ToString();
            }
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            int indice = Brani.SelectedIndex;
            if (indice != -1)
            {
                Playlist[indice] = new Canzone(txtTitolo.Text, txtAutore.Text, float.Parse(txtDurata.Text));
                string json = JsonSerializer.Serialize(Playlist);
                File.WriteAllText(percorsoJson, json);
                MessageBox.Show("Canzone salvata con successo!");
                PulisciCaselle();
            }
            else
            {
                MessageBox.Show("Attenzione, seleziona una canzone prima di salvare.");
            }
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            int indice = Brani.SelectedIndex;
            if (indice != -1)
            {
                Playlist.Remove(Playlist[indice]);
                string json = JsonSerializer.Serialize(Playlist);
                File.WriteAllText(percorsoJson, json);
                MessageBox.Show("Canzone eliminata con successo!");
                PulisciCaselle();
            }
            else
            {
                MessageBox.Show("Attenzione, seleziona una canzone prima di eliminare.");
            }
        }
        private void txtCerca_TextChanged(object sender, EventArgs e)
        {
            var filtrata = Playlist.Where(c => c.Autore.ToLower().Contains(txtCerca.Text.ToLower())).ToList();
            Brani.Items.Clear();
            foreach (var c in filtrata)
            {
                Brani.Items.Add($"{c.Titolo}, {c.Autore}");
            }
        }

        private void Sfoglia_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "*.mp3|*.jpg|*.png|*.jpg| Tutti i file (*.*) |*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"File selezionato: {file.FileName}");
                string percorsoOriginale = file.FileName;
                string nomeFile = Path.GetFileName(percorsoOriginale);
                string cartellaDestinazione = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PlaylistApp", "Musica");
                if (!Directory.Exists(cartellaDestinazione))
                {
                    Directory.CreateDirectory(cartellaDestinazione);
                }
                string percorsoFinale = Path.Combine(cartellaDestinazione, nomeFile);
                try
                {
                    File.Copy(percorsoOriginale, percorsoFinale, true);
                    txtTitolo.Text = Path.GetFileNameWithoutExtension(nomeFile);
                    MessageBox.Show("File caricato correttamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante la copia del file:{ex.Message}");
                }

            }
        }
        private void Play_Click(object sender, EventArgs e)
        {
            if (outputDevice.PlaybackState == PlaybackState.Playing)
            {
            }
            else
            {
                if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PlaylistApp", "Musica", $"{txtTitolo.Text}.mp3")))
                {
                    audioFile = new AudioFileReader(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PlaylistApp", "Musica", $"{txtTitolo.Text}.mp3"));
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                }
                else
                {
                    MessageBox.Show("File non trovato. Assicurati di aver caricato un file mp3 valido.");
                }
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();
        }
    }
}
