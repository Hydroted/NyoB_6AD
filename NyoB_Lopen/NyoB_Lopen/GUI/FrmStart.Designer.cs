namespace NyoB_Lopen
{
    partial class FrmStart
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
            this.btnIns = new System.Windows.Forms.Button();
            this.btnOpz = new System.Windows.Forms.Button();
            this.btnAfs = new System.Windows.Forms.Button();
            this.btnBew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(12, 12);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(200, 70);
            this.btnIns.TabIndex = 0;
            this.btnIns.Text = "Inschrijven";
            this.btnIns.UseVisualStyleBackColor = true;
            // 
            // btnOpz
            // 
            this.btnOpz.Location = new System.Drawing.Point(12, 164);
            this.btnOpz.Name = "btnOpz";
            this.btnOpz.Size = new System.Drawing.Size(200, 70);
            this.btnOpz.TabIndex = 1;
            this.btnOpz.Text = "Opzoeken";
            this.btnOpz.UseVisualStyleBackColor = true;
            // 
            // btnAfs
            // 
            this.btnAfs.Location = new System.Drawing.Point(12, 240);
            this.btnAfs.Name = "btnAfs";
            this.btnAfs.Size = new System.Drawing.Size(200, 70);
            this.btnAfs.TabIndex = 2;
            this.btnAfs.Text = "Afsluiten";
            this.btnAfs.UseVisualStyleBackColor = true;
            this.btnAfs.Click += new System.EventHandler(this.btnAfs_Click);
            // 
            // btnBew
            // 
            this.btnBew.Location = new System.Drawing.Point(12, 88);
            this.btnBew.Name = "btnBew";
            this.btnBew.Size = new System.Drawing.Size(200, 70);
            this.btnBew.TabIndex = 3;
            this.btnBew.Text = "Bewerken";
            this.btnBew.UseVisualStyleBackColor = true;
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 324);
            this.ControlBox = false;
            this.Controls.Add(this.btnBew);
            this.Controls.Add(this.btnAfs);
            this.Controls.Add(this.btnOpz);
            this.Controls.Add(this.btnIns);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startmenu: ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnOpz;
        private System.Windows.Forms.Button btnAfs;
        private System.Windows.Forms.Button btnBew;
    }
}