
namespace TwojaBiblioteka
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLista = new System.Windows.Forms.Button();
            this.btnDodajKsiazke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnLista.Location = new System.Drawing.Point(62, 156);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(269, 104);
            this.btnLista.TabIndex = 0;
            this.btnLista.Text = "Lista książek";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnDodajKsiazke
            // 
            this.btnDodajKsiazke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDodajKsiazke.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnDodajKsiazke.Location = new System.Drawing.Point(386, 156);
            this.btnDodajKsiazke.Name = "btnDodajKsiazke";
            this.btnDodajKsiazke.Size = new System.Drawing.Size(271, 104);
            this.btnDodajKsiazke.TabIndex = 1;
            this.btnDodajKsiazke.Text = "Dodaj książkę";
            this.btnDodajKsiazke.UseVisualStyleBackColor = false;
            this.btnDodajKsiazke.Click += new System.EventHandler(this.btnDodajKsiazke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajKsiazke);
            this.Controls.Add(this.btnLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnDodajKsiazke;
    }
}

