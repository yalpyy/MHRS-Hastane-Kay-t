﻿namespace HastaneKayit
{
    partial class AlinanRandevular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlinanRandevular));
            this.columnHeaderSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKlinikAdii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDoktorAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.frm1kapat = new System.Windows.Forms.Button();
            this.columnHeaderhastane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // columnHeaderSaat
            // 
            this.columnHeaderSaat.Text = "Saat";
            this.columnHeaderSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSaat.Width = 93;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNo,
            this.columnHeaderKlinikAdii,
            this.columnHeaderDoktorAdi,
            this.columnHeaderTarih,
            this.columnHeaderSaat,
            this.columnHeaderid,
            this.columnHeaderhastane});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(-1, 100);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1155, 200);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNo
            // 
            this.columnHeaderNo.Text = "No";
            // 
            // columnHeaderKlinikAdii
            // 
            this.columnHeaderKlinikAdii.Text = "Klinik Adı";
            this.columnHeaderKlinikAdii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderKlinikAdii.Width = 348;
            // 
            // columnHeaderDoktorAdi
            // 
            this.columnHeaderDoktorAdi.Text = "Doktor";
            this.columnHeaderDoktorAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDoktorAdi.Width = 174;
            // 
            // columnHeaderTarih
            // 
            this.columnHeaderTarih.Text = "Tarih";
            this.columnHeaderTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTarih.Width = 136;
            // 
            // columnHeaderid
            // 
            this.columnHeaderid.Text = "R.Kodu";
            this.columnHeaderid.Width = 133;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(935, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Randevuyu İptal Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm1kapat
            // 
            this.frm1kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frm1kapat.BackgroundImage")));
            this.frm1kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frm1kapat.FlatAppearance.BorderSize = 0;
            this.frm1kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frm1kapat.Location = new System.Drawing.Point(1066, 12);
            this.frm1kapat.Name = "frm1kapat";
            this.frm1kapat.Size = new System.Drawing.Size(57, 51);
            this.frm1kapat.TabIndex = 19;
            this.frm1kapat.UseVisualStyleBackColor = true;
            this.frm1kapat.Click += new System.EventHandler(this.frm1kapat_Click);
            // 
            // columnHeaderhastane
            // 
            this.columnHeaderhastane.Text = "Hastane";
            this.columnHeaderhastane.Width = 164;
            // 
            // AlinanRandevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1151, 385);
            this.Controls.Add(this.frm1kapat);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1151, 597);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(951, 297);
            this.Name = "AlinanRandevular";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Almış Olunan Randevular";
            this.Load += new System.EventHandler(this.AlinanRandevular_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeaderSaat;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderNo;
        private System.Windows.Forms.ColumnHeader columnHeaderKlinikAdii;
        private System.Windows.Forms.ColumnHeader columnHeaderDoktorAdi;
        private System.Windows.Forms.ColumnHeader columnHeaderTarih;
        private System.Windows.Forms.ColumnHeader columnHeaderid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button frm1kapat;
        private System.Windows.Forms.ColumnHeader columnHeaderhastane;
    }
}