namespace Playlist_DeNardo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Brani = new ListBox();
            label1 = new Label();
            progressBar = new ProgressBar();
            txtDurata = new TextBox();
            txtAutore = new TextBox();
            txtTitolo = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Aggiungi = new Button();
            Elimina = new Button();
            Salva = new Button();
            Sfoglia = new Button();
            label5 = new Label();
            Volume = new TrackBar();
            Immagine = new PictureBox();
            txtCerca = new TextBox();
            Play = new Button();
            Pause = new Button();
            Stop = new Button();
            Mute = new Button();
            ((System.ComponentModel.ISupportInitialize)Volume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Immagine).BeginInit();
            SuspendLayout();
            // 
            // Brani
            // 
            Brani.BackColor = Color.Silver;
            Brani.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Brani.ForeColor = Color.Black;
            Brani.FormattingEnabled = true;
            Brani.ItemHeight = 15;
            Brani.Location = new Point(586, 57);
            Brani.Name = "Brani";
            Brani.Size = new Size(202, 244);
            Brani.TabIndex = 0;
            Brani.SelectedIndexChanged += Brani_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(586, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista Brani";
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.Silver;
            progressBar.Location = new Point(40, 256);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(237, 23);
            progressBar.TabIndex = 2;
            // 
            // txtDurata
            // 
            txtDurata.BackColor = Color.Silver;
            txtDurata.Location = new Point(41, 134);
            txtDurata.Name = "txtDurata";
            txtDurata.Size = new Size(100, 23);
            txtDurata.TabIndex = 3;
            // 
            // txtAutore
            // 
            txtAutore.BackColor = Color.Silver;
            txtAutore.Location = new Point(41, 82);
            txtAutore.Name = "txtAutore";
            txtAutore.Size = new Size(100, 23);
            txtAutore.TabIndex = 4;
            // 
            // txtTitolo
            // 
            txtTitolo.BackColor = Color.Silver;
            txtTitolo.Location = new Point(41, 35);
            txtTitolo.Name = "txtTitolo";
            txtTitolo.Size = new Size(100, 23);
            txtTitolo.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 17);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Titolo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 64);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Autore";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 116);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "Durata";
            // 
            // Aggiungi
            // 
            Aggiungi.BackColor = Color.FromArgb(0, 192, 0);
            Aggiungi.Location = new Point(191, 35);
            Aggiungi.Margin = new Padding(0);
            Aggiungi.Name = "Aggiungi";
            Aggiungi.Size = new Size(75, 23);
            Aggiungi.TabIndex = 9;
            Aggiungi.Text = "Aggiungi";
            Aggiungi.UseVisualStyleBackColor = false;
            Aggiungi.Click += Aggiungi_Click;
            // 
            // Elimina
            // 
            Elimina.BackColor = Color.FromArgb(0, 192, 0);
            Elimina.Location = new Point(191, 82);
            Elimina.Margin = new Padding(0);
            Elimina.Name = "Elimina";
            Elimina.Size = new Size(75, 23);
            Elimina.TabIndex = 11;
            Elimina.Text = "Elimina";
            Elimina.UseVisualStyleBackColor = false;
            Elimina.Click += Elimina_Click;
            // 
            // Salva
            // 
            Salva.BackColor = Color.FromArgb(0, 192, 0);
            Salva.FlatAppearance.BorderSize = 0;
            Salva.ForeColor = Color.Black;
            Salva.Location = new Point(191, 134);
            Salva.Margin = new Padding(0);
            Salva.Name = "Salva";
            Salva.Size = new Size(75, 23);
            Salva.TabIndex = 12;
            Salva.Text = "Salva";
            Salva.UseVisualStyleBackColor = false;
            Salva.Click += Salva_Click;
            // 
            // Sfoglia
            // 
            Sfoglia.BackColor = Color.FromArgb(0, 192, 0);
            Sfoglia.Location = new Point(309, 35);
            Sfoglia.Margin = new Padding(0);
            Sfoglia.Name = "Sfoglia";
            Sfoglia.Size = new Size(75, 23);
            Sfoglia.TabIndex = 13;
            Sfoglia.Text = "Sfoglia";
            Sfoglia.UseVisualStyleBackColor = false;
            Sfoglia.Click += Sfoglia_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(387, 35);
            label5.Name = "label5";
            label5.Size = new Size(198, 30);
            label5.TabIndex = 14;
            label5.Text = "Rinominare il file e l'immagine\r\nesattamente con il titolo del brano\r\n";
            // 
            // Volume
            // 
            Volume.Location = new Point(309, 256);
            Volume.Name = "Volume";
            Volume.Size = new Size(138, 45);
            Volume.TabIndex = 15;
            // 
            // Immagine
            // 
            Immagine.BackColor = Color.Transparent;
            Immagine.Image = (Image)resources.GetObject("Immagine.Image");
            Immagine.Location = new Point(328, 68);
            Immagine.Name = "Immagine";
            Immagine.Size = new Size(182, 182);
            Immagine.SizeMode = PictureBoxSizeMode.StretchImage;
            Immagine.TabIndex = 16;
            Immagine.TabStop = false;
            // 
            // txtCerca
            // 
            txtCerca.BackColor = Color.DimGray;
            txtCerca.Location = new Point(586, 27);
            txtCerca.Name = "txtCerca";
            txtCerca.Size = new Size(202, 23);
            txtCerca.TabIndex = 17;
            txtCerca.TextChanged += txtCerca_TextChanged;
            // 
            // Play
            // 
            Play.BackColor = Color.FromArgb(0, 192, 0);
            Play.Location = new Point(40, 215);
            Play.Name = "Play";
            Play.Size = new Size(75, 23);
            Play.TabIndex = 18;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = false;
            Play.Click += Play_Click;
            // 
            // Pause
            // 
            Pause.BackColor = Color.FromArgb(0, 192, 0);
            Pause.Location = new Point(121, 215);
            Pause.Name = "Pause";
            Pause.Size = new Size(75, 23);
            Pause.TabIndex = 19;
            Pause.Text = "Pause";
            Pause.UseVisualStyleBackColor = false;
            Pause.Click += Pause_Click;
            // 
            // Stop
            // 
            Stop.BackColor = Color.FromArgb(0, 192, 0);
            Stop.Location = new Point(202, 215);
            Stop.Name = "Stop";
            Stop.Size = new Size(75, 23);
            Stop.TabIndex = 20;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = false;
            // 
            // Mute
            // 
            Mute.BackColor = Color.FromArgb(0, 192, 0);
            Mute.Location = new Point(461, 256);
            Mute.Name = "Mute";
            Mute.Size = new Size(49, 23);
            Mute.TabIndex = 21;
            Mute.Text = "Mute";
            Mute.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 305);
            Controls.Add(Mute);
            Controls.Add(Stop);
            Controls.Add(Pause);
            Controls.Add(Play);
            Controls.Add(txtCerca);
            Controls.Add(Immagine);
            Controls.Add(Volume);
            Controls.Add(label5);
            Controls.Add(Sfoglia);
            Controls.Add(Salva);
            Controls.Add(Elimina);
            Controls.Add(Aggiungi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTitolo);
            Controls.Add(txtAutore);
            Controls.Add(txtDurata);
            Controls.Add(progressBar);
            Controls.Add(label1);
            Controls.Add(Brani);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Volume).EndInit();
            ((System.ComponentModel.ISupportInitialize)Immagine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Brani;
        private Label label1;
        private ProgressBar progressBar;
        private TextBox txtDurata;
        private TextBox txtAutore;
        private TextBox txtTitolo;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Aggiungi;
        private Button Elimina;
        private Button Salva;
        private Button Sfoglia;
        private Label label5;
        private TrackBar Volume;
        private PictureBox Immagine;
        private TextBox txtCerca;
        private Button Play;
        private Button Pause;
        private Button Stop;
        private Button Mute;
    }
}
