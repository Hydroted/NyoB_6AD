namespace _03_TomA_Minigolf
{
    partial class SpelFormulier
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
            this.Split = new System.Windows.Forms.SplitContainer();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.btnVorige = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnActie = new System.Windows.Forms.Button();
            this.txtFamN = new System.Windows.Forms.TextBox();
            this.txtVoorn = new System.Windows.Forms.TextBox();
            this.lblFamN = new System.Windows.Forms.Label();
            this.lblVoorn = new System.Windows.Forms.Label();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.btnVerw = new System.Windows.Forms.Button();
            this.btnAanp = new System.Windows.Forms.Button();
            this.btnToev = new System.Windows.Forms.Button();
            this.btnNieuwSpel = new System.Windows.Forms.Button();
            this.txtToon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Split)).BeginInit();
            this.Split.Panel1.SuspendLayout();
            this.Split.Panel2.SuspendLayout();
            this.Split.SuspendLayout();
            this.SuspendLayout();
            // 
            // Split
            // 
            this.Split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Split.Location = new System.Drawing.Point(0, 0);
            this.Split.Name = "Split";
            // 
            // Split.Panel1
            // 
            this.Split.Panel1.BackColor = System.Drawing.Color.Tan;
            this.Split.Panel1.Controls.Add(this.btnVolgende);
            this.Split.Panel1.Controls.Add(this.btnVorige);
            this.Split.Panel1.Controls.Add(this.btnStart);
            this.Split.Panel1.Controls.Add(this.btnAnnuleren);
            this.Split.Panel1.Controls.Add(this.btnActie);
            this.Split.Panel1.Controls.Add(this.txtFamN);
            this.Split.Panel1.Controls.Add(this.txtVoorn);
            this.Split.Panel1.Controls.Add(this.lblFamN);
            this.Split.Panel1.Controls.Add(this.lblVoorn);
            this.Split.Panel1.Controls.Add(this.cmbKies);
            this.Split.Panel1.Controls.Add(this.lblKies);
            this.Split.Panel1.Controls.Add(this.btnAfsluiten);
            this.Split.Panel1.Controls.Add(this.btnVerw);
            this.Split.Panel1.Controls.Add(this.btnAanp);
            this.Split.Panel1.Controls.Add(this.btnToev);
            this.Split.Panel1.Controls.Add(this.btnNieuwSpel);
            // 
            // Split.Panel2
            // 
            this.Split.Panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.Split.Panel2.Controls.Add(this.txtToon);
            this.Split.Size = new System.Drawing.Size(844, 650);
            this.Split.SplitterDistance = 281;
            this.Split.TabIndex = 0;
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(129, 397);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(103, 56);
            this.btnVolgende.TabIndex = 15;
            this.btnVolgende.Text = "volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            // 
            // btnVorige
            // 
            this.btnVorige.Location = new System.Drawing.Point(24, 396);
            this.btnVorige.Name = "btnVorige";
            this.btnVorige.Size = new System.Drawing.Size(103, 56);
            this.btnVorige.TabIndex = 14;
            this.btnVorige.Text = "Vorige";
            this.btnVorige.UseVisualStyleBackColor = true;
            this.btnVorige.Click += new System.EventHandler(this.btnVorige_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 215);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(208, 47);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "StartSpel";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(24, 586);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(208, 47);
            this.btnAnnuleren.TabIndex = 12;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnActie
            // 
            this.btnActie.Location = new System.Drawing.Point(24, 533);
            this.btnActie.Name = "btnActie";
            this.btnActie.Size = new System.Drawing.Size(208, 47);
            this.btnActie.TabIndex = 11;
            this.btnActie.Text = "Actie";
            this.btnActie.UseVisualStyleBackColor = true;
            this.btnActie.Click += new System.EventHandler(this.btnActie_Click);
            // 
            // txtFamN
            // 
            this.txtFamN.Location = new System.Drawing.Point(24, 488);
            this.txtFamN.Name = "txtFamN";
            this.txtFamN.Size = new System.Drawing.Size(208, 29);
            this.txtFamN.TabIndex = 10;
            // 
            // txtVoorn
            // 
            this.txtVoorn.Location = new System.Drawing.Point(24, 420);
            this.txtVoorn.Name = "txtVoorn";
            this.txtVoorn.Size = new System.Drawing.Size(208, 29);
            this.txtVoorn.TabIndex = 9;
            // 
            // lblFamN
            // 
            this.lblFamN.AutoSize = true;
            this.lblFamN.Location = new System.Drawing.Point(20, 461);
            this.lblFamN.Name = "lblFamN";
            this.lblFamN.Size = new System.Drawing.Size(128, 24);
            this.lblFamN.TabIndex = 8;
            this.lblFamN.Text = "Familienaam: ";
            // 
            // lblVoorn
            // 
            this.lblVoorn.AutoSize = true;
            this.lblVoorn.Location = new System.Drawing.Point(24, 393);
            this.lblVoorn.Name = "lblVoorn";
            this.lblVoorn.Size = new System.Drawing.Size(103, 24);
            this.lblVoorn.TabIndex = 7;
            this.lblVoorn.Text = "Voornaam:";
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(24, 358);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(208, 32);
            this.cmbKies.TabIndex = 6;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(24, 331);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(141, 24);
            this.lblKies.TabIndex = 13;
            this.lblKies.Text = "Kies een speler";
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(24, 268);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(208, 47);
            this.btnAfsluiten.TabIndex = 5;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // btnVerw
            // 
            this.btnVerw.Location = new System.Drawing.Point(24, 162);
            this.btnVerw.Name = "btnVerw";
            this.btnVerw.Size = new System.Drawing.Size(208, 47);
            this.btnVerw.TabIndex = 3;
            this.btnVerw.Text = "Verwijderen Speler";
            this.btnVerw.UseVisualStyleBackColor = true;
            this.btnVerw.Click += new System.EventHandler(this.btnVerw_Click);
            // 
            // btnAanp
            // 
            this.btnAanp.Location = new System.Drawing.Point(24, 109);
            this.btnAanp.Name = "btnAanp";
            this.btnAanp.Size = new System.Drawing.Size(208, 47);
            this.btnAanp.TabIndex = 2;
            this.btnAanp.Text = "Aanpassen speler";
            this.btnAanp.UseVisualStyleBackColor = true;
            this.btnAanp.Click += new System.EventHandler(this.btnAanp_Click);
            // 
            // btnToev
            // 
            this.btnToev.Location = new System.Drawing.Point(24, 56);
            this.btnToev.Name = "btnToev";
            this.btnToev.Size = new System.Drawing.Size(208, 47);
            this.btnToev.TabIndex = 1;
            this.btnToev.Text = "Toevoegen speler";
            this.btnToev.UseVisualStyleBackColor = true;
            this.btnToev.Click += new System.EventHandler(this.btnToev_Click);
            // 
            // btnNieuwSpel
            // 
            this.btnNieuwSpel.Location = new System.Drawing.Point(24, 3);
            this.btnNieuwSpel.Name = "btnNieuwSpel";
            this.btnNieuwSpel.Size = new System.Drawing.Size(208, 47);
            this.btnNieuwSpel.TabIndex = 0;
            this.btnNieuwSpel.Text = "Nieuw Spel";
            this.btnNieuwSpel.UseVisualStyleBackColor = true;
            this.btnNieuwSpel.Click += new System.EventHandler(this.btnNieuwSpel_Click);
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.Color.Cornsilk;
            this.txtToon.Location = new System.Drawing.Point(17, 25);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtToon.Size = new System.Drawing.Size(517, 608);
            this.txtToon.TabIndex = 0;
            // 
            // SpelFormulier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 650);
            this.ControlBox = false;
            this.Controls.Add(this.Split);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SpelFormulier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minigolf!!";
            this.Load += new System.EventHandler(this.SpelFormulier_Load);
            this.Split.Panel1.ResumeLayout(false);
            this.Split.Panel1.PerformLayout();
            this.Split.Panel2.ResumeLayout(false);
            this.Split.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Split)).EndInit();
            this.Split.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Split;
        private System.Windows.Forms.TextBox txtToon;
        private System.Windows.Forms.Button btnVerw;
        private System.Windows.Forms.Button btnAanp;
        private System.Windows.Forms.Button btnToev;
        private System.Windows.Forms.Button btnNieuwSpel;
        private System.Windows.Forms.Label lblVoorn;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Label lblFamN;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnActie;
        private System.Windows.Forms.TextBox txtFamN;
        private System.Windows.Forms.TextBox txtVoorn;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Button btnVorige;
    }
}

