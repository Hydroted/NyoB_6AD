namespace NyoB_Wijnen
{
    partial class FrmKeuze
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
            this.btnAanp = new System.Windows.Forms.Button();
            this.btnVerw = new System.Windows.Forms.Button();
            this.btnOpz = new System.Windows.Forms.Button();
            this.btnAnn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToev
            // 
            this.btnToev.Location = new System.Drawing.Point(12, 39);
            this.btnToev.Name = "btnToev";
            this.btnToev.Size = new System.Drawing.Size(192, 53);
            this.btnToev.TabIndex = 0;
            this.btnToev.Text = "Toevoegen";
            this.btnToev.UseVisualStyleBackColor = true;
            this.btnToev.Click += new System.EventHandler(this.btnToev_Click);
            // 
            // btnAanp
            // 
            this.btnAanp.Location = new System.Drawing.Point(210, 39);
            this.btnAanp.Name = "btnAanp";
            this.btnAanp.Size = new System.Drawing.Size(192, 53);
            this.btnAanp.TabIndex = 1;
            this.btnAanp.Text = "Aanpassen";
            this.btnAanp.UseVisualStyleBackColor = true;
            // 
            // btnVerw
            // 
            this.btnVerw.Location = new System.Drawing.Point(12, 112);
            this.btnVerw.Name = "btnVerw";
            this.btnVerw.Size = new System.Drawing.Size(192, 53);
            this.btnVerw.TabIndex = 2;
            this.btnVerw.Text = "Verwijderen";
            this.btnVerw.UseVisualStyleBackColor = true;
            // 
            // btnOpz
            // 
            this.btnOpz.Location = new System.Drawing.Point(210, 112);
            this.btnOpz.Name = "btnOpz";
            this.btnOpz.Size = new System.Drawing.Size(192, 53);
            this.btnOpz.TabIndex = 3;
            this.btnOpz.Text = "Opzoeken";
            this.btnOpz.UseVisualStyleBackColor = true;
            // 
            // btnAnn
            // 
            this.btnAnn.Location = new System.Drawing.Point(120, 181);
            this.btnAnn.Name = "btnAnn";
            this.btnAnn.Size = new System.Drawing.Size(192, 53);
            this.btnAnn.TabIndex = 4;
            this.btnAnn.Text = "Sluiten";
            this.btnAnn.UseVisualStyleBackColor = true;
            this.btnAnn.Click += new System.EventHandler(this.btnAnn_Click);
            // 
            // FrmKeuze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnn);
            this.Controls.Add(this.btnOpz);
            this.Controls.Add(this.btnVerw);
            this.Controls.Add(this.btnAanp);
            this.Controls.Add(this.btnToev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmKeuze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKeuze";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToev;
        private System.Windows.Forms.Button btnAanp;
        private System.Windows.Forms.Button btnVerw;
        private System.Windows.Forms.Button btnOpz;
        private System.Windows.Forms.Button btnAnn;
    }
}