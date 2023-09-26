namespace palikasiDataMahasiswa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textNim = new System.Windows.Forms.TextBox();
            this.textKelas = new System.Windows.Forms.TextBox();
            this.textNilai = new System.Windows.Forms.TextBox();
            this.simpan = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.hapus = new System.Windows.Forms.Button();
            this.tampilkan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KELAS ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NILAI";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(106, 41);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 4;
            this.textName.TextChanged += new System.EventHandler(this.trextName_TextChanged);
            // 
            // textNim
            // 
            this.textNim.Location = new System.Drawing.Point(106, 8);
            this.textNim.Name = "textNim";
            this.textNim.Size = new System.Drawing.Size(100, 20);
            this.textNim.TabIndex = 5;
            // 
            // textKelas
            // 
            this.textKelas.Location = new System.Drawing.Point(106, 80);
            this.textKelas.Name = "textKelas";
            this.textKelas.Size = new System.Drawing.Size(100, 20);
            this.textKelas.TabIndex = 6;
            // 
            // textNilai
            // 
            this.textNilai.Location = new System.Drawing.Point(106, 118);
            this.textNilai.Name = "textNilai";
            this.textNilai.Size = new System.Drawing.Size(100, 20);
            this.textNilai.TabIndex = 7;
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(8, 176);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(75, 23);
            this.simpan.TabIndex = 8;
            this.simpan.Text = "simpan";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(117, 176);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 9;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwMahasiswa);
            this.groupBox1.Controls.Add(this.hapus);
            this.groupBox1.Controls.Add(this.tampilkan);
            this.groupBox1.Location = new System.Drawing.Point(308, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 413);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.HideSelection = false;
            this.lvwMahasiswa.Location = new System.Drawing.Point(6, 67);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(458, 333);
            this.lvwMahasiswa.TabIndex = 13;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            // 
            // hapus
            // 
            this.hapus.Location = new System.Drawing.Point(108, 25);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(75, 23);
            this.hapus.TabIndex = 12;
            this.hapus.Text = "hapus ";
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // tampilkan
            // 
            this.tampilkan.Location = new System.Drawing.Point(17, 25);
            this.tampilkan.Name = "tampilkan";
            this.tampilkan.Size = new System.Drawing.Size(75, 23);
            this.tampilkan.TabIndex = 11;
            this.tampilkan.Text = "tampil";
            this.tampilkan.UseVisualStyleBackColor = true;
            this.tampilkan.Click += new System.EventHandler(this.tampilkan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.textNilai);
            this.Controls.Add(this.textKelas);
            this.Controls.Add(this.textNim);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Input Data Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textNim;
        private System.Windows.Forms.TextBox textKelas;
        private System.Windows.Forms.TextBox textNilai;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwMahasiswa;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button tampilkan;
    }
}

