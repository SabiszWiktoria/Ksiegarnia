
namespace TwojaBiblioteka
{
    partial class OknoDodaniaKsiazki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoDodaniaKsiazki));
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.nOcena = new System.Windows.Forms.NumericUpDown();
            this.mtxtRokWydania = new System.Windows.Forms.MaskedTextBox();
            this.cmbGatunek = new System.Windows.Forms.ComboBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.opis = new System.Windows.Forms.Label();
            this.ocena = new System.Windows.Forms.Label();
            this.rokWydania = new System.Windows.Forms.Label();
            this.gatunek = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.tytul = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nOcena)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtOpis.Location = new System.Drawing.Point(204, 284);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(408, 96);
            this.txtOpis.TabIndex = 41;
            this.txtOpis.Text = "";
            // 
            // nOcena
            // 
            this.nOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.nOcena.Location = new System.Drawing.Point(307, 233);
            this.nOcena.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nOcena.Name = "nOcena";
            this.nOcena.Size = new System.Drawing.Size(120, 35);
            this.nOcena.TabIndex = 40;
            // 
            // mtxtRokWydania
            // 
            this.mtxtRokWydania.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.mtxtRokWydania.Location = new System.Drawing.Point(307, 185);
            this.mtxtRokWydania.Mask = "0000";
            this.mtxtRokWydania.Name = "mtxtRokWydania";
            this.mtxtRokWydania.Size = new System.Drawing.Size(75, 35);
            this.mtxtRokWydania.TabIndex = 39;
            // 
            // cmbGatunek
            // 
            this.cmbGatunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.cmbGatunek.FormattingEnabled = true;
            this.cmbGatunek.Items.AddRange(new object[] {
            "Fantastyka",
            "Sci–Fi",
            "Romans",
            "Historyczna",
            "Horror",
            "Kryminał",
            "Thriller",
            "Biografia",
            "Młodzieżowa",
            "Dziecięca",
            "Obyczajowa"});
            this.cmbGatunek.Location = new System.Drawing.Point(306, 128);
            this.cmbGatunek.Name = "cmbGatunek";
            this.cmbGatunek.Size = new System.Drawing.Size(306, 37);
            this.cmbGatunek.TabIndex = 38;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtAutor.Location = new System.Drawing.Point(307, 77);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(305, 35);
            this.txtAutor.TabIndex = 37;
            // 
            // txtTytul
            // 
            this.txtTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtTytul.Location = new System.Drawing.Point(307, 19);
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(305, 35);
            this.txtTytul.TabIndex = 36;
            // 
            // opis
            // 
            this.opis.AutoSize = true;
            this.opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.opis.Location = new System.Drawing.Point(126, 284);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(65, 29);
            this.opis.TabIndex = 35;
            this.opis.Text = "Opis";
            // 
            // ocena
            // 
            this.ocena.AutoSize = true;
            this.ocena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.ocena.Location = new System.Drawing.Point(126, 235);
            this.ocena.Name = "ocena";
            this.ocena.Size = new System.Drawing.Size(87, 29);
            this.ocena.TabIndex = 34;
            this.ocena.Text = "Ocena";
            // 
            // rokWydania
            // 
            this.rokWydania.AutoSize = true;
            this.rokWydania.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.rokWydania.Location = new System.Drawing.Point(126, 191);
            this.rokWydania.Name = "rokWydania";
            this.rokWydania.Size = new System.Drawing.Size(158, 29);
            this.rokWydania.TabIndex = 33;
            this.rokWydania.Text = "Rok wydania";
            // 
            // gatunek
            // 
            this.gatunek.AutoSize = true;
            this.gatunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.gatunek.Location = new System.Drawing.Point(126, 136);
            this.gatunek.Name = "gatunek";
            this.gatunek.Size = new System.Drawing.Size(108, 29);
            this.gatunek.TabIndex = 32;
            this.gatunek.Text = "Gatunek";
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.autor.Location = new System.Drawing.Point(126, 83);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(73, 29);
            this.autor.TabIndex = 31;
            this.autor.Text = "Autor";
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tytul.Location = new System.Drawing.Point(126, 25);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(68, 29);
            this.tytul.TabIndex = 30;
            this.tytul.Text = "Tytuł";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnDodaj.Location = new System.Drawing.Point(272, 400);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(273, 38);
            this.btnDodaj.TabIndex = 42;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // OknoDodaniaKsiazki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.nOcena);
            this.Controls.Add(this.mtxtRokWydania);
            this.Controls.Add(this.cmbGatunek);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTytul);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.ocena);
            this.Controls.Add(this.rokWydania);
            this.Controls.Add(this.gatunek);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.tytul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "OknoDodaniaKsiazki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OknoDodaniaKsiazki";
            ((System.ComponentModel.ISupportInitialize)(this.nOcena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.NumericUpDown nOcena;
        private System.Windows.Forms.MaskedTextBox mtxtRokWydania;
        private System.Windows.Forms.ComboBox cmbGatunek;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.Label opis;
        private System.Windows.Forms.Label ocena;
        private System.Windows.Forms.Label rokWydania;
        private System.Windows.Forms.Label gatunek;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Button btnDodaj;
    }
}