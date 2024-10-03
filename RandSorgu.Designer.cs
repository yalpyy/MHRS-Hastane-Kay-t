namespace HastaneKayit
{
    partial class RandSorgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandSorgu));
            this.frm1kapat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKlinikAdii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDoktorAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderhastane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // frm1kapat
            // 
            this.frm1kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frm1kapat.BackgroundImage")));
            this.frm1kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frm1kapat.FlatAppearance.BorderSize = 0;
            this.frm1kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frm1kapat.Location = new System.Drawing.Point(821, 12);
            this.frm1kapat.Name = "frm1kapat";
            this.frm1kapat.Size = new System.Drawing.Size(57, 51);
            this.frm1kapat.TabIndex = 66;
            this.frm1kapat.UseVisualStyleBackColor = true;
            this.frm1kapat.Click += new System.EventHandler(this.frm1kapat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 60);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 67;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(304, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Tc Numaranızı Giriniz ...";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Beige;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNo,
            this.columnHeaderKlinikAdii,
            this.columnHeaderDoktorAdi,
            this.columnHeaderTarih,
            this.columnHeaderSaat,
            this.columnHeaderid,
            this.columnHeaderhastane});
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.Location = new System.Drawing.Point(12, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(817, 160);
            this.listView1.TabIndex = 70;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNo
            // 
            this.columnHeaderNo.Text = "No";
            this.columnHeaderNo.Width = 48;
            // 
            // columnHeaderKlinikAdii
            // 
            this.columnHeaderKlinikAdii.Text = "Klinik Adı";
            this.columnHeaderKlinikAdii.Width = 181;
            // 
            // columnHeaderDoktorAdi
            // 
            this.columnHeaderDoktorAdi.Text = "Doktor Adı";
            this.columnHeaderDoktorAdi.Width = 129;
            // 
            // columnHeaderTarih
            // 
            this.columnHeaderTarih.Text = "Tarih";
            this.columnHeaderTarih.Width = 93;
            // 
            // columnHeaderSaat
            // 
            this.columnHeaderSaat.Text = "Saat";
            this.columnHeaderSaat.Width = 73;
            // 
            // columnHeaderid
            // 
            this.columnHeaderid.Text = "Randevu Kodu";
            this.columnHeaderid.Width = 94;
            // 
            // columnHeaderhastane
            // 
            this.columnHeaderhastane.Text = "Hastane";
            this.columnHeaderhastane.Width = 195;
            // 
            // RandSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(887, 369);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.frm1kapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(170, 180);
            this.Name = "RandSorgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RandSorgu";
            this.Load += new System.EventHandler(this.RandSorgu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frm1kapat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderNo;
        private System.Windows.Forms.ColumnHeader columnHeaderKlinikAdii;
        private System.Windows.Forms.ColumnHeader columnHeaderDoktorAdi;
        private System.Windows.Forms.ColumnHeader columnHeaderTarih;
        private System.Windows.Forms.ColumnHeader columnHeaderSaat;
        private System.Windows.Forms.ColumnHeader columnHeaderid;
        private System.Windows.Forms.ColumnHeader columnHeaderhastane;
    }
}