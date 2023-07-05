
namespace TwojaBiblioteka
{
    partial class OknoListyKsiazek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoListyKsiazek));
            this.label1 = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.Gatunek = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.cmbGatunek = new System.Windows.Forms.ComboBox();
            this.cmbOcena = new System.Windows.Forms.ComboBox();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tytuł";
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Autor.Location = new System.Drawing.Point(24, 86);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(73, 29);
            this.Autor.TabIndex = 1;
            this.Autor.Text = "Autor";
            // 
            // Gatunek
            // 
            this.Gatunek.AutoSize = true;
            this.Gatunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Gatunek.Location = new System.Drawing.Point(24, 135);
            this.Gatunek.Name = "Gatunek";
            this.Gatunek.Size = new System.Drawing.Size(108, 29);
            this.Gatunek.TabIndex = 2;
            this.Gatunek.Text = "Gatunek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(24, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sortuj według oceny";
            // 
            // txtTytul
            // 
            this.txtTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtTytul.Location = new System.Drawing.Point(165, 41);
            this.txtTytul.MaxLength = 100;
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(480, 35);
            this.txtTytul.TabIndex = 4;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtAutor.Location = new System.Drawing.Point(165, 80);
            this.txtAutor.MaxLength = 100;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(480, 35);
            this.txtAutor.TabIndex = 5;
            // 
            // cmbGatunek
            // 
            this.cmbGatunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.cmbGatunek.FormattingEnabled = true;
            this.cmbGatunek.Location = new System.Drawing.Point(165, 127);
            this.cmbGatunek.Name = "cmbGatunek";
            this.cmbGatunek.Size = new System.Drawing.Size(480, 37);
            this.cmbGatunek.TabIndex = 6;
            // 
            // cmbOcena
            // 
            this.cmbOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.cmbOcena.FormattingEnabled = true;
            this.cmbOcena.Items.AddRange(new object[] {
            "Rosnąco",
            "Malejąco"});
            this.cmbOcena.Location = new System.Drawing.Point(271, 178);
            this.cmbOcena.Name = "cmbOcena";
            this.cmbOcena.Size = new System.Drawing.Size(121, 37);
            this.cmbOcena.TabIndex = 7;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSzukaj.ForeColor = System.Drawing.Color.Black;
            this.btnSzukaj.Location = new System.Drawing.Point(286, 231);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(177, 43);
            this.btnSzukaj.TabIndex = 8;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(42, 280);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(719, 158);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // OknoListyKsiazek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.cmbOcena);
            this.Controls.Add(this.cmbGatunek);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTytul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Gatunek);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "OknoListyKsiazek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OknoListyKsiazek";
            this.Load += new System.EventHandler(this.OknoListyKsiazek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.Label Gatunek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.ComboBox cmbGatunek;
        private System.Windows.Forms.ComboBox cmbOcena;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.ListView listView1;
    }
}