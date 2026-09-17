namespace NyoB_Lopen
{
    partial class FrmIns
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblAfst = new System.Windows.Forms.Label();
            this.grbBetaald = new System.Windows.Forms.GroupBox();
            this.rbBetaald = new System.Windows.Forms.RadioButton();
            this.rbNietbetaald = new System.Windows.Forms.RadioButton();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnAn = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.cmbAfst = new System.Windows.Forms.ComboBox();
            this.grbBetaald.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(22, 20);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(147, 32);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Uw naam: ";
            // 
            // lblAfst
            // 
            this.lblAfst.AutoSize = true;
            this.lblAfst.Location = new System.Drawing.Point(22, 88);
            this.lblAfst.Name = "lblAfst";
            this.lblAfst.Size = new System.Drawing.Size(186, 32);
            this.lblAfst.TabIndex = 1;
            this.lblAfst.Text = "Kies afstand: ";
            // 
            // grbBetaald
            // 
            this.grbBetaald.Controls.Add(this.rbBetaald);
            this.grbBetaald.Controls.Add(this.rbNietbetaald);
            this.grbBetaald.Location = new System.Drawing.Point(28, 175);
            this.grbBetaald.Name = "grbBetaald";
            this.grbBetaald.Size = new System.Drawing.Size(393, 128);
            this.grbBetaald.TabIndex = 2;
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
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(28, 324);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(208, 78);
            this.btnIns.TabIndex = 5;
            this.btnIns.Text = "Inschrijven";
            this.btnIns.UseVisualStyleBackColor = true;
            // 
            // btnAn
            // 
            this.btnAn.Location = new System.Drawing.Point(294, 324);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(208, 78);
            this.btnAn.TabIndex = 6;
            this.btnAn.Text = "Annuleren";
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(294, 17);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(208, 39);
            this.txtNaam.TabIndex = 7;
            // 
            // cmbAfst
            // 
            this.cmbAfst.FormattingEnabled = true;
            this.cmbAfst.Items.AddRange(new object[] {
            "  5 km",
            "10 km",
            "20 km"});
            this.cmbAfst.Location = new System.Drawing.Point(294, 85);
            this.cmbAfst.Name = "cmbAfst";
            this.cmbAfst.Size = new System.Drawing.Size(208, 40);
            this.cmbAfst.TabIndex = 8;
            // 
            // FrmIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 428);
            this.ControlBox = false;
            this.Controls.Add(this.cmbAfst);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.grbBetaald);
            this.Controls.Add(this.lblAfst);
            this.Controls.Add(this.lblNaam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmIns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inschrijven";
            this.grbBetaald.ResumeLayout(false);
            this.grbBetaald.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblAfst;
        private System.Windows.Forms.GroupBox grbBetaald;
        private System.Windows.Forms.RadioButton rbBetaald;
        private System.Windows.Forms.RadioButton rbNietbetaald;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.ComboBox cmbAfst;
    }
}