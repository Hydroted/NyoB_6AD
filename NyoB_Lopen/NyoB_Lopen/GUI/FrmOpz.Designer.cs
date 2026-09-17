namespace NyoB_Lopen
{
    partial class FrmOpz
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
            this.btnEen = new System.Windows.Forms.Button();
            this.btnAn = new System.Windows.Forms.Button();
            this.btnAlle = new System.Windows.Forms.Button();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.txtToon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEen
            // 
            this.btnEen.Location = new System.Drawing.Point(226, 12);
            this.btnEen.Name = "btnEen";
            this.btnEen.Size = new System.Drawing.Size(208, 78);
            this.btnEen.TabIndex = 21;
            this.btnEen.Text = "1 deelnemer";
            this.btnEen.UseVisualStyleBackColor = true;
            // 
            // btnAn
            // 
            this.btnAn.Location = new System.Drawing.Point(440, 12);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(208, 78);
            this.btnAn.TabIndex = 20;
            this.btnAn.Text = "Annuleren";
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // btnAlle
            // 
            this.btnAlle.Location = new System.Drawing.Point(12, 12);
            this.btnAlle.Name = "btnAlle";
            this.btnAlle.Size = new System.Drawing.Size(208, 78);
            this.btnAlle.TabIndex = 19;
            this.btnAlle.Text = "Alle deelnemers";
            this.btnAlle.UseVisualStyleBackColor = true;
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Items.AddRange(new object[] {
            "  5 km",
            "10 km",
            "20 km"});
            this.cmbKies.Location = new System.Drawing.Point(252, 131);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(396, 40);
            this.cmbKies.TabIndex = 23;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(12, 134);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(234, 32);
            this.lblKies.TabIndex = 22;
            this.lblKies.Text = "Kies deelnemer:  ";
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtToon.Location = new System.Drawing.Point(12, 248);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.Size = new System.Drawing.Size(636, 284);
            this.txtToon.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 25;
            // 
            // lblToon
            // 
            this.lblToon.AutoSize = true;
            this.lblToon.Location = new System.Drawing.Point(12, 200);
            this.lblToon.Name = "lblToon";
            this.lblToon.Size = new System.Drawing.Size(183, 32);
            this.lblToon.TabIndex = 26;
            this.lblToon.Text = "De resultaten";
            // 
            // FrmOpz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 544);
            this.ControlBox = false;
            this.Controls.Add(this.lblToon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Controls.Add(this.btnEen);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.btnAlle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmOpz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opzoeken deelnemer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEen;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.Button btnAlle;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.TextBox txtToon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToon;
    }
}