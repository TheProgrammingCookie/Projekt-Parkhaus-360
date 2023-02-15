namespace Projekt_360_Parkhaus
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LAnzEtagen = new System.Windows.Forms.Label();
            this.txtbEingabeEtagen = new System.Windows.Forms.TextBox();
            this.LanzParkplaetze = new System.Windows.Forms.Label();
            this.txtbEingabeParkplaetze = new System.Windows.Forms.TextBox();
            this.btnBestätigen = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAnzEtagen
            // 
            this.LAnzEtagen.AutoSize = true;
            this.LAnzEtagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAnzEtagen.Location = new System.Drawing.Point(47, 26);
            this.LAnzEtagen.Name = "LAnzEtagen";
            this.LAnzEtagen.Size = new System.Drawing.Size(177, 20);
            this.LAnzEtagen.TabIndex = 0;
            this.LAnzEtagen.Text = "Eingabe Anzahl Etagen";
            // 
            // txtbEingabeEtagen
            // 
            this.txtbEingabeEtagen.Location = new System.Drawing.Point(73, 60);
            this.txtbEingabeEtagen.Name = "txtbEingabeEtagen";
            this.txtbEingabeEtagen.Size = new System.Drawing.Size(119, 20);
            this.txtbEingabeEtagen.TabIndex = 1;
            this.txtbEingabeEtagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbEingabeEtagen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbEingabeEtagen_KeyPress);
            // 
            // LanzParkplaetze
            // 
            this.LanzParkplaetze.AutoSize = true;
            this.LanzParkplaetze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanzParkplaetze.Location = new System.Drawing.Point(-4, 109);
            this.LanzParkplaetze.Name = "LanzParkplaetze";
            this.LanzParkplaetze.Size = new System.Drawing.Size(274, 20);
            this.LanzParkplaetze.TabIndex = 2;
            this.LanzParkplaetze.Text = "Eingabe Anzahl Parkplätze pro Etage";
            // 
            // txtbEingabeParkplaetze
            // 
            this.txtbEingabeParkplaetze.Location = new System.Drawing.Point(73, 143);
            this.txtbEingabeParkplaetze.Name = "txtbEingabeParkplaetze";
            this.txtbEingabeParkplaetze.Size = new System.Drawing.Size(119, 20);
            this.txtbEingabeParkplaetze.TabIndex = 3;
            this.txtbEingabeParkplaetze.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbEingabeParkplaetze.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbEingabeParkplaetze_KeyPress);
            // 
            // btnBestätigen
            // 
            this.btnBestätigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestätigen.Location = new System.Drawing.Point(12, 201);
            this.btnBestätigen.Name = "btnBestätigen";
            this.btnBestätigen.Size = new System.Drawing.Size(112, 51);
            this.btnBestätigen.TabIndex = 4;
            this.btnBestätigen.Text = "Bestätigen";
            this.btnBestätigen.UseVisualStyleBackColor = true;
            this.btnBestätigen.Click += new System.EventHandler(this.btnBestätigen_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Location = new System.Drawing.Point(145, 201);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(112, 51);
            this.btnBeenden.TabIndex = 5;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 289);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnBestätigen);
            this.Controls.Add(this.txtbEingabeParkplaetze);
            this.Controls.Add(this.LanzParkplaetze);
            this.Controls.Add(this.txtbEingabeEtagen);
            this.Controls.Add(this.LAnzEtagen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAnzEtagen;
        private System.Windows.Forms.TextBox txtbEingabeEtagen;
        private System.Windows.Forms.Label LanzParkplaetze;
        private System.Windows.Forms.TextBox txtbEingabeParkplaetze;
        private System.Windows.Forms.Button btnBestätigen;
        private System.Windows.Forms.Button btnBeenden;
    }
}

