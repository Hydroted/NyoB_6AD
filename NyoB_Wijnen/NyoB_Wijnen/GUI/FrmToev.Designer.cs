namespace NyoB_Wijnen
{
    partial class FrmToev
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
            this.btnToev = new System.Windows.Forms.Button();
            this.btnAnn = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtJaartal = new System.Windows.Forms.TextBox();
            this.txtDruif = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblJaartal = new System.Windows.Forms.Label();
            this.lblDruif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnToev
            // 
            this.btnToev.Location = new System.Drawing.Point(132, 219);
            this.btnToev.Name = "btnToev";
            this.btnToev.Size = new System.Drawing.Size(192, 53);
            this.btnToev.TabIndex = 1;
            this.btnToev.Text = "Toevoegen";
            this.btnToev.UseVisualStyleBackColor = true;
            // 
            // btnAnn
            // 
            this.btnAnn.Location = new System.Drawing.Point(383, 219);
            this.btnAnn.Name = "btnAnn";
            this.btnAnn.Size = new System.Drawing.Size(192, 53);
            this.btnAnn.TabIndex = 5;
            this.btnAnn.Text = "Annuleren";
            this.btnAnn.UseVisualStyleBackColor = true;
            this.btnAnn.Click += new System.EventHandler(this.btnAnn_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(12, 70);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(192, 39);
            this.txtNaam.TabIndex = 6;
            // 
            // txtJaartal
            // 
            this.txtJaartal.Location = new System.Drawing.Point(243, 70);
            this.txtJaartal.Name = "txtJaartal";
            this.txtJaartal.Size = new System.Drawing.Size(192, 39);
            this.txtJaartal.TabIndex = 7;
            // 
            // txtDruif
            // 
            this.txtDruif.Location = new System.Drawing.Point(477, 70);
            this.txtDruif.Name = "txtDruif";
            this.txtDruif.Size = new System.Drawing.Size(192, 39);
            this.txtDruif.TabIndex = 8;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(58, 35);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(89, 32);
            this.lblNaam.TabIndex = 9;
            this.lblNaam.Text = "Naam";
            // 
            // lblJaartal
            // 
            this.lblJaartal.AutoSize = true;
            this.lblJaartal.Location = new System.Drawing.Point(287, 35);
            this.lblJaartal.Name = "lblJaartal";
            this.lblJaartal.Size = new System.Drawing.Size(100, 32);
            this.lblJaartal.TabIndex = 10;
            this.lblJaartal.Text = "Jaartal";
            // 
            // lblDruif
            // 
            this.lblDruif.AutoSize = true;
            this.lblDruif.Location = new System.Drawing.Point(483, 35);
            this.lblDruif.Name = "lblDruif";
            this.lblDruif.Size = new System.Drawing.Size(175, 32);
            this.lblDruif.TabIndex = 11;
            this.lblDruif.Text = "Druivensoort";
            // 
            // FrmToev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 329);
            this.ControlBox = false;
            this.Controls.Add(this.lblDruif);
            this.Controls.Add(this.lblJaartal);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.txtDruif);
            this.Controls.Add(this.txtJaartal);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnAnn);
            this.Controls.Add(this.btnToev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmToev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmToev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToev;
        private System.Windows.Forms.Button btnAnn;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtJaartal;
        private System.Windows.Forms.TextBox txtDruif;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblJaartal;
        private System.Windows.Forms.Label lblDruif;
    }
}