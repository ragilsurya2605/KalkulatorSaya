
namespace AplikasiCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListPerhitungan = new System.Windows.Forms.ListView();
            this.Hitung = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListPerhitungan);
            this.groupBox1.Location = new System.Drawing.Point(20, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Hasil ]";
            // 
            // ListPerhitungan
            // 
            this.ListPerhitungan.HideSelection = false;
            this.ListPerhitungan.Location = new System.Drawing.Point(12, 36);
            this.ListPerhitungan.Name = "ListPerhitungan";
            this.ListPerhitungan.Size = new System.Drawing.Size(313, 259);
            this.ListPerhitungan.TabIndex = 0;
            this.ListPerhitungan.UseCompatibleStateImageBehavior = false;
            // 
            // Hitung
            // 
            this.Hitung.Location = new System.Drawing.Point(32, 337);
            this.Hitung.Name = "Hitung";
            this.Hitung.Size = new System.Drawing.Size(313, 40);
            this.Hitung.TabIndex = 1;
            this.Hitung.Text = "Hitung";
            this.Hitung.UseVisualStyleBackColor = true;
            this.Hitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 402);
            this.Controls.Add(this.Hitung);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hasil Perhitungan";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ListPerhitungan;
        private System.Windows.Forms.Button Hitung;
    }
}

