namespace NyoB_Lopen
{
    partial class FrmBew
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
            this.cmbAfst = new System.Windows.Forms.ComboBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.btnAn = new System.Windows.Forms.Button();
            this.btnAanp = new System.Windows.Forms.Button();
            this.grbBetaald = new System.Windows.Forms.GroupBox();
            this.rbBetaald = new System.Windows.Forms.RadioButton();
            this.rbNietbetaald = new System.Windows.Forms.RadioButton();
            this.lblAfst = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblKies = new System.Windows.Forms.Label();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.btnVerw = new System.Windows.Forms.Button();
            this.grbBetaald.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAfst
            // 
            this.cmbAfst.FormattingEnabled = true;
            this.cmbAfst.Items.AddRange(new object[] {
            "  5 km",
            "10 km",
            "20 km"});
            this.cmbAfst.Location = new System.Drawing.Point(305, 142);
            this.cmbAfst.Name = "cmbAfst";
            this.cmbAfst.Size = new System.Drawing.Size(208, 40);
            this.cmbAfst.TabIndex = 15;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(305, 74);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(208, 39);
            this.txtNaam.TabIndex = 14;
            // 
            // btnAn
            // 
            this.btnAn.Location = new System.Drawing.Point(175, 465);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(208, 78);
            this.btnAn.TabIndex = 13;
            this.btnAn.Text = "Annuleren";
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // btnAanp
            // 
            this.btnAanp.Location = new System.Drawing.Point(39, 381);
            this.btnAanp.Name = "btnAanp";
            this.btnAanp.Size = new System.Drawing.Size(208, 78);
            this.btnAanp.TabIndex = 12;
            this.btnAanp.Text = "Aanpassen";
            this.btnAanp.UseVisualStyleBackColor = true;
            // 
            // grbBetaald
            // 
            this.grbBetaald.Controls.Add(this.rbBetaald);
            this.grbBetaald.Controls.Add(this.rbNietbetaald);
            this.grbBetaald.Location = new System.Drawing.Point(39, 232);
            this.grbBetaald.Name = "grbBetaald";
            this.grbBetaald.Size = new System.Drawing.Size(393, 128);
            this.grbBetaald.TabIndex = 11;
            this.grbBetaald.TabStop = false;
            this.grbBetaald.Text = "Heeft u betaald?";
            // 
            // rbBetaald
            // 
            this.rbBetaald.AutoSize = true;
            this.rbBetaald.Location = new System.Drawing.Point(6, 38);
            this.rbBetaald.Name = "rbBetaald";
            this.rbBetaald.Size = new System.Drawing.Size(69, 36);
            this.rbBetaald.TabIndex = 3;
            this.rbBetaald.TabStop = true;
            this.rbBetaald.Text = "Ja";
            this.rbBetaald.UseVisualStyleBackColor = true;
            // 
            // rbNietbetaald
            // 
            this.rbNietbetaald.AutoSize = true;
            this.rbNietbetaald.Location = new System.Drawing.Point(6, 80);
            this.rbNietbetaald.Name = "rbNietbetaald";
            this.rbNietbetaald.Size = new System.Drawing.Size(91, 36);
            this.rbNietbetaald.TabIndex = 4;
            this.rbNietbetaald.TabStop = true;
            this.rbNietbetaald.Text = "Nee";
            this.rbNietbetaald.UseVisualStyleBackColor = true;
            // 
            // lblAfst
            // 
            this.lblAfst.AutoSize = true;
            this.lblAfst.Location = new System.Drawing.Point(33, 145);
            this.lblAfst.Name = "lblAfst";
            this.lblAfst.Size = new System.Drawing.Size(186, 32);
            this.lblAfst.TabIndex = 10;
            this.lblAfst.Text = "Kies afstand: ";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(33, 77);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(147, 32);
            this.lblNaam.TabIndex = 9;
            this.lblNaam.Text = "Uw naam: ";
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(33, 9);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(234, 32);
            this.lblKies.TabIndex = 16;
            this.lblKies.Text = "Kies deelnemer:  ";
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Items.AddRange(new object[] {
            "  5 km",
            "10 km",
            "20 km"});
            this.cmbKies.Location = new System.Drawing.Point(305, 6);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(208, 40);
            this.cmbKies.TabIndex = 17;
            // 
            // btnVerw
            // 
            this.btnVerw.Location = new System.Drawing.Point(305, 381);
            this.btnVerw.Name = "btnVerw";
            this.btnVerw.Size = new System.Drawing.Size(208, 78);
            this.btnVerw.TabIndex = 18;
            this.btnVerw.Text = "Verwijderen";
            this.btnVerw.UseVisualStyleBackColor = true;
            // 
            // FrmBew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 583);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerw);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Controls.Add(this.cmbAfst);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.btnAanp);
            this.Controls.Add(this.grbBetaald);
            this.Controls.Add(this.lblAfst);
            this.Controls.Add(this.lblNaam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmBew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bewerken van deelnemer";
            this.grbBetaald.ResumeLayout(false);
            this.grbBetaald.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAfst;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.Button btnAanp;
        private System.Windows.Forms.GroupBox grbBetaald;
        private System.Windows.Forms.RadioButton rbBetaald;
        private System.Windows.Forms.RadioButton rbNietbetaald;
        private System.Windows.Forms.Label lblAfst;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Button btnVerw;
    }
}