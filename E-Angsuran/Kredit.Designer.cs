﻿namespace E_Angsuran
{
    partial class Kredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kredit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKtp = new CustomControl.Number();
            this.txtBunga = new CustomControl.Number();
            this.txtTenor = new CustomControl.Number();
            this.txtAngsuran = new CustomControl.MyCurrency();
            this.txtLimit = new CustomControl.MyCurrency();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlamat = new MetroFramework.Controls.MetroTextBox();
            this.txtNama = new MetroFramework.Controls.MetroTextBox();
            this.txtNoKontrak = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtStatusPernikahan = new MetroFramework.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStatusPernikahan);
            this.panel1.Controls.Add(this.txtKtp);
            this.panel1.Controls.Add(this.txtBunga);
            this.panel1.Controls.Add(this.txtTenor);
            this.panel1.Controls.Add(this.txtAngsuran);
            this.panel1.Controls.Add(this.txtLimit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAlamat);
            this.panel1.Controls.Add(this.txtNama);
            this.panel1.Controls.Add(this.txtNoKontrak);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(13, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 354);
            this.panel1.TabIndex = 0;
            // 
            // txtKtp
            // 
            this.txtKtp.Location = new System.Drawing.Point(124, 169);
            this.txtKtp.Name = "txtKtp";
            this.txtKtp.Size = new System.Drawing.Size(282, 24);
            this.txtKtp.TabIndex = 23;
            this.txtKtp.Value = "";
            // 
            // txtBunga
            // 
            this.txtBunga.Location = new System.Drawing.Point(124, 293);
            this.txtBunga.Name = "txtBunga";
            this.txtBunga.Size = new System.Drawing.Size(46, 23);
            this.txtBunga.TabIndex = 22;
            this.txtBunga.Value = "";
            // 
            // txtTenor
            // 
            this.txtTenor.Location = new System.Drawing.Point(124, 264);
            this.txtTenor.Name = "txtTenor";
            this.txtTenor.Size = new System.Drawing.Size(282, 23);
            this.txtTenor.TabIndex = 21;
            this.txtTenor.Value = "";
            // 
            // txtAngsuran
            // 
            this.txtAngsuran.Location = new System.Drawing.Point(124, 322);
            this.txtAngsuran.Name = "txtAngsuran";
            this.txtAngsuran.Size = new System.Drawing.Size(282, 23);
            this.txtAngsuran.TabIndex = 20;
            this.txtAngsuran.Value = "";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(124, 235);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(282, 23);
            this.txtLimit.TabIndex = 17;
            this.txtLimit.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Angsuran";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(124, 77);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(282, 86);
            this.txtAlamat.TabIndex = 10;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(124, 47);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(282, 23);
            this.txtNama.TabIndex = 9;
            // 
            // txtNoKontrak
            // 
            this.txtNoKontrak.Location = new System.Drawing.Point(124, 17);
            this.txtNoKontrak.Name = "txtNoKontrak";
            this.txtNoKontrak.ReadOnly = true;
            this.txtNoKontrak.Size = new System.Drawing.Size(282, 23);
            this.txtNoKontrak.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bunga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tenor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Limit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status Pernikahan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ktp";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(14, 82);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(39, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Alamat";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(14, 50);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Nama";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(14, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(64, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "No. Kontrak";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Location = new System.Drawing.Point(13, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 44);
            this.panel2.TabIndex = 1;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Image")));
            this.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpan.Location = new System.Drawing.Point(320, 0);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(89, 44);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtStatusPernikahan
            // 
            this.txtStatusPernikahan.FormattingEnabled = true;
            this.txtStatusPernikahan.ItemHeight = 23;
            this.txtStatusPernikahan.Items.AddRange(new object[] {
            "Belum Menikah",
            "Menikah"});
            this.txtStatusPernikahan.Location = new System.Drawing.Point(124, 200);
            this.txtStatusPernikahan.Name = "txtStatusPernikahan";
            this.txtStatusPernikahan.Size = new System.Drawing.Size(165, 29);
            this.txtStatusPernikahan.TabIndex = 24;
            // 
            // Kredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Kredit";
            this.Resizable = false;
            this.Text = "Kredit";
            this.Load += new System.EventHandler(this.Kredit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txtAlamat;
        private MetroFramework.Controls.MetroTextBox txtNama;
        private MetroFramework.Controls.MetroTextBox txtNoKontrak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimpan;
        private CustomControl.Number txtBunga;
        private CustomControl.Number txtTenor;
        private CustomControl.MyCurrency txtAngsuran;
        private CustomControl.MyCurrency txtLimit;
        private CustomControl.Number txtKtp;
        private MetroFramework.Controls.MetroComboBox txtStatusPernikahan;
    }
}